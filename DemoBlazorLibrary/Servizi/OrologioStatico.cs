
namespace DemoBlazorLibrary.Servizi;

public class OrologioStatico : IOrologio
{
    public DateTime EstraiOraCorrente()
    {
        return new DateTime(2000,1,1,18,34,5);
    }
}
