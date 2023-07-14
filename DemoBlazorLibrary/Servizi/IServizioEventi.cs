namespace DemoBlazorLibrary.Servizi;

public interface IServizioEventi
{
    int Contatore { get; }

    void AumentaContatore();
    List<Evento> EstraiEventiFuturi();
    List<Evento> EstraiEventiPassati();
    string Saluto();
}