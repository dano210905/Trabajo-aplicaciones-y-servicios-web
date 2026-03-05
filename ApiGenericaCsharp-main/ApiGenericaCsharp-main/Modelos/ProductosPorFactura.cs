[Table("productosporfactura")]
public class ProductoPorFactura
{
    [Column("fknumfactura")]
    public int FkNumFactura { get; set; }

    public Factura Factura { get; set; }

    [Column("fkcodproducto")]
    public string FkCodProducto { get; set; }

    public Producto Producto { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "numeric(14,2)")]
    public decimal Subtotal { get; set; }
}