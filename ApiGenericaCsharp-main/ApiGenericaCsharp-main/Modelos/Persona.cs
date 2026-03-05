using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("persona")]
public class Persona
{
    [Key]
    [Column("codigo")]
    [StringLength(20)]
    public string Codigo { get; set; }

    [Required]
    [Column("nombre")]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Required]
    [Column("email")]
    [StringLength(100)]
    public string Email { get; set; }

    [Required]
    [Column("telefono")]
    [StringLength(20)]
    public string Telefono { get; set; }

    public Cliente Cliente { get; set; }

    public Vendedor Vendedor { get; set; }
}