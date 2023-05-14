using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones
{
    internal class Controlador
    {
        Tienda tienda1;
        public void Inicializar()
        {
            Camisa camisa = new Camisa(Camisa.TipoCamisas.mangaCorta, Camisa.TipoCuello.cuelloMao, Camisa.calidad.standard, 100, 2023);
            Camisa camisa2 = new Camisa(Camisa.TipoCamisas.mangaLarga, Camisa.TipoCuello.cuelloMao, Camisa.calidad.standard, 100, 2023);

        }
    }
}
