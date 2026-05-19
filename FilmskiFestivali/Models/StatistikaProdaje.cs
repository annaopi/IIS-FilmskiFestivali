using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("STATISTIKA_PRODAJE")]
public class StatistikaProdaje
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("broj_prodatih")]
    public int BrojProdatih { get; set; }

    [Column("popunjenost", TypeName = "decimal(5,2)")]
    public decimal Popunjenost { get; set; }

    [Column("projekcija_id")]
    public int ProjekcijaId { get; set; }

    [ForeignKey(nameof(ProjekcijaId))]
    public Projekcija Projekcija { get; set; } = null!;
}
