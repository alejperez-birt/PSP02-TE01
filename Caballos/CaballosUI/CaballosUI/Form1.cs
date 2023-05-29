using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;



namespace CaballosUI
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int longitudBarra = 100;
        private bool final = false;
        private Object bloqueoCarrera = new Object();

        private Thread hiloCaballo01;
        private Thread hiloCaballo02;
        private Thread hiloCaballo03;
        private Thread hiloCaballo04;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReiniciarBarrasProgreso();
            ReiniciarElementos();
        }

        private void btn_Empezar_Click(object sender, EventArgs e)
        {
            hiloCaballo01 = new Thread(ProgresoCaballo01);
            hiloCaballo01.Priority = ThreadPriority.BelowNormal;

            hiloCaballo02 = new Thread(ProgresoCaballo02);
            hiloCaballo02.Priority = ThreadPriority.AboveNormal;

            hiloCaballo03 = new Thread(ProgresoCaballo03);
            hiloCaballo03.Priority = ThreadPriority.Lowest;

            hiloCaballo04 = new Thread(ProgresoCaballo04);
            hiloCaballo04.Priority = ThreadPriority.Highest;

            hiloCaballo01.Start();

            hiloCaballo02.Start();

            hiloCaballo03.Start();

            hiloCaballo04.Start();
        }

        private void ProgresoCaballo01()
        {
            while (!final)
            {
                Correr(prB_Caballo01);
            }
        }
        private void ProgresoCaballo02()
        {
            while (!final)
            {
                Correr(prB_Caballo02);
            }
        }

        private void ProgresoCaballo03()
        {
            while (!final)
            {
                Correr(prB_Caballo03);
            }
        }

        private void ProgresoCaballo04()
        {
            while (!final)
            {
                Correr(prB_Caballo04);
            }
        }


        private void Correr(ProgressBar progressBar)
        {
            try
            {
                if (this == null) return;
                Invoke(new Action(() => {
                    progressBar.Step = random.Next(longitudBarra / 10);
                    progressBar.PerformStep();
                    Thread.Sleep(50);

                    if (progressBar.Value >= 100)
                    {
                        progressBar.Value = 100;
                        txt_Ganador.Text = progressBar.Name.ToString().Substring(4);
                        FinCarrera();
                    }

                }));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        private void FinCarrera()
        {
            lock (bloqueoCarrera)
            {
                if (!final)
                {
                    final = true;

                    lbl_Resultado01.Text = prB_Caballo01.Value.ToString();
                    lbl_Resultado02.Text = prB_Caballo02.Value.ToString();
                    lbl_Resultado03.Text = prB_Caballo03.Value.ToString();
                    lbl_Resultado04.Text = prB_Caballo04.Value.ToString();

                    lbl_Ganador.Visible = true;
                    txt_Ganador.Visible = true;
                    lbl_Resultado01.Visible = true;
                    lbl_Resultado02.Visible = true;
                    lbl_Resultado03.Visible = true;
                    lbl_Resultado04.Visible = true;

                    btn_Empezar.Enabled = false;
                    btn_Reiniciar.Enabled = true;
                }
            }
        }

    private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            final = false;

            btn_Empezar.Enabled = true;
            btn_Reiniciar.Enabled = false;

            ReiniciarBarrasProgreso();
            ReiniciarElementos();
        }

        private void ReiniciarElementos()
        {
            lbl_Ganador.Visible = false;
            txt_Ganador.Visible = false;
            lbl_Resultado01.Visible = false;
            lbl_Resultado02.Visible = false;
            lbl_Resultado03.Visible = false;
            lbl_Resultado04.Visible = false;
        }

        private void ReiniciarBarrasProgreso()
        {
            prB_Caballo01.Minimum = 0;
            prB_Caballo01.Maximum = longitudBarra;
            prB_Caballo01.Value = 0;
            prB_Caballo01.Step = 1;

            prB_Caballo02.Minimum = 0;
            prB_Caballo02.Maximum = longitudBarra;
            prB_Caballo02.Value = 0;
            prB_Caballo02.Step = 1;

            prB_Caballo03.Minimum = 0;
            prB_Caballo03.Maximum = longitudBarra;
            prB_Caballo03.Value = 0;
            prB_Caballo03.Step = 1;

            prB_Caballo04.Minimum = 0;
            prB_Caballo04.Maximum = longitudBarra;
            prB_Caballo04.Value = 0;
            prB_Caballo04.Step = 1;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (hiloCaballo01.IsAlive)
            {
                hiloCaballo01.Abort();
            }

            if (hiloCaballo02.IsAlive)
            {
                hiloCaballo02.Abort();
            }

            if (hiloCaballo03.IsAlive)
            {
                hiloCaballo03.Abort();
            }

            if (hiloCaballo04.IsAlive)
            {
                hiloCaballo04.Abort();
            }

        }
    }
}
