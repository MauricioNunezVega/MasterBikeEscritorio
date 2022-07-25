//Autor: Styf Caballero - Mauricio Nuñez

//Referencias a usar:
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.IO;
using Masterbike.Controlador;

namespace Masterbike.Vista//Espacio de trabajo perteneciente a la capa vista.
{
    //Formulario que ofrece la funcionalidad de subir un archivo plano para actualizar los datos que contiene a la BD:
    public partial class Inicio : Form//Clase inicio de tipo formulario (Formulario Inicio).
    {
        //Variables de la clase:
        ControladorInicio controlador = new ControladorInicio();//Variable que controlará esta clase formulario.
        string Separador;

        //Método constructor sin parámetros:
        public Inicio()
        {
            InitializeComponent();//Se inicializan los componentes del formulario.
        }

        //Método constructor con parámetros:
        public Inicio(string nombreUsuarioIngresado, string apellidoUsuarioIngresado, string idUsuarioIngresado)//Se recibe como parámetro los datos del usuario que inició sesión.
        {
            InitializeComponent();//Se inicializan los componentes del formulario.
            //Se establece el estilo visual del formulario
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            lblBienvenido.Text = "BIENVENIDO ";//Se concatena el nombre y apellido del usuario en el lblBienvenido.
            lblNombreUsuario.Text = nombreUsuarioIngresado.ToUpper();
            lblApellido.Text = apellidoUsuarioIngresado.ToUpper();
            lblConvenio.Visible = false;
        }

        //Funcionalidades estéticas del formulario:
        #region Funcionalidades esteticas del formulario

        //Autor: Mauricio Nuñez
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        #endregion

        //Métodos:
        #region Metodos
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
      
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Captura de coordenadas de pantalla.
        int lx, ly;
        int sw, sh;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Método que abre una ventana para buscar el archivo plano que se desea cargar. también se muestran los datos que éste contiene en un listbox:
        private void btnSeleccionar_Click(object sender, EventArgs e)//Método invocado al hacer click en el botón seleccionar (btnSeleccionar).
        {
            try
            {
                OpenFileDialog explorar = new OpenFileDialog();//Variable que mostrará la ventana para buscar el archivo plano.
                explorar.ShowDialog();//Se muestra la ventana creada.
                txtRuta.Text = explorar.FileName;//Se establece en el text de txtRuta la ruta del archivo seleccionado.
                TextReader lectorArchivo = new StreamReader(txtRuta.Text);//Variable que contendrá el texto del archivo especificado.
                string cadenaTextoLeido = lectorArchivo.ReadLine();//Variable que almacenará una línea del texto de la variable creada anteriormente.
                lsbLista.Items.Clear();//Se limpian los items del listbox.
                while (cadenaTextoLeido != null)//Mientras la variable no sea nula, se procede:
                {
                    lsbLista.Items.Add(cadenaTextoLeido);//Se agrega al listbox la línea de texto que contiene la variable.
                    cadenaTextoLeido = lectorArchivo.ReadLine();//La variable cadenaTextoLeido lee la siguiente línea de texto de la variable lectorArchivo.
                }
                lectorArchivo.Close();//Se cierra el lector activo.
                lblErrorRuta.Visible = false;//Se invisibiliza el label especificado.
            }
            catch (Exception)
            {
                txtRuta.Text = null;
            }
        }

        //Método que envía al controlador la ruta y tipo de convenio seleccionado y retorna el resultado de la tarea de carga:
        private void btnCargar_Click(object sender, EventArgs e)//Método convocado al hacer click en el botón Cargar (btn_CArgar).
        {
            //Variables locales:
            Boolean errorRuta = true;//Variable que informa si existe la ruta de un archivo plano o no.
            Boolean errorTipoConvenio = true;//Variable que informa si se ha seleccionado el tipo de convenio o no.
            Boolean errorSeparador = true;

            //Procedimientos:
            if (txtRuta.Text == " " || txtRuta.Text == null || txtRuta.Text.Length == 0)//Si no hay ruta de archivo en el campo especificado, se procede:
            {
                lblErrorRuta.Visible = true;//Se visibiliza el label correspondiente.
            }
            else//Si existe la ruta de un archivo en el campo correspondiente, se procede:
            {
                errorRuta = false;//Se informa que no hay errores.
                lblErrorRuta.Visible = false;//Se invisibiliza el label especificado.
            }

            if (rbEmpresa.Checked == false && rbMunicipalidad.Checked == false && rbClubDeportivo.Checked == false)//Si ningún radiobutton está seleccionado, se procede:
            {
                lblErrorTipoConvenio.Visible = true;//Se visibiliza el label correspondiente.
            }
            else//Si hay radiobutton seleccionado, se procede:
            {
                errorTipoConvenio = false;//Se informa que no hay errores.
                lblErrorTipoConvenio.Visible = false;//Se invisibiliza el label especificado.
            }

            if (rbComa.Checked == false && rbPuntoComa.Checked == false && rbEspacio.Checked == false)
            {
                lblErrorSeparador.Visible = true;
            }
            else 
            {
                errorSeparador = false;
                lblErrorSeparador.Visible = false;
            }

            if (errorRuta == false && errorTipoConvenio == false && errorSeparador == false)//Si no hay errores informados por las variables especificadas, se procede.
            {
                if (controlador.CargarDatos(txtRuta.Text, lblConvenio.Text, Separador))//Si el método invocado por el controlador, retorna true, se procede:
                {
                    Mensaje formularioMensaje = new Mensaje(true);//Se crea un nuevo formulario mensaje.
                    formularioMensaje.Show();//Se muestra el formulario.
                }
                else//Si el método invocado por el controlador, retorna false, se procede:
                {
                    Mensaje formularioMensaje = new Mensaje(false);//Se crea un nuevo formulario mensaje.
                    formularioMensaje.Show();//Se muestra el formulario.
                }
            }
        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            lblConvenio.Text = "Empresa";
        }

        private void rbMunicipalidad_CheckedChanged(object sender, EventArgs e)
        {
            lblConvenio.Text = "Municipalidad";
        }

        private void rbClubDeportivo_CheckedChanged(object sender, EventArgs e)
        {
            lblConvenio.Text = "Club Deportivo";
        }

        private void rbComa_CheckedChanged(object sender, EventArgs e)
        {
            Separador = ",";
        }

        private void rbPuntoComa_CheckedChanged(object sender, EventArgs e)
        {
            Separador = ";";
        }

        private void rbEspacio_CheckedChanged(object sender, EventArgs e)
        {
            Separador = " ";
        }

        //Método que cierra la sesión iniciada:
        private void btnCerraSesion_Click(object sender, EventArgs e)//Método convocado al hacer click en el botón cerrar sesion (btnCerrarSesion).
        {
            IniciarSesion formularioIniciarSesion = new IniciarSesion();//Se crea un formulario iniciar sesion.
            this.Close();//Se cierra esta ventana.
            formularioIniciarSesion.Show();//Se muestra el formulario creado.
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
    }
}
