using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_SIM_Pelu_DesdeCero
{
    class Aprendiz
    {

        public string Estado { get; set; }
        public double tiempoAtencion { get; set; }
        public double finAtencion { get; set; }
        public Queue<Cliente> cola;
        public Queue<Cliente> Cola { get => cola; set => cola = value; }
        public Cliente clienteAtendiendose;//Cliente actual que esta siendo atendido


        public Aprendiz()
        {
            Estado = "L";
            Cola = new Queue<Cliente>();
            clienteAtendiendose = null;
        }

    }
}
