using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAsma
{
    public partial class Cuestionario1 : Form
    {
        private int valorSumaAnsiedad = 0;
        private int valorSumaDepresion = 0;

        public Cuestionario1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)

            //Validación 
        {
            if (!rdb1.Checked && !rdb2.Checked && !rdb3.Checked && !rdb4.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 1", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            if (!rdb5.Checked && !rdb6.Checked && !rdb7.Checked && !rdb8.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 2", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb9.Checked && !rdb10.Checked && !rdb11.Checked && !rdb12.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 3", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb13.Checked && !rdb14.Checked && !rdb15.Checked && !rdb16.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 4", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb17.Checked && !rdb18.Checked && !rdb19.Checked && !rdb20.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 5", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb21.Checked && !rdb22.Checked && !rdb23.Checked && !rdb24.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 6", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb25.Checked && !rdb26.Checked && !rdb27.Checked && !rdb28.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 7", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb29.Checked && !rdb30.Checked && !rdb31.Checked && !rdb32.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 8", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb33.Checked && !rdb34.Checked && !rdb35.Checked && !rdb36.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 9", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb37.Checked && !rdb38.Checked && !rdb39.Checked && !rdb40.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 10", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb41.Checked && !rdb42.Checked && !rdb43.Checked && !rdb44.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 11", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb45.Checked && !rdb46.Checked && !rdb47.Checked && !rdb48.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 12", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb49.Checked && !rdb50.Checked && !rdb51.Checked && !rdb52.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 13", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdb53.Checked && !rdb54.Checked && !rdb55.Checked && !rdb56.Checked)
            {
                MessageBox.Show("Debe completar la pregunta 14", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //PREGUNTAS ANSIEDAD

            RadioButton[] pregunta1 = new RadioButton[4];

            pregunta1[0] = rdb1;
            pregunta1[1] = rdb2;
            pregunta1[2] = rdb3;
            pregunta1[3] = rdb4;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta1[i].Checked)
                {
                    valorSumaAnsiedad = valorSumaAnsiedad + i;                       
                }
            }
            RadioButton[] pregunta2 = new RadioButton[4];

            pregunta2[0] = rdb9;
            pregunta2[1] = rdb10;
            pregunta2[2] = rdb11;
            pregunta2[3] = rdb12;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta2[i].Checked)
                {
                    valorSumaAnsiedad = valorSumaAnsiedad + i;
                }
            }
            RadioButton[] pregunta3 = new RadioButton[4];

            pregunta3[0] = rdb17;
            pregunta3[1] = rdb18;
            pregunta3[2] = rdb19;
            pregunta3[3] = rdb20;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta3[i].Checked)
                {
                    valorSumaAnsiedad = valorSumaAnsiedad + i;
                }
            }
            RadioButton[] pregunta4 = new RadioButton[4];

            pregunta4[0] = rdb25;
            pregunta4[1] = rdb26;
            pregunta4[2] = rdb27;
            pregunta4[3] = rdb28;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta4[i].Checked)
                {
                    valorSumaAnsiedad = valorSumaAnsiedad + i;
                }
            }
            RadioButton[] pregunta5 = new RadioButton[4];

            pregunta5[0] = rdb33;
            pregunta5[1] = rdb34;
            pregunta5[2] = rdb35;
            pregunta5[3] = rdb36;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta5[i].Checked)
                {
                    valorSumaAnsiedad = valorSumaAnsiedad + i;
                }
            }
            RadioButton[] pregunta6 = new RadioButton[4];

            pregunta6[0] = rdb41;
            pregunta6[1] = rdb42;
            pregunta6[2] = rdb43;
            pregunta6[3] = rdb44;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta6[i].Checked)
                {
                    valorSumaAnsiedad = valorSumaAnsiedad + i;
                }
            }
            RadioButton[] pregunta7 = new RadioButton[4];

            pregunta7[0] = rdb49;
            pregunta7[1] = rdb50;
            pregunta7[2] = rdb51;
            pregunta7[3] = rdb52;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta7[i].Checked)
                {
                    valorSumaAnsiedad = valorSumaAnsiedad + i;
                }
            }

            //PREGUNTAS DEPRESIÓN

            RadioButton[] pregunta8 = new RadioButton[4];

            pregunta8[0] = rdb5;
            pregunta8[1] = rdb6;
            pregunta8[2] = rdb7;
            pregunta8[3] = rdb8;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta8[i].Checked)
                {
                    valorSumaDepresion = valorSumaDepresion + i;
                }
            }
            RadioButton[] pregunta9 = new RadioButton[4];

            pregunta9[0] = rdb13;
            pregunta9[1] = rdb14;
            pregunta9[2] = rdb15;
            pregunta9[3] = rdb16;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta9[i].Checked)
                {
                    valorSumaDepresion = valorSumaDepresion + i;
                }
            }
            RadioButton[] pregunta10 = new RadioButton[4];

            pregunta10[0] = rdb21;
            pregunta10[1] = rdb22;
            pregunta10[2] = rdb23;
            pregunta10[3] = rdb24;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta10[i].Checked)
                {
                    valorSumaDepresion = valorSumaDepresion + i;
                }
            }
            RadioButton[] pregunta11 = new RadioButton[4];

            pregunta11[0] = rdb29;
            pregunta11[1] = rdb30;
            pregunta11[2] = rdb31;
            pregunta11[3] = rdb32;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta11[i].Checked)
                {
                    valorSumaDepresion = valorSumaDepresion + i;
                }
            }
            RadioButton[] pregunta12 = new RadioButton[4];

            pregunta12[0] = rdb37;
            pregunta12[1] = rdb38;
            pregunta12[2] = rdb39;
            pregunta12[3] = rdb40;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta12[i].Checked)
                {
                    valorSumaDepresion = valorSumaDepresion + i;
                }
            }
            RadioButton[] pregunta13 = new RadioButton[4];

            pregunta13[0] = rdb45;
            pregunta13[1] = rdb46;
            pregunta13[2] = rdb47;
            pregunta13[3] = rdb48;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta13[i].Checked)
                {
                    valorSumaDepresion = valorSumaDepresion + i;
                }
            }
            RadioButton[] pregunta14 = new RadioButton[4];

            pregunta14[0] = rdb53;
            pregunta14[1] = rdb54;
            pregunta14[2] = rdb55;
            pregunta14[3] = rdb56;

            for (int i = 0; i < 4; i++)
            {
                if (pregunta14[i].Checked)
                {
                    valorSumaDepresion = valorSumaDepresion + i;
                }
            }

            var mensajeFinal = @"Ha finalizado su evaluación con éxito. Para analizar los resultados " +
                "se presentan los siguientes rangos: " + "\n" +
                "Si su resultado está entre 0 y 7: Usted no presenta ni ansiedad ni depresión " + "\n" +
                "Si su resultado está entre 8 y 10: Usted presenta síntomas asociaciados al transtorno " + "\n" +
                "Si su resultado está entre 11 y 21: Usted presenta un cuadro clínico completo " + "\n" +
                "Resultado para la subescala de ansiedad: " + valorSumaAnsiedad + "\n" +
                "Resultado para la subescala de depresión: " + valorSumaDepresion + "\n";


            MessageBox.Show(mensajeFinal, "Resultados", MessageBoxButtons.OK);

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
