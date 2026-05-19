using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmskiFestivali.Models;

[Table("FAZA")]
public class Faza
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("naziv")]
    [MaxLength(200)]
    public string Naziv { get; set; } = null!;

    [Column("redosled")]
    public int Redosled { get; set; }

    [Column("odgovorna_uloga")]
    [MaxLength(100)]
    public string OdgovornaUloga { get; set; } = null!;

    [Column("uslovi")]
    public string? Uslovi { get; set; }

    [Column("radni_tok_id")]
    public int RadniTokId { get; set; }

    [ForeignKey(nameof(RadniTokId))]
    public RadniTok RadniTok { get; set; } = null!;

    public ICollection<Instanca> InstanceTrenutneFaze { get; set; } = new List<Instanca>();
    public ICollection<Istorija> Istorije { get; set; } = new List<Istorija>();
}
