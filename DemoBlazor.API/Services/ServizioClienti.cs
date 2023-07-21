using DemoBlazorLibrary;
using DemoBlazorLibrary.Servizi;

namespace DemoBlazor.API.Services;

public class ServizioClienti : IDatiClienti
{
    public void AggiungiCliente(Cliente cliente)
    {
        throw new NotImplementedException();
    }

    public void EliminaCliente(int id)
    {
        throw new NotImplementedException();
    }

    public Cliente? EstraiClientePerId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Cliente>? EstraiClienti()
    {
        var listaClienti = new List<Cliente> {
         new Cliente {  Id = 75, Nome = "Hans", Cognome = "Muller", DataNascita
          = new DateTime(1985,1,1)
         },
         new Cliente {  Id = 76, Nome = "Giovanni", Cognome = "Rossi", DataNascita
            = new DateTime(1982,1,1)
            }
        };
        return listaClienti;
    }

    public Task<List<Cliente>?> EstraiClientiAsync()
    {
        throw new NotImplementedException();
    }

    public void ModificaCliente(Cliente cliente)
    {
        throw new NotImplementedException();
    }
}
