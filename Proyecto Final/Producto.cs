using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Producto
    {

        #region Atributos
        
        private int _id;
        private string _descripcion;
        private float _costo;
        private float _precioVenta;
        private int _stock;
        private int _idUsuario;

        #endregion

        #region Propiedades
        
        public int id { get; set; }
        public string descripcion { get; set; }
        public float costo { get; set; }
        public float precioVenta { get; set; }
        public int stock { get; set; }
        public int idUsuario { get; set; }
        
        #endregion

        #region Constructores
        
        public Producto(int id, string descripcion, float costo, float precioVenta, int stock, int idUsuario) {
            this.id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }
        
        #endregion
    }
}
