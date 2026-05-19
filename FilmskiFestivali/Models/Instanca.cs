using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("INSTANCA")]
public class Instanca
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("datum_pokretanja")]
    public DateTime DatumPokretanja { get; set; }

    [Column("poslato_na_odobrenje")]
    public DateTime? PoslatoNaOdobrenje { get; set; }

    [Column("oglas_id")]
    public int OglasId { get; set; }

    [Column("radni_tok_id")]
    public int RadniTokId { get; set; }

    [Column("trenutna_faza_id")]
    public int TrenutnaFazaId { get; set; }

    [ForeignKey(nameof(OglasId))]
    public Oglas Oglas { get; set; } = null!;

    [ForeignKey(nameof(RadniTokId))]
    public RadniTok RadniTok { get; set; } = null!;

    [ForeignKey(nameof(TrenutnaFazaId))]
    public Faza TrenutnaFaza { get; set; } = null!;

    public ICollection<Istorija> Istorije { get; set; } = new List<Istorija>();
}
