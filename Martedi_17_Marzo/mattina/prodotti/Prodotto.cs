using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Prodotto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("Nome")]
    public string Nome { get; set; } = default!;

    [Required]
    [Column("Prezzo")]
    public decimal Prezzo { get; set; }
}