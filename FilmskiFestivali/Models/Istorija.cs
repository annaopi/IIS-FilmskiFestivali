using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("ISTORIJA")]
public class Istorija
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("vreme_pocetka")]
    public DateTime VremePocetka { get; set; }

    [Column("vreme_zavrsetka")]
    public DateTime? VremeZavrsetka { get; set; }

    [Column("status")]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    [Column("komentar")]
    public string? Komentar { get; set; }

    [Column("instanca_id")]
    public int InstancaId { get; set; }

    [Column("faza_id")]
    public int FazaId { get; set; }

    [ForeignKey(nameof(InstancaId))]
    public Instanca Instanca { get; set; } = null!;

    [ForeignKey(nameof(FazaId))]
    public Faza Faza { get; set; } = null!;
}
