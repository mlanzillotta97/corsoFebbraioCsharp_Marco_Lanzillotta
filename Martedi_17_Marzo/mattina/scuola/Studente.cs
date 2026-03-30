using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

public class Studente

{

    [Key]

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int Id { get; set; }


    [Required] // Data annotation che applicano le regole del DB

    [MaxLength(50)]

    [Column("Nome")]

    public string Nome { get; set; } = default!;


    [Required]

    [MaxLength(50)]

    [Column("Cognome")]

    public string Cognome { get; set; } = default!;

}