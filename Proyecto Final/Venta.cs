using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Venta
    {
        #region Atributos

        private int _id;
        private string _comentarios;
        private int _idUsuario;

        #endregion

        #region Propiedades

        public int id { get; set; }
        public string comentarios { get; set;}
        public int idUsuario { get; set; }

        #endregion

        #region Constructores
        
        public Venta(int id, string comentarios, int idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }
        
        #endregion

    }
}
