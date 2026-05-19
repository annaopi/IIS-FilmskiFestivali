using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("PRAVILO_CENE")]
public class PraviloCene
{
    [Key]
    [Column("pravilo_id")]
    public int PraviloId { get; set; }

    [Column("min_popunjenost")]
    public int MinPopunjenost { get; set; }

    [Column("max_popunjenost")]
    public int MaxPopunjenost { get; set; }

    [Column("promena_procenta", TypeName = "decimal(5,2)")]
    public decimal PromenaProcenta { get; set; }

    [Column("zona_id")]
    public int ZonaId { get; set; }

    [ForeignKey(nameof(ZonaId))]
    public Zona Zona { get; set; } = null!;
}
