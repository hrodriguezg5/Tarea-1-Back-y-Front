using System.ComponentModel.DataAnnotations;

namespace ApiTiposSangre.Models;

public class tipo_sangre
    {
        [Key]
        public Int32 id_tipo_sangre { get; set; }

        public string? sangre { get; set; }
    }