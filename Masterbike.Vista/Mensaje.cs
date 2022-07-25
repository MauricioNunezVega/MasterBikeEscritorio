//Autor: Styf Caballero

//Referencias a usar:
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masterbike.Vista//Espacio de trabajo perteneciente a la capa vista.
{
    //Formulario que muestra mensaje que notifica al usuario del resultado de sus tareas:
    public partial class Mensaje : Form//Clase mensaje de tipo formulario (Formulario mensaje).
    {
        //Constructor sin parámetros:
        public Mensaje()
        {
            InitializeComponent();//Se inicializan los componentes del formulario.
        }

        //Constructor con parámetros:
        public Mensaje(Boolean resultadoEntrante)//Se recibe como parámetro el resultado exitoso o erróneo de una tarea.
        {
            InitializeComponent();//Se inicializan los componentes del formulario.
            if (resultadoEntrante)//Si la variable entrante es true, se procede:
            {
                lblMensaje.Text = "TAREA REALIZADA CORRECTAMENTE";//Se muestra el mensaje especificado en el lblMensaje.
            }
            else//En caso de que la variable entrante sea false, se procede:
            {
                lblMensaje.ForeColor = Color.Red;//Se cambia el color del lblMensaje.
                lblMensaje.Text = "ERROR";//Se muestra el mensaje especificado en el lblMensaje.
            }
        }

        //Método que cierra este formulario:
        private void button1_Click(object sender, EventArgs e)//Método convocado al hacer click en el botón1 (button1).
        {
            this.Close();//Se cierra este formulario.
        }
    }
}
