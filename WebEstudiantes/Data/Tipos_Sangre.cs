namespace WebEstudiantes.Data;
using System.Text.Json.Serialization;

public class Tipos_sangre
    {
        [JsonPropertyName("id_tipo_sangre")]
        public Int32 Id_tiposangre { get; set; }

        [JsonPropertyName("sangre")]
        public string? Sangre { get; set; }
    }