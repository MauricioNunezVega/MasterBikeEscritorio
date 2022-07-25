//Autor: Styf Caballero.

//Referencias a usar:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Masterbike.Modelo;
using System.Data.OracleClient;

namespace Masterbike.Controlador//Espacio de trabajo perteneciente a la capa controlador.
{
    //Clase que controlará la vista "Inicio":
    public class ControladorInicio
    {
        //Variables:
        Conexion conexion = new Conexion();//Variable que gestionará la conexión a la BD.

        //Métodos:
        #region Metodos

        //Método que actualiza los datos de la tabla USUARIO de la BD mediante los datos contenidos en un archivo plano:
        public Boolean CargarDatos(string ruta, string tipoConvenio, string separador)//Se recibe como parámetro la ruta del archivo plano y el tipo de convenio que tendrán los usuarios especificados.
        {
            //Variables locales:
            Consultas consulta = new Consultas();//Variable que gestionará la consulta a la BD.
            OracleCommand comandoConsultaActualizar = new OracleCommand();//Variable que gestionará la ejecución de los comandos a la BD.
            TextReader lectorArchivo = new StreamReader(ruta);//Variable que contendrá el texto del archivo especificado en la variable ruta.
            string cadenaTextoLeido = lectorArchivo.ReadToEnd();//Variable que contrendrá como string el texto leído del archivo especificado anteriormente.

            //Procedimientos:
            conexion.AMConexion.Open();//Se abre la conexión a la BD.
            try//Se procede:
            {
                comandoConsultaActualizar = consulta.AMProcedimientoActualizar;//Se captura en la variable los datos del procedimiento almacenado especificado en la capa modelo.
                comandoConsultaActualizar.CommandType = System.Data.CommandType.StoredProcedure;//Se especifica el tipo de comando que se ejcutará.
                comandoConsultaActualizar.Parameters.Add("correos", OracleType.LongVarChar).Value = cadenaTextoLeido;//Se agrega como parámetro al procedimiento almacenado la variable especificada.
                comandoConsultaActualizar.Parameters.Add("tipoConvenio", OracleType.VarChar).Value = tipoConvenio;//Se agrega como parámetro al procedimiento almacenado la variable especificada.
                comandoConsultaActualizar.Parameters.Add("separador", OracleType.VarChar).Value = separador;
                comandoConsultaActualizar.ExecuteNonQuery();//Se ejecuta el comando.
                lectorArchivo.Close();//Se cierra el lector del archivo activo.
                conexion.AMConexion.Close();//Se cierra la conexión a la BD.
                return true;//Si todo se ejecuta, se retorna true.
            }
            catch (Exception)//En caso de error en la ejecución, se procede:
            {
                conexion.AMConexion.Close();//Se cierra la conexión a la BD.
                return false;//Se retorna false.
            }
        }

        #endregion
    }
}
