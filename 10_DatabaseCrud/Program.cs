using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD --> (C)reate, (R)ead, (U)pdate ,(D)elete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------");

            #region Kategori Ekleme İşlemi


            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QJR5I0K\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true; ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice= decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-QJR5I0K\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı: ");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QJR5I0K\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection); // Komutu çalıştır, çalıştıracağın yer ise connection'da tanımlı.
            //SqlDataAdapter adapter = new SqlDataAdapter(command); // Köprü görevi görür, SQL'de yukarıdaki komut çalıştığında çıktı olarak gelecek verileri C#'a çeker.
            //DataTable dataTable = new DataTable(); // RAM'in içerisinde bir tablo oluşturur. SQLDataAdapter kısmındaki kodu tablonun içine ekler.
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) // DataTable'ın row(satırlarını) tek tek oku ve "row" değişkenine yaz.
            //{
            //   foreach(var item in row.ItemArray) 
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //Console.WriteLine();
            //}


            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün ID:");
            //int productId=int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QJR5I0K\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductId= @productId",connection);
            //cmd.Parameters.AddWithValue("@productID", productId);
            //cmd.ExecuteNonQuery();



            //connection.Close();
            //Console.WriteLine("Silme İşlemi Başarıyla Gerçekleşti. ");



            #endregion

            #region Ürün Güncelleme İşlemi
            //Console.Write("Güncellenecek Ürün Id:");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı:");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı:");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QJR5I0K\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@p1,ProductPrice=@p2 where ProductId=@p3", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", productId);
            //command.ExecuteNonQuery();


            //Console.WriteLine("Güncelleme başarılı!");


            #endregion
        }
    }
}
