using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("SALA")]
public class Sala
{
    [Key]
    [Column("sala_id")]
    public int SalaId { get; set; }

    [Column("naziv")]
    [MaxLength(100)]
    public string Naziv { get; set; } = null!;

    [Column("kapacitet")]
    public int Kapacitet { get; set; }

    [Column("lokacija")]
    [MaxLength(200)]
    public string Lokacija { get; set; } = null!;

    public ICollection<Dogadjaj> Dogadjaji { get; set; } = new List<Dogadjaj>();
    public ICollection<Projekcija> Projekcije { get; set; } = new List<Projekcija>();
    public ICollection<Sediste> Sedista { get; set; } = new List<Sediste>();
    public ICollection<Resurs> Resursi { get; set; } = new List<Resurs>();
}
