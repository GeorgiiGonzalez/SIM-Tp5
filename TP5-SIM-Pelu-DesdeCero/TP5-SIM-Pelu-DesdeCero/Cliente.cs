using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_SIM_Pelu_DesdeCero
{
    class Cliente
    {

        public int id { get; set; }
        public string Estado { get; set; }      // SA: siendo atendido - EA: esperando atencion
        public double horaLleg { get; set; }
        public double proxLleg { get; set; }
        public int id_recorrido { get; set; }
        //public int cantArt { get; set; }
        public Queue<string> recorrido;
        public Queue<string> Recorrido { get => recorrido; set => recorrido = value; }

        public Cliente()
        {

            Recorrido = new Queue<string>();
        }
    }
}
