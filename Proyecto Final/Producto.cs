using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Producto
    {
        #region Propiedades

        private int id = 0;
        private string descripcion = string.Empty;
        private float costo = 0f;
        private float precioVenta = 0f;
        private int stock = 0;
        private int idUsuario = 0;

        #endregion

        #region Setters and Getters

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float Costo { get; set; }
        public float PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
        
        #endregion

        #region Constructores
        
        public Producto(int id, string descripcion, float costo, float precioVenta, int stock, int idUsuario) {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }
        
        #endregion
    }
}
