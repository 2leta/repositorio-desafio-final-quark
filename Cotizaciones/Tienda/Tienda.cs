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
        public int ChequearStock(Prenda prenda) 
        {
            Prenda retorno=null;
            foreach(Prenda a in tiendaList)
            {
                if (a.Tprenda == prenda.Tprenda)
                {
                    if((Camisa)prenda == prenda) retorno= ChequearCamisas((Camisa)prenda);
                    else if ((Pantalon)prenda == prenda) retorno=ChequearPantalon((Pantalon)prenda);
                }
                
            }

            return retorno.Stock(); 
        }
        public Camisa ChequearCamisas(Camisa camisa)
        {
            Camisa cam=null;
            foreach(Camisa var in tiendaList)
            {
                if (camisa.TCamisa == var.TCamisa && camisa.TCuello == var.TCuello) cam = var ;
                else return null;
            }
            return cam;
           
        }
        public Pantalon ChequearPantalon(Pantalon pantalon)
        {
           Pantalon pant = null;
            foreach (Pantalon var in tiendaList)
            {
                if (pantalon.TPantalon== var.TPantalon) pant = var;
                else return null;
            }
            return pant;

        }
    }
}
