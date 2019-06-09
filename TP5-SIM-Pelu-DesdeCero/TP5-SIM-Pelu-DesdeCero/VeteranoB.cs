using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_SIM_Pelu_DesdeCero
{
    class VeteranoB
    {
        public string Estado { get; set; }
        public Queue<Cliente> cola;
        public Queue<Cliente> Cola { get => cola; set => cola = value; }
        public double tiempoAtencion { get; set; }
        public double finAtencion { get; set; }
        public Cliente clienteAtendiendose;//Cliente actual que esta siendo atendido


        public VeteranoB()
        {
            Estado = "L";
            cola = new Queue<Cliente>();
            clienteAtendiendose = null;
        }
    }
}
