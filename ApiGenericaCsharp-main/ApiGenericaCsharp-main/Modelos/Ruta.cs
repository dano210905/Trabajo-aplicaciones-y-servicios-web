[Table("ruta")]
public class Ruta
{
    [Key]
    [Column("ruta")]
    [StringLength(100)]
    public string RutaSistema { get; set; }

    [Required]
    [Column("descripcion")]
    [StringLength(255)]
    public string Descripcion { get; set; }

    public ICollection<RutaRol> RutaRoles { get; set; }
}