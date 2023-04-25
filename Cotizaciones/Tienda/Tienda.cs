using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones
{
    public class Tienda
    {
        string direccion;
        string nombre;
        List<Prenda> tiendaList;
        public Tienda(string direcc,string nombre)
        {
            tiendaList= new List<Prenda>();
            direccion= direcc;
            this.nombre= nombre;
        }
       public void CargarStock(Prenda prenda)
        {
            tiendaList.Add(prenda);
        }
    }
}
