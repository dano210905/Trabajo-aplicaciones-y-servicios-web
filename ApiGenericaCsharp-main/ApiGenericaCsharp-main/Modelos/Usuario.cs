[Table("usuario")]
public class Usuario
{
    [Key]
    [Column("email")]
    [StringLength(100)]
    public string Email { get; set; }

    [Required]
    [Column("contrasena")]
    [StringLength(100)]
    public string Contrasena { get; set; }

    public ICollection<RolUsuario> RolUsuarios { get; set; }
}