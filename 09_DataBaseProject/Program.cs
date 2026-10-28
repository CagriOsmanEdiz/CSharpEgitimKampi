using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net --> SQL yapılarını kullanmamızı sağlayan çerçeve

            Console.WriteLine("***** C# Veri Tabanlı Ürün- Kategori Bilgi Sistemi");
            Console.WriteLine();
            Console.WriteLine();
            string tableNumber;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QJR5I0K\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable(); // Verileri RAM belleğe almayı sağlıyor.
            adapter.Fill(datatable);
            connection.Close();
            foreach(DataRow row in datatable.Rows)
            {
                foreach(var item in row.ItemArray) 
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

        }
    }
}
