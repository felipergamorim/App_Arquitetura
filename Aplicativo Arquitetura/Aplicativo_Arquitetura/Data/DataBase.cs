using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Aplicativo_Arquitetura.Models;

namespace Aplicativo_Arquitetura.Data
{
    public class DataBase
    {
        public readonly SQLiteConnection db;

        public DataBase(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            //db.CreateTablesAsync<Carro, Escola, Pessoa>().Wait(); agr tem q criar cada tabela individualmente
            db.CreateTable<Escola>();
        }
    }
}
