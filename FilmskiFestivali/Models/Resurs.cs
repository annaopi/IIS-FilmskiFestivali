using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("RESURS")]
public class Resurs
{
    [Key]
    [Column("resurs_id")]
    public int ResursId { get; set; }

    [Column("naziv")]
    [MaxLength(200)]
    public string Naziv { get; set; } = null!;

    [Column("tip")]
    [MaxLength(50)]
    public string Tip { get; set; } = null!;

    [Column("status")]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    [Column("opis")]
    [MaxLength(1000)]
    public string? Opis { get; set; }

    [Column("sala_id")]
    public int SalaId { get; set; }

    [ForeignKey(nameof(SalaId))]
    public Sala Sala { get; set; } = null!;

    public ICollection<RezervacijaResursa> RezervacijeResursa { get; set; } = new List<RezervacijaResursa>();
}
