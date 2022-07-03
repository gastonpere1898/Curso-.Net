using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13_EJ_obligatorio.Modelo
{
    public class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            return  BilletesDe10*10 +BilletesDe20*20 + BilletesDe50*50 + BilletesDe100*100 + BilletesDe200*200 + BilletesDe500*500 + BilletesDe1000*1000;

        }
        public Billetera Combinar(Billetera billetera)
        {
            var billeteraNueva = new Billetera
            {
                BilletesDe10 = billetera.BilletesDe10 + BilletesDe10,
                BilletesDe20 = billetera.BilletesDe20 + BilletesDe20,
                BilletesDe50 = billetera.BilletesDe50 + BilletesDe50,
                BilletesDe100 = billetera.BilletesDe100 + BilletesDe100,
                BilletesDe200= billetera.BilletesDe200 + BilletesDe200,
                BilletesDe500 = billetera.BilletesDe500 + BilletesDe500,
                BilletesDe1000 = billetera.BilletesDe1000 + BilletesDe1000
            };

            billetera.BilletesDe10 = 0;
            billetera.BilletesDe20 = 0;
            billetera.BilletesDe50 = 0;
            billetera.BilletesDe100 = 0;
            billetera.BilletesDe200 = 0;
            billetera.BilletesDe500 = 0;
            billetera.BilletesDe1000 = 0;
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe200 = 0;
            BilletesDe100 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
            

            return billeteraNueva;
        }

    }
}
