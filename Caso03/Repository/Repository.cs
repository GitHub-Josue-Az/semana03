using Caso03.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso03
{
    public class Repository
    {
        public SqlConnection cn;

        public Repository()
        {
            cn = new SqlConnection("Data Source=DESKTOP-CCLVF41\\SQLEXPRESS;Initial Catalog=neptuno;Integrated Security=True");
            cn.Open();
        }

        public SqlDataReader listarCliente()
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Usp_ListarClientes");
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Empleado> ListaEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            Empleado E;
            SqlDataReader lector;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_ListarEmpleados");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    E = new Empleado();
                    E.IdEmpleado = (int)(lector[0]);
                    E.Apellidos = (string)(lector[1]);
                    E.Nombres = (string)(lector[2]);
                    E.Nacimiento = (DateTime)(lector[3]);
                    E.Direccion = (string)(lector[4]);
                    empleados.Add(E);
                }
                return empleados;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }
        
        public List<string> listaPais()
        {
            List<string> paises = new List<string>();
            SqlDataReader lector;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_pais");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    paises.Add((string)(lector[0]));
                }
                return paises;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }

        public List<Proveedor> ListarProveedores()
        {
            List<Proveedor> proveedors = new List<Proveedor>();
            Proveedor P;
            SqlDataReader lector;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_listarProveedor");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    P = new Proveedor();
                    P.Codigo = (int)(lector[0]);
                    P.Nombre = (string)(lector[1]);
                    P.Pais = (string)(lector[2]);
                    P.Ciudad = (string)(lector[3]);

                    proveedors.Add(P);
                }
                return proveedors;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }
        }

        public bool Login(string usuario,string contra)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_login");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password",contra);
                cmd.Parameters.AddWithValue("@response", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.ExecuteScalar();
                int response = int.Parse(cmd.Parameters["@response"].Value.ToString());
                if (response == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
