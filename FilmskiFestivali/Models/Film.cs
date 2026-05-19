using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("FILM")]
public class Film
{
    [Key]
    [Column("film_id")]
    public int FilmId { get; set; }

    [Column("naziv")]
    [MaxLength(200)]
    public string Naziv { get; set; } = null!;

    [Column("zanr")]
    [MaxLength(100)]
    public string Zanr { get; set; } = null!;

    [Column("trajanje_min")]
    public int TrajanjeMin { get; set; }

    public ICollection<Projekcija> Projekcije { get; set; } = new List<Projekcija>();
    public ICollection<Oglas> Oglasi { get; set; } = new List<Oglas>();
}
