using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("REZERVACIJA_RESURSA")]
public class RezervacijaResursa
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("pocetak")]
    public DateTime Pocetak { get; set; }

    [Column("kraj")]
    public DateTime Kraj { get; set; }

    [Column("status")]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    [Column("resurs_id")]
    public int ResursId { get; set; }

    [Column("dogadjaj_id")]
    public int DogadjajId { get; set; }

    [ForeignKey(nameof(ResursId))]
    public Resurs Resurs { get; set; } = null!;

    [ForeignKey(nameof(DogadjajId))]
    public Dogadjaj Dogadjaj { get; set; } = null!;
}
