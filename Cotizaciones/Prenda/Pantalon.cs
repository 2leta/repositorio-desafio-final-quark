using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones
{
    internal class Pantalon:Prenda
    {
        public enum tipoPantalon { comun,chupin};
       public tipoPantalon TPantalon;
        public Pantalon(tipoPantalon tipoDePantalon,calidad Calidad, int stock,int PrecioUnitario) 
        {
            Tprenda = TipoPrenda.Pantalon;
            TPantalon= tipoDePantalon;
            this.stock = stock;
            precioUnitario= PrecioUnitario;
            
        }
    }
}
