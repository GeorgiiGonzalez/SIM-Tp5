using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5
{
    public partial class Form1 : Form
    {
        private Simulacion gestor;
        private int diasASimular;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void comenzar(int x, int y, double z, double w, double t)
        {
            this.gestor = new Simulacion();
            this.gestor.setDiasASimular(this.diasASimular);
            this.gestor.comenzarSimulacion(this, x, y,z,w,t);
            
        }

        public void ponerFila(Simulacion gestor)
        {

            //creo una fila
            DataGridViewRow row = (DataGridViewRow) dataGrid.Rows[0].Clone();
            row.Cells[0].Value = gestor.cantDias;
            row.Cells[1].Value = gestor.reloj.ToString("HH:mm:ss");
            row.Cells[2].Value = gestor.evento;
            row.Cells[3].Value = gestor.llegada.ProximaLlegada.ToString("HH:mm:ss");
            //row.Cells[4].Value = gestor.(aca va el peluquero)
            row.Cells[5].Value = gestor.aprendiz.fin_atencion_servidor.TimeOfDay != DateTime.Parse("23:59:59").TimeOfDay ? gestor.aprendiz.fin_atencion_servidor.ToString("HH:mm:ss") : "NC";
            row.Cells[6].Value = gestor.veteranoA.fin_atencion_servidor.TimeOfDay != DateTime.Parse("23:59:59").TimeOfDay ? gestor.veteranoA.fin_atencion_servidor.ToString("HH:mm:ss") : "NC";
            row.Cells[7].Value = gestor.veteranoB.fin_atencion_servidor.TimeOfDay != DateTime.Parse("23:59:59").TimeOfDay ? gestor.veteranoB.fin_atencion_servidor.ToString("HH:mm:ss") : "NC";
            row.Cells[8].Value = gestor.aprendiz.estado;
            row.Cells[9].Value = gestor.aprendiz.cola.Count().ToString();
            row.Cells[10].Value = gestor.aprendiz.cant_clientes.ToString();
            row.Cells[11].Value = gestor.aprendiz.acum_ganancia.ToString();
            row.Cells[12].Value = gestor.veteranoA.estado;
            row.Cells[13].Value = gestor.veteranoA.cola.Count().ToString();
            row.Cells[14].Value = gestor.veteranoA.cant_clientes.ToString();
            row.Cells[15].Value = gestor.veteranoA.acum_ganancia.ToString();
            row.Cells[16].Value = gestor.veteranoB.estado;
            row.Cells[17].Value = gestor.veteranoB.cola.Count().ToString();
            row.Cells[18].Value = gestor.veteranoB.cant_clientes.ToString();
            row.Cells[19].Value = gestor.veteranoB.acum_ganancia.ToString();
            row.Cells[20].Value = gestor.cantidad_clientes_sistema.ToString();

            this.dataGrid.Rows.Add(row);
            this.dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }



        public DataGridView getDatagrid()
        {
            return this.dataGrid;
        }

        public List<int> getCantClientesXDia()
        {
            
            return this.gestor.cantClientesXDia;
        }

        private void bnt_simular_Click(object sender, EventArgs e)

        {
            this.diasASimular = int.Parse(this.txt_dias.Text);


            if (txt_desde.Text == "" || txt_hasta.Text == "") 
            {
                MessageBox.Show("Debe completar todos los campos para la simulacion");
                
            }
            else
            {
                if((Convert.ToInt32(txt_hasta.Text))<(Convert.ToInt32(txt_desde.Text)))
                    {
                    MessageBox.Show("El 'hasta' no puede ser menor al 'desde' ");

                }
                else
                {
                    comenzar((Convert.ToInt32(txt_desde.Text)), (Convert.ToInt32(txt_hasta.Text)),(Convert.ToDouble(txt_probAprendiz.Text)),(Convert.ToDouble(txt_probVetA.Text)),(Convert.ToDouble(txt_probVetB.Text)));
                }                    

                
            }
        }

        private void txt_probVetA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_simular_Click(object sender, EventArgs e)
        {

        }

        //public void elegirPeluquero()
        //{
        //    double pro_aprendiz = Convert.ToDouble(txt_probAprendiz);
        //    double pro_veteranoA = Convert.ToDouble(txt_probVetA);
        //    double pro_veteranoB = Convert.ToDouble(txt_probVetB);
        //    Random RND = new Random();
        //    double RND_prob= Math.Round(RND.NextDouble(), 4);


        //    if (Convert.ToDouble(RND_prob) < pro_veteranoA)
        //    {
        //        if (Convert.ToDouble(RND_prob) < pro_aprendiz)

        //        {
        //           //peluquero = "Aprendiz";


        //        }
        //        else
        //        {
        //            //peluquero = "Veterano A";
        //        }
        //    }
        //    else
        //    {
        //        //peluquero = "Vererano B";

        //    }

        //}

    }
}
