using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApiEstudiantes.Models;

public class Estudiantes
{
    [Key]
    public Int32 id_estudiante { get; set; }
    public string? carne { get; set; }
    public string? nombres { get; set; }
    public string? apellidos { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public string? correo_electronico { get; set; }
    public Int32 id_tipo_sangre { get; set; }
    public DateTime? fecha_nacimiento { get; set; }

    public Tipo_Sangre? Tipo_Sangre { get; set; }
}


public class Tipo_Sangre
{
    [Key]
    public Int32 id_tipo_sangre { get; set; }
    public string? sangre { get; set; }

    [JsonIgnore]
    public ICollection<Estudiantes>? Estudiantes { get; set; }
}