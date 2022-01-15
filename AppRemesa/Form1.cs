using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRemesa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool mover = false;


        private void Convertir_Click(object sender, EventArgs e)
        {
            #region De:
            try
            {
                if (Conversiones.SelectedItem.ToString() == "Dolar" && A.SelectedItem.ToString() == "Peso Dominicano")
                {
                    double TotalDolar;
                    TotalDolar = double.Parse(Cantidad.Text) * 57.25;
                    Total.Text = TotalDolar.ToString();
                }
                else if  (Conversiones.SelectedItem.ToString()== "Euro" && A.SelectedItem.ToString()=="Peso Dominicano")
                {
                    double TotalEuro;
                    TotalEuro = double.Parse(Cantidad.Text) * 66.04;
                    Total.Text = TotalEuro.ToString();
                }
                else if (Conversiones.SelectedItem.ToString()== "Libra Esterlina" && A.SelectedItem.ToString()== "Peso Dominicano")
                {
                    double TotalLibras;
                    TotalLibras = double.Parse(Cantidad.Text) * 79.14;
                    Total.Text = TotalLibras.ToString();
                } 
                else if (Conversiones.SelectedItem.ToString()== "Peso Colombiano" && A.SelectedItem.ToString()== "Peso Dominicano")
                {
                    double TotalpColombiano;
                    TotalpColombiano = double.Parse(Cantidad.Text) * 0.015;
                    Total.Text = TotalpColombiano.ToString();
                }
                else if(Conversiones.SelectedItem.ToString()== "Peso Dominicano" && A.SelectedItem.ToString()== "Peso Dominicano")
                {
                    double TotalPesoDo;
                    TotalPesoDo = double.Parse(Cantidad.Text) * 1;
                    Total.Text = TotalPesoDo.ToString();
                }

                
            }
            catch (Exception)
            {

            }
            #endregion

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solo esta programado para hacer las conversiones de las monedas que mas" +
                "se utilizan en Republica Dominicana, la app solo convierte a pesos dominicanos", "Informacion", MessageBoxButtons.OK);
        }
    }
}
