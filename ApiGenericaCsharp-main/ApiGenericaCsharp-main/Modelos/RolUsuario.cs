[Table("rol_usuario")]
public class RolUsuario
{
    [Column("fkemail")]
    public string FkEmail { get; set; }

    public Usuario Usuario { get; set; }

    [Column("fkidrol")]
    public int FkIdRol { get; set; }

    public Rol Rol { get; set; }
}