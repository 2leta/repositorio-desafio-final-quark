using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones
{
   public abstract class Prenda
    {
      protected float precioUnitario;
      public enum calidad { standard,premium};
      public calidad Calidad;
      protected int stock;
        public enum TipoPrenda {Camisa,Pantalon}
        public TipoPrenda Tprenda;
        public int Stock() { return stock; }
        public float PrecioUnidad() { return precioUnitario; }
    }
}
    
