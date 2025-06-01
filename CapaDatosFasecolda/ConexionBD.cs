using LogicaNegocio;
using Microsoft.Data.SqlClient;
using static LogicaNegocio.AccidenteDTO;
using static LogicaNegocio.Logica;

namespace CapaDatosFasecolda
{
    public class ConexionBD : FuenteDeDatosFasecolda
    {
        private SqlConnection conexion;

        public ConexionBD()
        {
            this.conexion = new SqlConnection(@"TrustServerCertificate=True;Password=2003;Persist Security Info=True;User ID=sa;Initial Catalog=MS_Fasecold;Data Source=DESKTOP-VJ6Q10E\SQLEXPRESS");
        }

        
        public ConteoAccidenteDTO consultarCantidadAccidentesPorPlaca(string placa)
        {
            conexion.Open();

            var conteo = new ConteoAccidenteDTO();

            string query = @"
                SELECT severidad, COUNT(*) as cantidad 
                FROM fasecold 
                WHERE placa = @placa 
                GROUP BY severidad";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@placa", placa);


            SqlDataReader dataReader = comando.ExecuteReader();


            while (dataReader.Read())
            {
                string severidad = dataReader["severidad"].ToString().ToLower();
                int cantidad = Convert.ToInt32(dataReader["cantidad"]);

                if (severidad.Contains("solo latas"))
                    conteo.soloLatas = cantidad;
                else if (severidad.Contains("herido"))
                    conteo.heridos = cantidad;
                else if (severidad.Contains("muerto"))
                    conteo.muertos = cantidad;
            }

            conexion.Close();

            return conteo;
        }
    }
}
