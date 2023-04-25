using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones
{
    internal class Camisa : Prenda
    {
        public enum TipoCamisas { mangaCorta, mangaLarga };
        public enum TipoCuello {cuelloMao,cuelloComun};
       public TipoCamisas TCamisa;
       public TipoCuello TCuello;
        
       
       public Camisa(TipoCamisas tipoDeCamisa,TipoCuello tipoDeCuello, calidad TipoCalidad,int Stock,float PrecioUnitario)
        {
            TCamisa = tipoDeCamisa;
            TCuello= tipoDeCuello;
            calidadCamisa= TipoCalidad;
            stock= Stock;
            precioUnitario= PrecioUnitario;
            Tprenda = TipoPrenda.Camisa;

        }
    }
}
