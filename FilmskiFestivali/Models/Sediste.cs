using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("SEDISTE")]
public class Sediste
{
    [Key]
    [Column("sediste_id")]
    public int SedisteId { get; set; }

    [Column("red")]
    [MaxLength(10)]
    public string Red { get; set; } = null!;

    [Column("broj")]
    public int Broj { get; set; }

    [Column("sala_id")]
    public int SalaId { get; set; }

    [Column("zona_id")]
    public int ZonaId { get; set; }

    [ForeignKey(nameof(SalaId))]
    public Sala Sala { get; set; } = null!;

    [ForeignKey(nameof(ZonaId))]
    public Zona Zona { get; set; } = null!;

    public ICollection<Karta> Karte { get; set; } = new List<Karta>();
}
