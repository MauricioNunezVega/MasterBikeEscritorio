//Autor: Mauricio Nuñez - Styf Caballero

//Referencias a usar:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Espacio de trabajo (proyecto al que pertenece esta clase)
namespace Masterbike.Vista
{
    //Clase "Program" que establece los procedimientos para iniciar la aplicación:
    static class Program
    {
        //Método "Main" (principal) que establece el punto de inicio de la aplicación:
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IniciarSesion()); //Se establece la primera vista que verá el usuario, en este caso, "Iniciar sesion".
        }
    }
}
