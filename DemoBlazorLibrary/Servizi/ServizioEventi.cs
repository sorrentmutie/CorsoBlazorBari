namespace DemoBlazorLibrary.Servizi;

public class ServizioEventi : IServizioEventi
{
    public ServizioEventi(IOrologio orologio)
    {
        contatore = 12;
        this.orologio = orologio;
    }

    private int contatore;
    private readonly IOrologio orologio;

    public void AumentaContatore()
    {
        contatore++;
    }

    // = > è la sintassi per il return di una sola riga
    public int Contatore => contatore;

    public List<Evento> EstraiEventiFuturi()
    {
        return new List<Evento>()
        {
            new Evento { Id = 1, Data = DateTime.Today, Località = "Bari", Nome = "Evento 1"},
            new Evento { Id = 2, Data = DateTime.Today.AddDays(7), Località = "Napoli", Nome = "Evento 2"},
            new Evento { Id = 3, Data = DateTime.Today.AddDays(14), Località = "Roma", Nome = "Evento 3"}
        };
    }

    public List<Evento> EstraiEventiPassati()
    {
        return new List<Evento>()
        {
            new Evento { Id = 1, Data = DateTime.Today.AddDays(-1), Località = "Bari", Nome = "Evento 21"},
            new Evento { Id = 2, Data = DateTime.Today.AddDays(-7), Località = "Napoli", Nome = "Evento 22"},
            new Evento { Id = 3, Data = DateTime.Today.AddDays(-14), Località = "Roma", Nome = "Evento 23"}
        };
    }

    public string Saluto()
    {
        if(orologio.EstraiOraCorrente().Hour < 12)
        {
            return "Buongiorno!";
        } else
        {
            return "Buonasera!";
        }
    }
}


