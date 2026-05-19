using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("OGLAS")]
public class Oglas
{
    [Key]
    [Column("oglas_id")]
    public int OglasId { get; set; }

    [Column("naziv")]
    [MaxLength(200)]
    public string Naziv { get; set; } = null!;

    [Column("tip")]
    [MaxLength(50)]
    public string Tip { get; set; } = null!;

    [Column("kanal")]
    [MaxLength(50)]
    public string Kanal { get; set; } = null!;

    [Column("status")]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    [Column("datum_kreiranja")]
    public DateTime DatumKreiranja { get; set; }

    [Column("kreator_id")]
    public int KreatorId { get; set; }

    [Column("film_id")]
    public int? FilmId { get; set; }

    [Column("dogadjaj_id")]
    public int? DogadjajId { get; set; }

    [ForeignKey(nameof(KreatorId))]
    public Korisnik Kreator { get; set; } = null!;

    [ForeignKey(nameof(FilmId))]
    public Film? Film { get; set; }

    [ForeignKey(nameof(DogadjajId))]
    public Dogadjaj? Dogadjaj { get; set; }

    public ICollection<VerzijaOglasa> VerzijeOglasa { get; set; } = new List<VerzijaOglasa>();
    public ICollection<Instanca> Instance { get; set; } = new List<Instanca>();
}
