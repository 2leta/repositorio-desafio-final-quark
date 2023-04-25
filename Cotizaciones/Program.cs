using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotizaciones
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread] 
     
        static void Main()
        {
            Camisa camisa = new Camisa(Camisa.TipoCamisas.mangaCorta,Camisa.TipoCuello.cuelloMao,Camisa.calidad.standard,100,2023);
            List<Prenda> stock;
            stock = new List<Prenda>();
            stock.Add(camisa);
             
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
