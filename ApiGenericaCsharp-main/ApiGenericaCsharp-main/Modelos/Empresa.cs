[Table("empresa")]
public class Empresa
{
    [Key]
    [Column("codigo")]
    [StringLength(10)]
    public string Codigo { get; set; }

    [Required]
    [Column("nombre")]
    [StringLength(200)]
    public string Nombre { get; set; }

    public ICollection<Cliente> Clientes { get; set; }
}