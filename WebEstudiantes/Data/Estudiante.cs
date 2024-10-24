namespace WebEstudiantes.Data;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class Estudiante
    {
        [JsonPropertyName("id_estudiante")]
        public Int32 Id_estudiantes { get; set; }

        [JsonPropertyName("carne")]
        public string? Carne { get; set; }

        [JsonPropertyName("nombres")]
        public string? Nombres { get; set; }

        [JsonPropertyName("apellidos")]
        public string? Apellidos { get; set; }

        [JsonPropertyName("direccion")]
        public string? Direccion { get; set; }

        [JsonPropertyName("telefono")]
        public string? Telefono { get; set; }

        [JsonPropertyName("correo_electronico")]
        public string? Correo_Electronico { get; set; }

        [JsonPropertyName("id_tipo_sangre")]
        public Int32 Id_tipo { get; set; }

        [JsonPropertyName("fecha_nacimiento")]
        public DateTime? Fecha_Nacimiento { get; set; }

        [JsonPropertyName("tipo_sangre")]
        public Tipo_sangre? Tipo_Sangre { get; set; }
    }

public class Tipo_sangre
    {
        [JsonPropertyName("id_tipo_sangre")]
        public Int32 Id_tiposangre { get; set; }

        [JsonPropertyName("sangre")]
        public string? Sangre { get; set; }
    }