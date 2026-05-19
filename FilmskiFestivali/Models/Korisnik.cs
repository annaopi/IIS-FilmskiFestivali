using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIlmskiFestivali.Models;

[Table("KORISNIK")]
public class Korisnik
{
    [Key]
    [Column("korisnik_id")]
    public int KorisnikId { get; set; }

    [Column("korisnicko_ime")]
    [MaxLength(100)]
    public string KorisnickoIme { get; set; } = null!;

    [Column("ime")]
    [MaxLength(100)]
    public string Ime { get; set; } = null!;

    [Column("prezime")]
    [MaxLength(100)]
    public string Prezime { get; set; } = null!;

    [Column("email")]
    [MaxLength(256)]
    public string Email { get; set; } = null!;

    [Column("lozinka_hash")]
    [MaxLength(500)]
    public string LozinkaHash { get; set; } = null!;

    [Column("datum_kreiranja")]
    public DateTime DatumKreiranja { get; set; }

    [Column("status")]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    public ICollection<KorisnikUloga> KorisnikUloge { get; set; } = new List<KorisnikUloga>();
    public ICollection<Dogadjaj> Dogadjaji { get; set; } = new List<Dogadjaj>();
    public ICollection<Rezervacija> Rezervacije { get; set; } = new List<Rezervacija>();
    public ICollection<Transakcija> Transakcije { get; set; } = new List<Transakcija>();
    public ICollection<Oglas> Oglasi { get; set; } = new List<Oglas>();
    public ICollection<RadniTok> RadniTokovi { get; set; } = new List<RadniTok>();
    public ICollection<Problem> Problemi { get; set; } = new List<Problem>();
}
