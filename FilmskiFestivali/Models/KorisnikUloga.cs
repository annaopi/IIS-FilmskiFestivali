using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("KORISNIK_ULOGA")]
public class KorisnikUloga
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("korisnik_id")]
    public int KorisnikId { get; set; }

    [Column("uloga_id")]
    public int UlogaId { get; set; }

    [Column("datum_dodele")]
    public DateTime DatumDodele { get; set; }

    [ForeignKey(nameof(KorisnikId))]
    public Korisnik Korisnik { get; set; } = null!;

    [ForeignKey(nameof(UlogaId))]
    public Uloga Uloga { get; set; } = null!;
}
