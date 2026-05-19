using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("ZONA")]
public class Zona
{
    [Key]
    [Column("zona_id")]
    public int ZonaId { get; set; }

    [Column("naziv")]
    [MaxLength(100)]
    public string Naziv { get; set; } = null!;

    [Column("osnovna_cena", TypeName = "decimal(18,2)")]
    public decimal OsnovnaCena { get; set; }

    public ICollection<Sediste> Sedista { get; set; } = new List<Sediste>();
    public ICollection<PraviloCene> PravilaCene { get; set; } = new List<PraviloCene>();
}
