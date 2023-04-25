
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones
{
    internal class Cotizacion
    { int NroID;
        string fechaHora;
        int unidades;
        Prenda prendaCotizada;
        Camisa PrendaCotCamisa;
        int CodigoVendedor;
        public Cotizacion(Prenda prenda,Vendedor vendedor, int Unidades) 
        {
            CodigoVendedor = vendedor.Codigo;
            if (vendedor.Historial.Count == 0) { NroID = 0; } else { NroID = vendedor.Historial.Count; }
            prendaCotizada = prenda;
           fechaHora= DateTime.Now.ToString();

        }
        public float Cotizar() {
            float precioFinal;
         if(prendaCotizada.Tprenda == Prenda.TipoPrenda.Camisa)
            {precioFinal= CotizarCamisa((Camisa)prendaCotizada);} 
         else 
            { precioFinal = CotizarPantalon((Pantalon)prendaCotizada); }
            if (prendaCotizada.Calidad == Prenda.calidad.premium) { return (precioFinal * 0.3f) + precioFinal; }
            else { return precioFinal; }
            
        }
        private float CotizarCamisa(Camisa camisa) 
        {
            float precio=prendaCotizada.PrecioUnidad();
            if (camisa.TCamisa == Camisa.TipoCamisas.mangaCorta) precio = precio-(precio * 0.10f)  ;
            if (camisa.TCuello == Camisa.TipoCuello.cuelloMao) precio = (precio * 0.3f) + precio;
            return precio;
        }
        private float CotizarPantalon(Pantalon pantalon)
        {
            float precio = prendaCotizada.PrecioUnidad();
            if (pantalon.TPantalon == Pantalon.tipoPantalon.chupin) precio = precio - (precio * 0.12f);
            return precio;
        }
     
    }
}
