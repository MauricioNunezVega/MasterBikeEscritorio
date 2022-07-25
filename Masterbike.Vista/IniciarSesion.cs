//Autor: Mauricio Nuñez - Styf Caballero

//Referencias a usar:
using System;
using System.Drawing;
using System.Windows.Forms;
using Masterbike.Controlador;
using System.Runtime.InteropServices;
using System.Data.OracleClient;

namespace Masterbike.Vista//Espacio de trabajo perteneciente a la capa vista.
{
    //Formulario que inicia la sesión del usuario para que pueda ingresar al sistema:
    public partial class IniciarSesion : Form //Clase Iniciar sesión de tipo formulario (Formulario Iniciar sesión).
    {
        //Variables de la clase:
        ControladorIniciarSesion controlador = new ControladorIniciarSesion();//Variable que controladrá a esta clase formulario.

        //Importe de dlls que gestionarán la estética del formulario:
        #region importe de DLLs
        //Autor: Mauricio Nuñez
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        //Método constructor sin parámetros de la clase:
        public IniciarSesion()
        {
            InitializeComponent(); //Se inicializan los componentes del formulario.
        }

        //Métodos:
        #region Metodos

        //Método que verifica que el usuario esté registrado, sea de rol supervisor y que sus credenciales sean correctas para ingresar al sistema:
        private void btnIngresar_Click(object sender, EventArgs e) //Método convocado al hacer click en el botón ingresar ("btnIngresar").
        {
            //Variables locales:
            OracleDataReader lectorConsulta = controlador.conexionYconsulta(txtCorreo.Text, txtPassword.Text);//Variable que almacena el resultado de la consulta SQL ejecutada por el método especificado.
            
            //Procedimiento:
            if (controlador.IniciarSesion(lectorConsulta))//Se convoca al método iniciar sesión del controlador indicando el resultado de la consulta SQL. Si el usuario existe en la BD, se procede:
            {
                OracleDataReader lectorRol = controlador.conexionYconsulta(txtCorreo.Text, txtPassword.Text);//Variable que almacena el resultado de la consulta SQL ejecutada por el método especificado.
                string rol = controlador.obtenerCampoIdRol(lectorRol);//Variable que almacena el id rol del usuario obtenido de la consulta SQL anterior.

                if (rol != "4")//Si el id rol encontrado es distindo a 4 (supervisor) entonces:
                {
                    lblError.Text = "Error, usted no tiene los privilegios necesarios para iniciar sesión.";//Se establece como texto en el lblError el texto especificado.
                    //Se reestablece el aspecto visual de los controles:
                    txtCorreo.Text = "Correo electrónico";
                    txtPassword.UseSystemPasswordChar = false;
                    txtPassword.Text = "Password";
                    lblError.Visible = true;//Se hace visible el lblError.
                }
                else//Si el id rol encontrado es 4 (supervisor), se procede:
                {
                    OracleDataReader lectorNombre = controlador.conexionYconsulta(txtCorreo.Text, txtPassword.Text);//Variable que almacena el resultado de la consulta SQL ejecutada por el método especificado.
                    string nombre = controlador.obtenerCampoNombre(lectorNombre);//Variable que almacena el string que retorna el método obtenerCampoNombre del controlador.
                    OracleDataReader lectorApellido = controlador.conexionYconsulta(txtCorreo.Text, txtPassword.Text);//Variable que almacena el resultado de la consulta SQL ejecutada por el método especificado.
                    string apellido = controlador.obtenerCampoApellido(lectorApellido);//Variable que almacena el string que retorna el método obtenerCampoApellido del controlador.
                    OracleDataReader lectorId = controlador.conexionYconsulta(txtCorreo.Text, txtPassword.Text);//Variable que almacena el resultado de la consulta SQL ejecutada por el método especificado.
                    string id = controlador.obtenerCampoId(lectorId);//Variable que almacena el string que retorna el método obtenerCampoId del controlador.
                    Inicio formularioInicio = new Inicio(nombre, apellido, id);//Se crea el formulario Inicio enviando como parámetro la variables creadas anteriormente.
                    formularioInicio.Show();//Se muestra el formulario creado.
                    this.Hide();//Se oculta este formulario ("Iniciar sesión").
                }
            }
            else//Si el usuario ingresado no existe en la BD, se procede:
            {
                controlador.cerrarConexion();//Se cierra la conexión a la BD abierta por la consulta.
                lblError.Text = "Error, correo o contraseña incorrecta.";//Se establece como texto en el lblError el texto especificado.
                lblError.Visible = true; ;//Se notifica un error al usuario.
                //Se reestablece el aspecto visual de los controles:
                txtCorreo.Text = "Correo electrónico";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
        }

        //Método convocado al entrar al txtCorreo:
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo electrónico")//Si al ingresar al textbox se encuentra escrito "Correo electronico", éste desaparece.
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;
            }
        }

        //Método convocado al salir al txtCorreo:
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")//Si al dejar el textbox se encuentra vacío, se escribirá "Correo electrónico".
            {
                txtCorreo.Text = "Correo electrónico";
                txtCorreo.ForeColor = Color.White;
            }
        }

        //Método convocado al entrar al txtPassword:
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")//Si al ingresar al textbox se encuentra escrito "Password", éste desaparece y se activa el modo contraseña en la escritura.
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        //Método convocado al salir al txtPassword:
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")//Si al dejar el textbox se encuentra vacío, se escribirá "Password" y se quitará el modo contraseña en la escritura.
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        //Método convocado al hacer click en el botón de cerrar (btnCerrar):
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();//Se cierra la aplicación.
        }

        //Método convocado al hacer click en el botón minimizar (btnMinimizar):
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Se minimiza la ventana.
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOjo_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnOjo_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        #endregion
    }
}
