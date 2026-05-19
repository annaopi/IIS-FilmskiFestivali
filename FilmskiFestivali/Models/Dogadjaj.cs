using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("DOGADJAJ")]
public class Dogadjaj
{
    [Key]
    [Column("dogadjaj_id")]
    public int DogadjajId { get; set; }

    [Column("naziv")]
    [MaxLength(200)]
    public string Naziv { get; set; } = null!;

    [Column("opis")]
    [MaxLength(2000)]
    public string? Opis { get; set; }

    [Column("pocetak")]
    public DateTime Pocetak { get; set; }

    [Column("kraj")]
    public DateTime Kraj { get; set; }

    [Column("status")]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    [Column("datum_kreiranja")]
    public DateTime DatumKreiranja { get; set; }

    [Column("sala_id")]
    public int SalaId { get; set; }

    [Column("kreator_id")]
    public int KreatorId { get; set; }

    [ForeignKey(nameof(SalaId))]
    public Sala Sala { get; set; } = null!;

    [ForeignKey(nameof(KreatorId))]
    public Korisnik Kreator { get; set; } = null!;

    public ICollection<Projekcija> Projekcije { get; set; } = new List<Projekcija>();
    public ICollection<Oglas> Oglasi { get; set; } = new List<Oglas>();
    public ICollection<RezervacijaResursa> RezervacijeResursa { get; set; } = new List<RezervacijaResursa>();
    public ICollection<Problem> Problemi { get; set; } = new List<Problem>();
}
