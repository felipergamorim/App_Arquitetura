using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Aplicativo_Arquitetura.Models;

namespace Aplicativo_Arquitetura.Data
{
    public class DataAccess
    {
        readonly SQLiteAsyncConnection database;

        public DataAccess(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTablesAsync<Carro, Escola, Pessoa>().Wait();
        }
    }
}
