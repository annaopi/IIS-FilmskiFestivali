using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("ULOGA")]
public class Uloga
{
    [Key]
    [Column("uloga_id")]
    public int UlogaId { get; set; }

    [Column("naziv")]
    [MaxLength(100)]
    public string Naziv { get; set; } = null!;

    [Column("opis")]
    [MaxLength(500)]
    public string? Opis { get; set; }

    public ICollection<KorisnikUloga> KorisnikUloge { get; set; } = new List<KorisnikUloga>();
}
