[Table("rol")]
public class Rol
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("nombre")]
    [StringLength(100)]
    public string Nombre { get; set; }

    public ICollection<RolUsuario> RolUsuarios { get; set; }

    public ICollection<RutaRol> RutaRoles { get; set; }
}