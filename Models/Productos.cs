//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventarioApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        public Productos()
        {
            this.Suc_producto = new HashSet<Suc_producto>();
        }
    
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string codbarra { get; set; }
        public decimal precio { get; set; }
    
        public virtual ICollection<Suc_producto> Suc_producto { get; set; }
    }
}
