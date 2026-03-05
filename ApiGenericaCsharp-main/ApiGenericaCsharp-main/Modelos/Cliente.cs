[Table("cliente")]
public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Column("credito", TypeName = "numeric(14,2)")]
    public decimal Credito { get; set; }

    [ForeignKey("Persona")]
    [Column("fkcodpersona")]
    public string FkCodPersona { get; set; }

    public Persona Persona { get; set; }

    [ForeignKey("Empresa")]
    [Column("fkcodempresa")]
    public string FkCodEmpresa { get; set; }

    public Empresa Empresa { get; set; }

    public ICollection<Factura> Facturas { get; set; }
}