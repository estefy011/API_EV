using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using API_EV.Models_EV;

namespace API_EV.Data_Ev
{
    public class Data_EV
    {
        string _dbPath;
        private SQLiteConnection conn;
        public Data_EV(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Product>();
        }
        

        public int AddNewProduct(Product productsEV)
        {
            Init();
            // int result = conn.Insert(burger);
            //  return result;
            if (productsEV.id != 0)
            {
                conn.Update(productsEV);
                return productsEV.id;
            }
            else
            {
                return conn.Insert(productsEV);
            }
        }

        public int UpdateProduct(Product productEV)
        {
            Init();
            return conn.Update(productEV);
        }

        public List<Product> GetAllProducts()
        {
            Init();
            List<Product> productsEV = conn.Table<Product>().ToList();
            return productsEV;
        }

        public int DeleteProduct(Product itemEV)
        {
            Init();

            return conn.Delete(itemEV);
        }
    }
    }
