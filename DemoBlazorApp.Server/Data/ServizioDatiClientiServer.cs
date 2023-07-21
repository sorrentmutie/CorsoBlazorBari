using DemoBlazorLibrary;
using DemoBlazorLibrary.Servizi;
using Microsoft.EntityFrameworkCore;

namespace DemoBlazorApp.Server.Data;

public class ServizioDatiClientiServer : IDatiClienti
{
    private readonly ClientiDbContext database;

    public ServizioDatiClientiServer(ClientiDbContext database)
    {
        this.database = database;
       // this.database.ChangeTracker.AutoDetectChangesEnabled = false;
    }

    public void AggiungiCliente(Cliente cliente)
    {
        database.Clienti.Add(cliente);
        database.SaveChanges();
    }

    public void EliminaCliente(int id)
    {
        var clienteDb = EstraiClientePerId(id);
        if (clienteDb != null)
        {
            database.Entry(clienteDb).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            database.SaveChanges();
        }
        //var cliente = new Cliente {  Id = id };
        //database.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        //database.Clienti.Remove(cliente);

    }

    public Cliente? EstraiClientePerId(int id)
    {
        return database.Clienti.Find(id);
    }

    public List<Cliente>? EstraiClienti()
    {
       var clienti = database.Clienti;
       
       return clienti.ToList();
    }

    public async Task<List<Cliente>?> EstraiClientiAsync()
    {
        var clienti = await database.Clienti.ToListAsync();
        return clienti;
    }

    public void ModificaCliente(Cliente cliente)
    {
        var clienteDb = database.Clienti.Find(cliente.Id);
        if(clienteDb != null)
        {
            clienteDb.Nome = cliente.Nome;
            clienteDb.Cognome = cliente.Cognome;
            clienteDb.Email = cliente.Email;
            clienteDb.DataNascita = cliente.DataNascita;
            database.SaveChanges();
        }
    }
}
