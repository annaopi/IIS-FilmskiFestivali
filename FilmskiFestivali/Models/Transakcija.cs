using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("TRANSAKCIJA")]
public class Transakcija
{
    [Key]
    [Column("transakcija_id")]
    public int TransakcijaId { get; set; }

    [Column("iznos", TypeName = "decimal(18,2)")]
    public decimal Iznos { get; set; }

    [Column("nacin_placanja")]
    [MaxLength(50)]
    public string NacinPlacanja { get; set; } = null!;

    [Column("status")]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    [Column("korisnik_id")]
    public int KorisnikId { get; set; }

    [ForeignKey(nameof(KorisnikId))]
    public Korisnik Korisnik { get; set; } = null!;
}
