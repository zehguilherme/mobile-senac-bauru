using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Velha.Modelos;

namespace Velha.Serviços
{
    public class DB
    {
        readonly SQLiteAsyncConnection _database;

        public DB(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Partida>().Wait();
        }

        //Lista todas as partidas
        public Task<List<Partida>> GetPartidasAsync()
        {
            return _database.Table<Partida>().ToListAsync();
        }

        //Listar uma partida
        public Task<Partida> GetPartidaAsync(int id)
        {
            return _database.Table<Partida>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }

        //Salvar partida
        public Task<int> SavePartidaAsync(Partida partida)
        {
            if (partida.ID != 0)
            {
                return _database.UpdateAsync(partida);
            }
            else
            {
                return _database.InsertAsync(partida);
            }
        }

        //Deletar partida
        public Task<int> DeletePartidaAsync (Partida partida)
        {
            return _database.DeleteAsync(partida);
        }
    }
}
