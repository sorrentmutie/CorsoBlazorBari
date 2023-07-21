using System.ComponentModel.DataAnnotations;

namespace DemoBlazorLibrary;

public class Cliente
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Il nome è obbligatorio")]
    [StringLength(50, ErrorMessage = "Il nome deve essere al massimo di 50 caratteri")]
    public string? Nome { get; set; }
    [Required(ErrorMessage = "Il cognome è obbligatorio")]
    [StringLength(50, ErrorMessage = "Il cognome deve essere al massimo di 50 caratteri")]
    public string? Cognome { get; set; }    
    public DateTime DataNascita { get; set; }
    public string? Email { get; set; }  
}
