using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BeautyStore.services;


namespace BeautyStore.models
{
    class BeautyProducts
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Brands { get; set; }
        public string Types { get; set; }
        public string Color { get; set; }
        public string Sizes { get; set; }
        public string Description { get; set; }

        public void Save()
        {
            DB.connection.Open();

            string query = "INSERT INTO dbo.BeautyProducts(productName, price, category, subCategory, brands, types, color, sizes, description) values(" + "'" + this.ProductName + "','" + this.Price + "','" + this.Category + "','" + this.SubCategory + "','" + this.Brands + "','" + this.Types + "','" + this.Color + "','" + this.Sizes + "','" + this.Description + "')";

            SqlCommand cmd = new SqlCommand(query, DB.connection);

            cmd.ExecuteNonQuery();

            DB.connection.Close();
        }

        public void delete()
        {
            DB.connection.Open();

            string query = $"DELETE FROM dbo.BeautyProducts WHERE productId = {this.ProductId}";

            SqlCommand cmd = new SqlCommand(query, DB.connection);

            cmd.ExecuteNonQuery();

            DB.connection.Close();
        }

        public void update()
        {
            DB.connection.Open();

            string query = $"UPDATE dbo.BeautyProducts SET productName='{this.ProductName}', price='{this.Price}', category='{this.Category}', subCategory='{this.SubCategory}', brands='{this.Brands}', types='{this.Types}', color='{this.Color}', sizes='{this.Sizes}', description='{this.Description}' WHERE productId={this.ProductId}"; 
            
            SqlCommand cmd = new SqlCommand(query, DB.connection);

            cmd.ExecuteNonQuery();

            DB.connection.Close();
        }

        static public BeautyProducts findById(int ProductId)
        {
            DB.connection.Open();

            string query = $"SELECT * FROM  dbo.BeautyProducts WHERE productId = '{ProductId}'";

            SqlCommand cmd = new SqlCommand(query, DB.connection);

            SqlDataReader reader = cmd.ExecuteReader();

            BeautyProducts temp = new BeautyProducts();

            if (reader.Read())
            {
                //Console.WriteLine(String.Format("{0}", reader[0]));
                temp.ProductId = (int)reader[0];
                temp.ProductName = (string)reader[1];
                // continue doing it for all parameters ...
                
                return temp;
            }

            DB.connection.Close();

            return null;

        }

        static public List<BeautyProducts> findAll(int ProductId)
        {
            DB.connection.Open();

            string query = $"SELECT * FROM  dbo.BeautyProducts";

            SqlCommand cmd = new SqlCommand(query, DB.connection);

            SqlDataReader reader = cmd.ExecuteReader();

            List<BeautyProducts> listOfProducts = new List<BeautyProducts>(); 

            while (reader.Read())
            {
                BeautyProducts temp = new BeautyProducts();
                //Console.WriteLine(String.Format("{0}", reader[0]));
                temp.ProductId = (int)reader[0];
                temp.ProductName = (string)reader[1];
                // continue doing it for all parameters ...

                listOfProducts.Add(temp);
            }
           
            DB.connection.Close();

            return listOfProducts;
        }


    }
}
