using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("PROBLEM")]
public class Problem
{
    [Key]
    [Column("problem_id")]
    public int ProblemId { get; set; }

    [Column("opis")]
    [MaxLength(2000)]
    public string Opis { get; set; } = null!;

    [Column("prioritet")]
    [MaxLength(50)]
    public string Prioritet { get; set; } = null!;

    [Column("status")]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    [Column("datum_prijave")]
    public DateTime DatumPrijave { get; set; }

    [Column("korisnik_id")]
    public int KorisnikId { get; set; }

    [Column("dogadjaj_id")]
    public int DogadjajId { get; set; }

    [ForeignKey(nameof(KorisnikId))]
    public Korisnik Korisnik { get; set; } = null!;

    [ForeignKey(nameof(DogadjajId))]
    public Dogadjaj Dogadjaj { get; set; } = null!;
}
