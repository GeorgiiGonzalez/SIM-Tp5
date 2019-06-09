using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_SIM_Pelu_DesdeCero
{
    class Peluqueria
    {
        //VARIABLES//
        private Random RND = new Random();  //EL MOMENTO DE TIEMPO EN EL QUE OCURRE CADA EVENTO//
        private double reloj; //declaramos el reloj 
        private double aleatorioLlegadaCliente; //es el rnd que se muestra que calcula el tiempo entre llegadas
        private double llegadaCliente; //tiempo en que llega un cliente
        private double proximaLlegadaCliente; //proxima llegada del cliente - Metodo calcular tiempo proxima llegada(parametro reloj actual + cant de minutos para prox llegada de pasajero)
        private double aleatorioRecorrido;
        private int idRecorrido;
        private string eventoSiguiente;
        private int contCantClientesAtendidos;
        public bool estaPurgando { get; set; }

        //GET Y SET//
        public double Reloj { get { return reloj; } set { reloj = value; } }
        public double AleatorioLlegadaCliente { get { return aleatorioLlegadaCliente; } set { aleatorioLlegadaCliente = value; } }
        public double LlegadaCliente { get { return llegadaCliente; } set { llegadaCliente = value; } }
        public double ProximaLlegadaCliente { get { return proximaLlegadaCliente; } set { proximaLlegadaCliente = value; } }
        public double AleatorioRecorrido { get { return aleatorioRecorrido; } set { aleatorioRecorrido = value; } }
        public int IDRecorrido { get { return idRecorrido; } set { idRecorrido = value; } }
        public string EventoSiguiente { get { return eventoSiguiente; } set { eventoSiguiente = value; } }
        public int CantClientesAtendidos { get { return contCantClientesAtendidos; } set { contCantClientesAtendidos = value; } }



        //METODOS MATEMATICOS//


        public double generarUniforme_aprendiz(double a, double b,double RND)
        {
            double c = b - a;
            return Math.Round(a + (RND * c), 4);
        }

        public double generarUniforme_veteranoA(double a, double b, double RND)
        {
             double c = b - a;
            return Math.Round(a + (RND * c), 4);
        }

        public double generarUniforme_veteranoB(double a, double b, double RND)
        {
            double c = b - a;
            return Math.Round(a + (RND * c), 4);
        }
        // Para generar la llegada del cliente 
        public double generarUniforme_Cliente(double a, double b, double rnd)

        {
            
            double c = b - a;
            return Math.Round(a + (rnd * c), 4);
        }


        //METODOS PARA LOS RECORRIDOS//
        public int generarRecorrido(double rnd, double ap, double vetA) //para ver en donde cae el aleatorio
        {
            int idRecorrido = 0;
            if (rnd >= 0.00 && rnd < ap) { idRecorrido = 1; } //Aprendiz
            else if (rnd >= ap && rnd < vetA) { idRecorrido = 2; } //Vererano A
            else { idRecorrido = 3; } //Veterano B
            return idRecorrido;

        }

        public string generarCadenaRecorrido(int r)
        {
            string cadenaRecorrido = "";
            if (r == 1) { cadenaRecorrido = "Aprendiz"; }
            else if (r == 2) { cadenaRecorrido = "Veterano A"; }
            else { cadenaRecorrido = "Veterano B"; }
            return cadenaRecorrido;
        }


        public double generarAleatorio()
        {
            Random RND = new Random();
            double rnd = Math.Round(RND.NextDouble(), 4);
            return rnd;

        }
    }
}
