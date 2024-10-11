using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTITINERARIO3.ADO.NET
{
    public static class GestorPartidos

    {
        public static List<Partido> getAllPartidos()

        {
            //creo la cadena de conexión bd
            string conectionString = "Data Source=SILVIA\\SQLEXPRESS;Initial Catalog=LigaProfesional;Integrated Security=True";
            //creo el objeto de conexión
            SqlConnection conexion = new SqlConnection(conectionString);

            try
            {
                //abrimos conexion
                conexion.Open();
                //se define la query que vamos a ejecutar
                string query = "select * from Partido";
                // creamos al adapter
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                //se crea el dataset
                DataSet dataSet = new DataSet();
                //llenamos el dataset
                adapter.Fill(dataSet);

                List<Partido> listaPartido = new List<Partido>();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Partido partido = new Partido();
                    partido.Fecha = Convert.ToDateTime(row["FECHA_PARTIDO"]);
                    partido.EquipoLocal = row["EQUIPO_LOCAL"].ToString();
                    partido.EquipoVisitante = row["EQUIPO_VISITANTE"].ToString();
                    partido.GolesEquipoLocal = Convert.ToInt32(row["GOLES_EQUIPO_LOCAL"]);
                    partido.GolesEquipoVisitante = Convert.ToInt32(row["GOLES_EQUIPO_VISITANTE"]);
                    partido.Finalizado = Convert.ToBoolean(row["FINALIZADO"]);
                    listaPartido.Add(partido);
                }
                return listaPartido;

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conexion.Close();
            }
        }

    }
}

