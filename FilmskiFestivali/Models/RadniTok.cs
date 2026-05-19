using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("RADNI_TOK")]
public class RadniTok
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("naziv")]
    [MaxLength(200)]
    public string Naziv { get; set; } = null!;

    [Column("opis")]
    public string? Opis { get; set; }

    [Column("kreator_id")]
    public int KreatorId { get; set; }

    [ForeignKey(nameof(KreatorId))]
    public Korisnik Kreator { get; set; } = null!;

    public ICollection<Faza> Faze { get; set; } = new List<Faza>();
    public ICollection<Instanca> Instance { get; set; } = new List<Instanca>();
}
