//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatalogoCiisa2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int producto_ID { get; set; }
        public string nombre { get; set; }
        public decimal precioUnit { get; set; }
        public int stock { get; set; }
        public byte activo { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public System.DateTime fechaMod { get; set; }
    }
}
