using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp5
{
    public class Servidor
    {
        public string estado = "Libre";
        public Cliente cliente;
        public double rnd_servidor;
        public DateTime tiempo_de_atencionn; // tiempo que genera con el random, es lo que va a ademorar en cortar el pelo
        public DateTime fin_atencion_servidor = DateTime.Parse("23:59:59");
        public List<Cliente> cola = new List<Cliente>();
        public float acum_ganancia;
        public int cant_clientes;
        
    }
}
