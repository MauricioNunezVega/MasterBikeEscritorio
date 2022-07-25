//Autor: Styf Caballero - Mauricio Nuñez

//Referencias a usar:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Masterbike.Modelo;
using System.Data.OracleClient;
using System.Security.Cryptography;

namespace Masterbike.Controlador//Espacio de trabajo perteneciente a la capa controlador.
{
    //Clase que controla la vista "Iniciar sesion":
    public class ControladorIniciarSesion
    {
        //Variables de la clase:
        #region Variables

        string nombreUsuarioIngresado, apellidoUsuarioIngresado, idUsuarioIngresado, idRolUsuarioIngresado;//Variables que capturan datos de la consulta SQL.
        Conexion conexion = new Conexion();//Variable que gestionará la conexion a la BD.

        #endregion

        //Método constructor sin parámetros:
        public ControladorIniciarSesion() {}

        //Accesadores y mutadores:
        #region Accesadores Mutadores
        public string AMNombreUsuarioIngresado
        {
            get { return nombreUsuarioIngresado; }
            set { nombreUsuarioIngresado = value; }
        }

        public string AMApellidoUsuarioIngresado
        {
            get { return apellidoUsuarioIngresado; }
            set { apellidoUsuarioIngresado = value; }
        }

        public string AMIdUsuarioIngresado
        {
            get { return idUsuarioIngresado; }
            set { idUsuarioIngresado = value; }
        }

        public string AMIdRolUsuarioIngresador
        {
            get { return idRolUsuarioIngresado; }
            set { idRolUsuarioIngresado = value; }
        }

        #endregion

        //Métodos:
        #region Metodos

        //Método que abre una conexion a la BD y ejecuta una consulta SQL retornando su resultado en la variable lectorConsulta:
        public OracleDataReader conexionYconsulta(string email, string password)//Se reciben 2 parámetros desde la vista Iniciar Sesion.
        {
            //Variables locales:
            Consultas consulta = new Consultas();//Variable que gestionará la consulta SQL.
            OracleCommand comandoConsulta = new OracleCommand();//Variable que ejcutará el comando de consulta a la BD.

            //Procedimientos:
            conexion.AMConexion.Open();//Se abre la conexion.
            string passwordMD5 = GetMD5(password);
            comandoConsulta = consulta.AMCorreoPassword;//Se establece la consulta en la variable especificada.
            comandoConsulta.Parameters.AddWithValue(":correo", email);//Se agrega el correo entrante como parámetro a la consulta.
            comandoConsulta.Parameters.AddWithValue(":contraseña", passwordMD5);//Se agrega la contraseña entrante como parámetro de la consulta.
            OracleDataReader lectorConsulta = consulta.AMCorreoPassword.ExecuteReader();//Se ejecuta la consulta, se lee y captura el resultado en la variable lectorConsulta.
            return lectorConsulta;//Se retorna la variable lectorConsulta.
        }

        //Método que verifica correo y contraseña para iniciar sesión:
        public Boolean IniciarSesion(OracleDataReader lector)//Retorna true o false y recibe como parámetro el resultado de la consulta.
        {
            if (lector.Read())//Si la variable lector contiene un valor, se procede:
            {
                cerrarConexion();//Se invoca al método que cierra la conexion a la BD.
                return true;//Se retorna true como resultado.
            }
            else//Si la variable lector no contiene valor, se procede:
            {
                return false;//Se retorna false como resultado.
            }
        }

        //Método que envía a la vista Iniciar Sesion el campo ID_ROL del resultado de la consulta SQL:
        public string obtenerCampoIdRol(OracleDataReader lector)//Recibe como parámetro el resultado de la consulta.
        {
            if (lector.Read())//Si la variable lector contiene un valor, se procede:
            {
                idRolUsuarioIngresado = lector["ID_ROL"].ToString();//Se captura el rol en la variable declarada.
                cerrarConexion();//Se invoca al método que cierra la conexion a la BD.
                return idRolUsuarioIngresado;//Se retorna el campo requerido ya almacenado en la variable.
            }
            else//Si la variable lector no contiene valor, se procede:
            {
                return "error";//Se retorna error en caso de no obtener el campo exitosamente.
            }
        }

        //Método que envía a la vista Iniciar Sesion el campo NOMBRE del resultado de la consulta SQL:
        public string obtenerCampoNombre(OracleDataReader lector)//Se envía como parámetro el resultado de la consulta SQL.
        {
            if (lector.Read())//Si la variable lector contiene un valor, se procede:
            {
                nombreUsuarioIngresado = lector["NOMBRE"].ToString();//Se captura el nombre en la variable declarada.
                cerrarConexion();//Se invoca al método que cierra la conexion a la BD.
                return nombreUsuarioIngresado;//Se retorna el campo requerido ya almacenado en la variable.
            }
            else//Si la variable lector no contiene valor, se procede:
            {
                return "error";//Se retorna error en caso de no obtener el campo exitosamente
            }
        }

        //Método que envía a la vista Iniciar Sesion el campo APELLIDO del resultado de la consulta SQL:
        public string obtenerCampoApellido(OracleDataReader lector)//Se envía como parámetro el resultado de la consulta SQL.
        {
            if (lector.Read())//Si la variable lector contiene un valor, se procede:
            {
                apellidoUsuarioIngresado = lector["APELLIDOS"].ToString();//Se captura el apellido en la variable declarada.
                cerrarConexion();//Se invoca al método que cierra la conexion a la BD.
                return apellidoUsuarioIngresado;//Se retorna el campo requerido ya almacenado en la variable.
            }
            else//Si la variable lector no contiene valor, se procede:
            {
                return "error";//Se retorna error en caso de no obtener el campo exitosamente.
            }
        }

        //Método que envía a la vista Iniciar Sesion el campo ID_USUARIO del resultado de la consulta SQL:
        public string obtenerCampoId(OracleDataReader lector)//Se envía como parámetro el resultado de la consulta SQL.
        {
            if (lector.Read())//Si la variable lector contiene un valor, se procede:
            {
                idUsuarioIngresado = lector["ID_USUARIO"].ToString();//Se captura el id de usuario en la variable declarada.
                cerrarConexion();//Se invoca al método que cierra la conexion a la BD.
                return idUsuarioIngresado;//Se retorna el campo requerido ya almacenado en la variable.
            }
            else//Si la variable lector no contiene valor, se procede:
            {
                return "error";//Se retorna error en caso de no obtener el campo exitosamente.
            }
        }

        //Método que cierra la conexión a la BD:
        public void cerrarConexion()
        {
            conexion.AMConexion.Close();//Se cierra la conexión mediante la variable encargada de la gestión de la conexión.
        }

        public static string GetMD5(string input)
        {
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                byte[] b = System.Text.Encoding.UTF8.GetBytes(input);
                b = MD5.ComputeHash(b);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (byte x in b)

                    sb.Append(x.ToString("x2"));

                return sb.ToString();
            }
        }

        #endregion
    }
}
