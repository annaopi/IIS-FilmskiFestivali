using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("VERZIJA_OGLASA")]
public class VerzijaOglasa
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("verzija_broj")]
    [MaxLength(20)]
    public string VerzijaBroj { get; set; } = null!;

    [Column("fajl_put")]
    [MaxLength(500)]
    public string FajlPut { get; set; } = null!;

    [Column("fajl_naziv")]
    [MaxLength(255)]
    public string FajlNaziv { get; set; } = null!;

    [Column("datum_uploada")]
    public DateTime DatumUploada { get; set; }

    [Column("oglas_id")]
    public int OglasId { get; set; }

    [ForeignKey(nameof(OglasId))]
    public Oglas Oglas { get; set; } = null!;
}
