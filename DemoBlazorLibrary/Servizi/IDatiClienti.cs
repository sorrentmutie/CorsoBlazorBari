namespace DemoBlazorLibrary.Servizi
{
    public interface IDatiClienti
    {
        List<Cliente>? EstraiClienti();
        Task<List<Cliente>?>  EstraiClientiAsync();
        Cliente? EstraiClientePerId(int id);
        void AggiungiCliente(Cliente cliente);
        void ModificaCliente(Cliente cliente);
        void EliminaCliente(int id);
    }
}
