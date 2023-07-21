using DemoBlazorLibrary;
using DemoBlazorLibrary.Servizi;
using System.Net.Http.Json;

namespace DemoBlazorApp.WASM.Data
{
    public class ServizioDatiClientiWASM : IDatiClienti
    {
        private HttpClient httpClient = new HttpClient();

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
            return null;
           
        }

        public async Task<List<Cliente>?> EstraiClientiAsync()
        {
            var response = 
                await httpClient.GetAsync("https://localhost:7280/clienti");
            if (response.IsSuccessStatusCode)
            {
               return await response.Content
                    .ReadFromJsonAsync<List<Cliente>>();
            }
            return null;
        }

        public void ModificaCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
