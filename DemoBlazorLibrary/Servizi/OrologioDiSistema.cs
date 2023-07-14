namespace DemoBlazorLibrary.Servizi;

public class OrologioDiSistema : IOrologio
{
    public DateTime EstraiOraCorrente()
    {
        return DateTime.Now;
    }
}
