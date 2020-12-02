using System;
using System.Collections.Generic;

namespace SocialMedia.core.Entities
{
    public partial class Like
    {
        public int IdLike { get; set; }
        public int IdPublicacion { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
    }
}
