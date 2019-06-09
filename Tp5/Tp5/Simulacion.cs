using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5
{
    public class Simulacion
    {
        //
        public Llegada llegada;
        public Servidor aprendiz;
        public Servidor veteranoA;
        public Servidor veteranoB;
        // ver si hay q poner una cola de clientes 
        public List<Cliente> colaAprediz;
        public List<Cliente> colaVeteranoA;
        public List<Cliente> colaVeteranoB;


        public int cantidad_clientes_sistema;
        public DateTime reloj;
        public string evento;
        public Cliente cliente;
        public List<Cliente> colaEsperaPorCierre;   
        // ver si hay  poner una cola por cierre del local 

        public int contadorClientes;
        public int cantDias;
        public List<int> cantClientesXDia;

        //creamos los contadores 
        public int contadorCliAtendidosAprendiz;
        public int contadorCliAtendidosVeteranoA;
        public int contadorCliAtendidosVeteranoB;

        //Acumuladores de Ganancia 
        public int acuGananciaAprendiz;
        public int acuGananciaVereranoA;
        public int acuGananciaVeteranoB;

        public int idUltimoCliente;
        public Random rnd;

        private int diasASimular;


        public void setDiasASimular(int dias)
        {
            this.diasASimular = dias + 1;

        }


        public void comenzarSimulacion(Form1 pantalla, int desde, int hasta, double pro_aprendiz, double pro_veteranoA, double pro_veteranoB)
        {
            //****** inicializamos las variables 
            // creamos una nueva lista de clientes
            this.cantClientesXDia = new List<int>();
            //contadores
            this.contadorCliAtendidosAprendiz = 0;
            this.contadorCliAtendidosVeteranoA = 0;
            this.contadorCliAtendidosVeteranoB = 0;
            this.contadorClientes = 0;

            //
            this.llegada = new Llegada();
            this.aprendiz = new Servidor();
            this.veteranoA = new Servidor();
            this.veteranoB = new Servidor();

            this.colaAprediz = new List<Cliente>();
            this.colaVeteranoA = new List<Cliente>();
            this.colaVeteranoB = new List<Cliente>();

            this.reloj = new DateTime();
            this.reloj = DateTime.Parse("00:00:00");
            this.evento = "Inicio";

            this.colaEsperaPorCierre = new List<Cliente>();
            this.idUltimoCliente = 1;
            this.cantDias = 1;

            this.llegada.ProximaLlegada = DateTime.Parse("08:00:00");
            this.rnd = new Random();


            //COMIENZA LA SIMULACION 

            while (this.cantDias < this.diasASimular)
            {
                generarEvento();
                if (this.evento == "Llegada")
                {
                    eventoLlegada( pro_aprendiz,  pro_veteranoA,  pro_veteranoB);
                }
                if (this.evento == "Fin Atencion Aprendiz")
                {
                    eventoFinAtencionAprendiz();
                }
                if (this.evento == "Fin Atencion Veterano A")
                {
                    eventoFinAtencionVeteranoA();
                }
                if (this.evento == "Fin Atencion Veterano B")
                {
                    eventoFinAtencionVeteranoB();
                }

                if (this.cantDias >= desde && this.cantDias <= hasta)
                {
                    pantalla.ponerFila(this);
                }
            }
            //ver que hace finalizarCamion()

        }

        private void generarNuevaLlegada()
        {
            var a = 0.0013888888;//equivalente en dias a 2 minutos
            var b = 0.0083333333;//equivalente en dias a 12 minutos
            this.llegada.rnd_llegada = rnd.NextDouble();
            var tiempoEntreLlegada = a + this.llegada.rnd_llegada * (b - a);
            this.llegada.TiempoEntreLlegada = new DateTime().AddDays(tiempoEntreLlegada);
            this.llegada.ProximaLlegada = new DateTime(this.reloj.Ticks + this.llegada.TiempoEntreLlegada.Ticks);
            if (this.llegada.ProximaLlegada.Hour >= 16)
            {
                //this.llegada.ProximaLlegada = this.llegada.ProximaLlegada.AddDays(0.75);//0.75 = 18HS
               
            }
                        


        }

        

        //evento de llegada de un cliente
        private void eventoLlegada(double pro_aprendiz, double pro_veteranoA, double pro_veteranoB)
            {
                if (this.reloj.Hour < 16 && this.reloj.Hour >= 8)
                {
                    generarNuevaLlegada();

                    var cliente = new Cliente();
                    cliente.id_ciente = this.idUltimoCliente;
                    cliente.horaInicio = this.reloj;
                    this.cliente = cliente;

                //hay que hacerlo para los 3 peluqueros, eso me falta...
                Random RND = new Random();
                double RND_prob = Math.Round(RND.NextDouble(), 4);
                if (Convert.ToDouble(RND_prob) < pro_veteranoA)
                {
                    if (Convert.ToDouble(RND_prob) < pro_aprendiz)

                    {
                        // APRENDIZ
                        if (this.aprendiz.estado == "Ocupado") //pregunto si el aprendiz esta ocupado
                        {
                            //si esta ocupado
                            this.aprendiz.cola.Add(cliente); //pongo un cliente en cola de aprendiz

                        }
                        else

                        {

                            //si el aprendiz está libre
                            this.aprendiz.estado = "Ocupado"; //pongo al aprendiz como ocupado
                            this.aprendiz.cliente = cliente;
                            //pongo a trabajar al aprendiz
                            ponerAprendizAAtender();
                        }
                        this.idUltimoCliente++;

                    }
                    else
                    {   // Veterano A
                        if (this.veteranoA.estado == "Ocupado") //pregunto si el aprendiz esta ocupado
                        {
                            //si esta ocupado
                            this.veteranoA.cola.Add(cliente); //pongo un cliente en cola de aprendiz

                        }
                        else

                        {

                            //si el aprendiz está libre
                            this.veteranoA.estado = "Ocupado"; //pongo al aprendiz como ocupado
                            this.veteranoA.cliente = cliente;
                            //pongo a trabajar al aprendiz
                            ponerVeteranoAAAtender();
                        }
                        this.idUltimoCliente++;
                    }
                }
                else
                {
                    //peluquero = "Vererano B";
                    if (this.veteranoB.estado == "Ocupado") //pregunto si el aprendiz esta ocupado
                    {
                        //si esta ocupado
                        this.veteranoB.cola.Add(cliente); //pongo un cliente en cola de aprendiz

                    }
                    else

                    {

                        //si el aprendiz está libre
                        this.veteranoB.estado = "Ocupado"; //pongo al aprendiz como ocupado
                        this.veteranoB.cliente = cliente;
                        //pongo a trabajar al aprendiz
                        ponerVeteranoBAAtender();
                    }
                    this.idUltimoCliente++;

                }



            }
        }
            //método que pone a atender al aprendiz
        private void ponerAprendizAAtender()
            {
                this.aprendiz.rnd_servidor = rnd.NextDouble();
                var a = 0.013888888;//equivalente en dias de 20 minutos
                var b = 0.020833333;//equivalente en dias de 30 minutos
                var duracion_atencion = a + this.aprendiz.rnd_servidor * (b - a);
                this.aprendiz.tiempo_de_atencionn = new DateTime(this.reloj.Ticks + this.aprendiz.tiempo_de_atencionn.Ticks);

                //que pasa si la hora de fin de atencion supera las 16 horas
                if (this.aprendiz.fin_atencion_servidor.Hour >= 16)
                {
                    this.colaEsperaPorCierre = this.aprendiz.cola;
                    this.contadorCliAtendidosAprendiz += this.colaEsperaPorCierre.Count();
                    this.aprendiz.cola = new List<Cliente>();
                }

        }
            //método de fin de atencion del aprendiz
        private void eventoFinAtencionAprendiz()
            {
                this.contadorCliAtendidosAprendiz++;
                this.cliente = this.aprendiz.cliente;
                this.acuGananciaAprendiz += 3;

                if(this.aprendiz.cola.Count > 0)//pregunto si tiene alguien en cola
                {
                    var nuevoCliente = this.aprendiz.cola[0];//de ser asi, atiendo al primero que estaba en la cola
                    this.aprendiz.cola.Remove(nuevoCliente);//y lo saco de la cola
                    this.aprendiz.cliente = nuevoCliente;
                    ponerAprendizAAtender();
                }
                else
                {
                    this.aprendiz.estado = "Libre";//no habia nadie en la cola, lo pongo en estado libre
                    this.aprendiz.rnd_servidor = 0;
                    this.aprendiz.cliente = null;
                    this.aprendiz.tiempo_de_atencionn = DateTime.Parse("00:00:00");
                    this.aprendiz.fin_atencion_servidor = DateTime.Parse("23:59:59").AddDays(100);

                }
            }

            
            //aca ponemos a atender al veteranoA
            private void ponerVeteranoAAAtender()
            {
                this.veteranoA.rnd_servidor = rnd.NextDouble();
                
                var a = 0.007638888;//equivalente en dias de 11 minutos
                var b = 0.009027777;//equivalente en dias de 13 minutos
                var duracion_atencion = a + this.veteranoA.rnd_servidor * (b - a);
                this.veteranoA.tiempo_de_atencionn = new DateTime(this.reloj.Ticks + this.veteranoA.tiempo_de_atencionn.Ticks);

                if (this.veteranoA.fin_atencion_servidor.Hour >= 16)
                {
                    this.colaEsperaPorCierre = this.veteranoA.cola;
                    this.contadorCliAtendidosVeteranoA += this.colaEsperaPorCierre.Count();
                    this.veteranoA.cola = new List<Cliente>();
                }
            }

            //método para el fin de atencion del veteranoA
            private void eventoFinAtencionVeteranoA()
            {
                this.contadorCliAtendidosVeteranoA++;
                this.cliente = this.veteranoA.cliente;

                if (this.veteranoA.cola.Count > 0)//pregunto si tiene alguien en cola
                {
                    var nuevoCliente = this.veteranoA.cola[0];//de ser asi, atiendo al primero que estaba en la cola
                    this.veteranoA.cola.Remove(nuevoCliente);//y lo saco de la cola
                    this.veteranoA.cliente = nuevoCliente;
                    ponerVeteranoAAAtender();
                }
                else
                {   
                    this.veteranoA.estado = "Libre";//no habia nadie en la cola, lo pongo en estado libre
                    this.veteranoA.rnd_servidor = 0;
                    this.veteranoA.cliente = null;
                    this.veteranoA.tiempo_de_atencionn = DateTime.Parse("00:00:00");
                    this.veteranoA.fin_atencion_servidor = DateTime.Parse("23:59:59").AddDays(100);

                }
            }

            //aca ponemos a atender al veteranoB
            private void ponerVeteranoBAAtender()
            {
                this.veteranoB.rnd_servidor = rnd.NextDouble();
                
                var a = 0.008333333333;//equivalente en dias de 12 minutos
                var b = 0.0125; //equivalente en dias de 18 minutos
                var duracion_atencion = a + this.veteranoB.rnd_servidor * (b - a);
                this.veteranoB.tiempo_de_atencionn = new DateTime(this.reloj.Ticks + this.veteranoB.tiempo_de_atencionn.Ticks);

                if (this.veteranoB.fin_atencion_servidor.Hour >= 16)
                {
                    this.colaEsperaPorCierre = this.veteranoB.cola;
                    this.contadorCliAtendidosVeteranoB += this.colaEsperaPorCierre.Count();
                    this.veteranoB.cola = new List<Cliente>();
                }
            }

            //método para el fin de atencion del veteranoB
            private void eventoFinAtencionVeteranoB()
            {
                this.contadorCliAtendidosVeteranoB++;
                this.cliente = this.veteranoB.cliente;

                if (this.veteranoB.cola.Count > 0)//pregunto si tiene alguien en cola
                {
                    var nuevoCliente = this.veteranoB.cola[0];//de ser asi, atiendo al primero que estaba en la cola
                    this.veteranoB.cola.Remove(nuevoCliente);//y lo saco de la cola
                    this.veteranoB.cliente = nuevoCliente;
                    ponerVeteranoBAAtender();
                }
                else
                {
                    this.veteranoB.estado = "Libre";//no habia nadie en la cola, lo pongo en estado libre
                    this.veteranoB.rnd_servidor = 0;
                    this.veteranoB.cliente = null;
                    this.veteranoB.tiempo_de_atencionn = DateTime.Parse("00:00:00");
                    this.veteranoB.fin_atencion_servidor = DateTime.Parse("23:59:59").AddDays(100);

                }
            }
            private void generarEvento()
            {
                //pregunto cual es el primer evento
                var relojViejo = this.reloj;
                DateTime horaMin = new[] { this.llegada.ProximaLlegada, this.aprendiz.fin_atencion_servidor, this.veteranoA.fin_atencion_servidor, this.veteranoB.fin_atencion_servidor }.Min();
                this.reloj = horaMin;

                if(relojViejo.Day != this.reloj.Day)
                {
                    this.cantDias++;
                    this.cantClientesXDia.Add(this.contadorClientes);
                    this.contadorClientes = 0;
                }
                if(this.reloj == this.llegada.ProximaLlegada)
                {
                    this.evento = "Llegada";
                }
                else
                {
                    if(this.reloj == this.aprendiz.fin_atencion_servidor)
                    {
                        this.evento = "Fin Atencion Aprendiz";
                    }
                    else
                    {
                        if(this.reloj == this.veteranoA.fin_atencion_servidor)
                        {
                            this.evento = "Fin Atencion Veterano A";
                        }
                        else
                        {
                            if(this.reloj == this.veteranoB.fin_atencion_servidor)
                            {
                                this.evento = "Fin Atencion Veterano B";
                            }
                        }
                    }
                }
            }

        //// Metodo para elegir  a que peluquero va el cliente

        //public void elegirPeluqero( double pro_aprendiz, double pro_veteranoA, double pro_veteranoB)
        //{
        //    Random RND = new Random();
        //    double RND_prob = Math.Round(RND.NextDouble(), 4);
        //    if (Convert.ToDouble(RND_prob) < pro_veteranoA)
        //    {
        //        if (Convert.ToDouble(RND_prob) < pro_aprendiz)

        //        {
        //            // APRENDIZ
        //            if (this.aprendiz.estado == "Ocupado") //pregunto si el aprendiz esta ocupado
        //            {
        //                //si esta ocupado
        //                this.aprendiz.cola.Add(cliente); //pongo un cliente en cola de aprendiz

        //            }
        //            else

        //            {

        //                //si el aprendiz está libre
        //                this.aprendiz.estado = "Ocupado"; //pongo al aprendiz como ocupado
        //                this.aprendiz.cliente = cliente;
        //                //pongo a trabajar al aprendiz
        //                ponerAprendizAAtender();
        //            }
        //            this.idUltimoCliente++;

        //        }
        //        else
        //        {   // Veterano A
        //            if (this.veteranoA.estado == "Ocupado") //pregunto si el aprendiz esta ocupado
        //            {
        //                //si esta ocupado
        //                this.veteranoA.cola.Add(cliente); //pongo un cliente en cola de aprendiz

        //            }
        //            else

        //            {

        //                //si el aprendiz está libre
        //                this.veteranoA.estado = "Ocupado"; //pongo al aprendiz como ocupado
        //                this.veteranoA.cliente = cliente;
        //                //pongo a trabajar al aprendiz
        //                ponerVeteranoAAAtender();
        //            }
        //            this.idUltimoCliente++;
        //        }
        //    }
        //    else
        //    {
        //        //peluquero = "Vererano B";
        //        if (this.veteranoB.estado == "Ocupado") //pregunto si el aprendiz esta ocupado
        //        {
        //            //si esta ocupado
        //            this.veteranoB.cola.Add(cliente); //pongo un cliente en cola de aprendiz

        //        }
        //        else

        //        {

        //            //si el aprendiz está libre
        //            this.veteranoB.estado = "Ocupado"; //pongo al aprendiz como ocupado
        //            this.veteranoB.cliente = cliente;
        //            //pongo a trabajar al aprendiz
        //            ponerVeteranoBAAtender();
        //        }
        //        this.idUltimoCliente++;

        //    }

        //}


        }
     
        



 }

