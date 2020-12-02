using System;
using System.Collections.Generic;

namespace SocialMedia.core.Entities
{
    public partial class Publicacion
    {
        public int IdPublicacion { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
}
