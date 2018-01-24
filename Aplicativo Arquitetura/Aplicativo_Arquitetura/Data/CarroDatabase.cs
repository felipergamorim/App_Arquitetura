using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Aplicativo_Arquitetura.Models;

namespace Aplicativo_Arquitetura.Data
{
    public class CarroDatabase
    {
        readonly SQLiteAsyncConnection database;

        public CarroDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Carro>().Wait();
            //database.CreateTablesAsync<Escola, Pessoa>().Wait();
        }

        public Task<List<Carro>> GetCarrosAsync()
        {
            return database.Table<Carro>().ToListAsync();
        }


        public Task<Carro> GetItemAsync(int id)
        {
            return database.Table<Carro>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Carro carro)
        {
            if (carro.Id != 0)
            {
                return database.UpdateAsync(carro);
            }
            else
            {
                return database.InsertAsync(carro);
            }
        }

        public Task<int> DeleteItemAsync(Carro carro)
        {
            return database.DeleteAsync(carro);
        }
    }
}
