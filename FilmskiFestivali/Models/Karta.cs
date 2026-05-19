using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("KARTA")]
public class Karta
{
    [Key]
    [Column("karta_id")]
    public int KartaId { get; set; }

    [Column("konacna_cena", TypeName = "decimal(18,2)")]
    public decimal KonacnaCena { get; set; }

    [Column("status")]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    [Column("projekcija_id")]
    public int ProjekcijaId { get; set; }

    [Column("sediste_id")]
    public int SedisteId { get; set; }

    [Column("rezervacija_id")]
    public int RezervacijaId { get; set; }

    [ForeignKey(nameof(ProjekcijaId))]
    public Projekcija Projekcija { get; set; } = null!;

    [ForeignKey(nameof(SedisteId))]
    public Sediste Sediste { get; set; } = null!;

    [ForeignKey(nameof(RezervacijaId))]
    public Rezervacija Rezervacija { get; set; } = null!;
}
