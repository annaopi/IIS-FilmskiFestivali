using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("REZERVACIJA")]
public class Rezervacija
{
    [Key]
    [Column("rezervacija_id")]
    public int RezervacijaId { get; set; }

    [Column("datum")]
    public DateTime Datum { get; set; }

    [Column("status")]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    [Column("korisnik_id")]
    public int KorisnikId { get; set; }

    [Column("projekcija_id")]
    public int ProjekcijaId { get; set; }

    [ForeignKey(nameof(KorisnikId))]
    public Korisnik Korisnik { get; set; } = null!;

    [ForeignKey(nameof(ProjekcijaId))]
    public Projekcija Projekcija { get; set; } = null!;

    public ICollection<Karta> Karte { get; set; } = new List<Karta>();
}
