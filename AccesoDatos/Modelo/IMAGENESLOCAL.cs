//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class IMAGENESLOCAL
    {
        public int IDIMAGENLOCAL { get; set; }
        public Nullable<int> IDLOCAL { get; set; }
        public byte[] IMAGENLOCAL { get; set; }
    
        public virtual LOCAL LOCAL { get; set; }
    }
}