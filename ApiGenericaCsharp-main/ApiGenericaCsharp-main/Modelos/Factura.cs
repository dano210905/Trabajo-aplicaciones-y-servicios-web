[Table("factura")]
public class Factura
{
    [Key]
    public int Numero { get; set; }

    public DateTime Fecha { get; set; }

    [Column(TypeName = "numeric(14,2)")]
    public decimal Total { get; set; }

    [Column("fkidcliente")]
    public int FkIdCliente { get; set; }

    public Cliente Cliente { get; set; }

    [Column("fkidvendedor")]
    public int FkIdVendedor { get; set; }

    public Vendedor Vendedor { get; set; }

    public ICollection<ProductoPorFactura> Productos { get; set; }
}