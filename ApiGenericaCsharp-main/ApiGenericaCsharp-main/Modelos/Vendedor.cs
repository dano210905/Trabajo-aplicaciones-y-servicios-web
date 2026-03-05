[Table("vendedor")]
public class Vendedor
{
    [Key]
    public int Id { get; set; }

    [Column("carnet")]
    public int Carnet { get; set; }

    [Required]
    [Column("direccion")]
    [StringLength(100)]
    public string Direccion { get; set; }

    [ForeignKey("Persona")]
    [Column("fkcodpersona")]
    public string FkCodPersona { get; set; }

    public Persona Persona { get; set; }

    public ICollection<Factura> Facturas { get; set; }
}