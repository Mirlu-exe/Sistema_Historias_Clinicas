using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEvolucion
    {

        public int id_evol { get; set; }

        public int id_historia { get; set; }

        public DateTime fecha_consulta { get; set; }

        public string edad_suc { get; set; }

        public string plan_terapeutico { get; set; }

        public string plan_estudio { get; set; }

        public string observaciones { get; set; }

        public DateTime prox_consulta { get; set; }

        public string estado { get; set; }





        //Método Mostrar
        public DataTable MostrarEvolucion(DEvolucion evolucion)
        {
            DataTable DtResultado = new DataTable("Evolucion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_evolucion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Historia = new SqlParameter();
                ParId_Historia.ParameterName = "@id_historia";
                ParId_Historia.SqlDbType = SqlDbType.VarChar;
                ParId_Historia.Size = 50;
                ParId_Historia.Value = evolucion.id_historia;
                SqlCmd.Parameters.Add(ParId_Historia);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }




    }
}
