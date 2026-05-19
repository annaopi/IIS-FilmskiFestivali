using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("PROJEKCIJA")]
public class Projekcija
{
    [Key]
    [Column("projekcija_id")]
    public int ProjekcijaId { get; set; }

    [Column("pocetak")]
    public DateTime Pocetak { get; set; }

    [Column("kraj")]
    public DateTime Kraj { get; set; }

    [Column("film_id")]
    public int FilmId { get; set; }

    [Column("dogadjaj_id")]
    public int DogadjajId { get; set; }

    [Column("sala_id")]
    public int SalaId { get; set; }

    [ForeignKey(nameof(FilmId))]
    public Film Film { get; set; } = null!;

    [ForeignKey(nameof(DogadjajId))]
    public Dogadjaj Dogadjaj { get; set; } = null!;

    [ForeignKey(nameof(SalaId))]
    public Sala Sala { get; set; } = null!;

    public ICollection<Rezervacija> Rezervacije { get; set; } = new List<Rezervacija>();
    public ICollection<Karta> Karte { get; set; } = new List<Karta>();
    public ICollection<StatistikaProdaje> StatistikeProdaje { get; set; } = new List<StatistikaProdaje>();
}
