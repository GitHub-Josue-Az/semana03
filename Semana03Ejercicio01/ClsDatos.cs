using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Semana03Ejercicio01
{
    class ClsDatos
    {

        public SqlConnection LeerCadena()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CCLVF41\\SQLEXPRESS;Initial Catalog=neptuno;Integrated Security=True");
            return connection;
        }


        public DataTable ListaPedidoFechas(DateTime x, DateTime y)
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("usp_fecha", connection);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@FEC1", x);
            sqlData.SelectCommand.Parameters.AddWithValue("@FEC2", y);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            connection.Close();
            return dataTable;
        }


        public DataTable ListarDetalle(int x)
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("usp_detalle", connection);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@IdPedido", x);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            connection.Close();
            return dataTable;
        }


        public double PedidoTotal(Int32 idpedido)
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("usp_Total", connection);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@IdPedido", idpedido);
            sqlData.SelectCommand.Parameters.Add(
                    "@Total", SqlDbType.Money).Direction =
                    ParameterDirection.Output;
            //DEVUELVE UN SOLO VALOR
            sqlData.SelectCommand.ExecuteScalar();
            
            Int32 total = Convert.ToInt32(
               sqlData.SelectCommand.Parameters["@Total"].Value);

            connection.Close();
            return total;
        }


    }
}
