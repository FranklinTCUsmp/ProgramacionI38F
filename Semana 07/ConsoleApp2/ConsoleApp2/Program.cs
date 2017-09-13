using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new DiscotecaEntities();

            var bebidas = contexto.Bebidas.Where(p => p.Precio < 10).ToList();

            //var bebida = new Bebida();
            //bebida.Nombre = "Pilsen";
            //bebida.Precio = 15;

            //contexto.Bebidas.Add(bebida);

            //contexto.SaveChanges();




            //var lista = new List<Bebida>();

            //// Paso 1: Instanciar la conexión
            //var conexion = new SqlConnection("Data Source=.;Initial Catalog=Discoteca;Integrated Security=true;");
            //conexion.Open();

            //// Paso 2: Establecer el comando
            //var comando = new SqlCommand("SELECT * FROM bebidas", conexion);

            //// Paso 3: Ejecutar el comando
            //var reader = comando.ExecuteReader();

            //while (reader.Read())
            //{
            //    var bebida = new Bebida();
            //    bebida.Id = Convert.ToInt32(reader[0]);
            //    bebida.Nombre = reader[1].ToString();
            //    bebida.Precio = Convert.ToDecimal(reader[2]);

            //    lista.Add(bebida);
            //}
        }
    }

    //public class Bebida
    //{
    //    public int Id { get; set; }
    //    public string Nombre { get; set; }
    //    public decimal Precio { get; set; }
    //}
}
