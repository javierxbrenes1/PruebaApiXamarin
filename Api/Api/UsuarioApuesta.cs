//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsuarioApuesta
    {
        public string idUsuario { get; set; }
        public string idApuesta { get; set; }
        public Nullable<int> resultado1 { get; set; }
        public Nullable<int> resultado2 { get; set; }
        public Nullable<short> Ganador { get; set; }
    
        public virtual Apuesta Apuesta { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
