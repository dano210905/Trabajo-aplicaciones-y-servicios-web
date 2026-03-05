[Table("rutarol")]
public class RutaRol
{
    [Column("ruta")]
    public string Ruta { get; set; }

    public Ruta RutaNav { get; set; }

    [Column("rol")]
    public string Rol { get; set; }

    public Rol RolNav { get; set; }
}