using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones
{
    internal class Vendedor
    {
        string nombre;
        string apellido;
        int codigo;
       public List <Cotizacion> Historial;
        public Vendedor(string nombre, string apellido, int codigo) 
        {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Codigo = codigo;
        Historial= new List <Cotizacion>();

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Codigo { get => codigo; set => codigo = value; }

        public void Cotizar(Prenda prenda,Vendedor vend,int unidades)
        {
            Cotizacion cot = new Cotizacion(prenda, vend, unidades);
            cot.Cotizar();
            RegistrarCotizacion(cot);
        }
        public void RegistrarCotizacion(Cotizacion cot)
        {
            Historial.Add(cot);
        }
    }
}
