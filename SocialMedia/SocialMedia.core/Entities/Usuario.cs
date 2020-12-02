using System;
using System.Collections.Generic;

namespace SocialMedia.core.Entities
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
    }
}
