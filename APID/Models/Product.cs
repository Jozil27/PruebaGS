using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APID.Models
{
    public class Product
    {
        public string Codigo; //único
        public string Nombre; // alfanumerico 
        public int Existencia; //cantidad de existencias que tiene cada producto
        public double Precio; //precio de cada producto
        public string factura; //numero de factura
        public string fecha;// cualquier fecyha
        public double total;// siempre mayor a 0 - total de la factura
        public string AddProduct()
        {            
            string connectionString = "Server=localhost;Database=Establecimiento;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_Establecimiento_AddProduct", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Codigo", Codigo));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Existencia", Existencia));
                    cmd.Parameters.Add(new SqlParameter("@Precio", Precio));

                    connection.Open();

                    cmd.ExecuteNonQuery();

                }
                return "hola";
            }
        }
    }
}