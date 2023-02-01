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
    public class EV_BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public EV_BurgerDatabase(string DatabasePath)
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
    }
    }
