using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrabalhoIntegradoComSO.Package;
using TrabalhoIntegradoComSO.Structs;
using System.Threading;

namespace TrabalhoIntegradoComSO
{
    public partial class Form1 : Form
    {
         Fila p1, p2, p3, p4, p5;

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            

            int qt_ciclos=0;
            Processo temp = new Processo(0, null, 0, 0, 0);
            int prioridade = 1;

            while (p1.estaVazia() || p2.estaVazia() || p3.estaVazia() || p4.estaVazia() || p5.estaVazia() != false)
            {
                


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                textBox1.Text = p1.quantidade.ToString();
                textBox2.Text = p2.quantidade.ToString();
                textBox3.Text = p3.quantidade.ToString();
                textBox4.Text = p4.quantidade.ToString();
                textBox5.Text = p5.quantidade.ToString();

                StringBuilder aux = new StringBuilder();
                aux.AppendLine("Qt p1: " + p1.quantidade.ToString());
                aux.AppendLine("Qt p2: " + p2.quantidade.ToString());
                aux.AppendLine("Qt p3: " + p3.quantidade.ToString());
                aux.AppendLine("Qt p4: " + p4.quantidade.ToString());
                aux.AppendLine("Qt p5: " + p5.quantidade.ToString());
                MessageBox.Show(aux.ToString());


                if (p1.estaVazia())
                {
                    prioridade=2;

                }
                else if (p2.estaVazia())
                {
                    prioridade =3;

                }
                else if (p3.estaVazia())
                {
                    prioridade =4;

                }
                else if (p4.estaVazia())
                {
                    prioridade = 5;

                }
                else if (p5.estaVazia())
                {
                    break;
                }
                else break;

                switch (prioridade)
                {
                    case 1:
                        temp = (Processo)p1.desenfileirar();
                        if (temp != null)
                        {
                            Thread.Sleep(Convert.ToInt32(temp.TimeExec * 1000));
                            temp.Ciclos -= 1;
                            qt_ciclos += 1;
                            if (temp.Ciclos > 0)
                            {
                                p1.enfileirar(temp);
                            }
                            if (qt_ciclos > 10)
                            {
                                qt_ciclos = 0;
                                p1.enfileirar(p2.desenfileirar());
                            }
                        }
                        prioridade = 0;
                        break;

                    case 2:
                        temp = (Processo)p2.desenfileirar();
                        if (temp != null)
                        {
                            Thread.Sleep(Convert.ToInt32(temp.TimeExec * 1000));

                            temp.Ciclos -= 1;
                            qt_ciclos += 1;
                            if (temp.Ciclos > 0)
                            {
                                p2.enfileirar(temp);
                            }
                            if (qt_ciclos > 10)
                            {
                                qt_ciclos = 0;
                                p2.enfileirar(p3.desenfileirar());
                            }
                        }
                        prioridade = 0;
                        break;

                    case 3:

                        temp = (Processo)p3.desenfileirar();
                        if (temp != null)
                        {
                            Thread.Sleep(Convert.ToInt32(temp.TimeExec * 1000));
                            temp.Ciclos -= 1;
                            qt_ciclos += 1;
                            if (temp.Ciclos > 0)
                            {
                                p3.enfileirar(temp);
                            }
                            if (qt_ciclos > 10)
                            {
                                qt_ciclos = 0;
                                p3.enfileirar(p4.desenfileirar());
                            }
                        }
                        prioridade = 0;

                        break;
                    case 4:
                        temp = (Processo)p4.desenfileirar();
                        if (temp != null)
                        {
                            Thread.Sleep(Convert.ToInt32(temp.TimeExec * 1000));
                            temp.Ciclos -= 1;
                            if (temp.Ciclos > 0)
                            {
                                p5.enfileirar(temp);
                            }
                            if (qt_ciclos > 10)
                            {
                                qt_ciclos = 0;
                                p4.enfileirar(p5.desenfileirar());
                            }
                        }
                        prioridade = 0;
                        break;
                    case 5:
                        temp = (Processo)p5.desenfileirar();
                        if (temp != null)
                        {
                            Thread.Sleep(Convert.ToInt32(temp.TimeExec * 1000));
                            temp.Ciclos -= 1;
                            if (temp.Ciclos > 0)
                            {
                                p5.enfileirar(temp);
                            }
                        }
                        prioridade = 0;

                        break;

                    default:
                        
                        break;
                }

            }

            

        }
        private void btnLoadLista_Click(object sender, EventArgs e)
        {
            p1 = new Fila();
            p2 = new Fila();
            p3 = new Fila();
            p4 = new Fila();
            p5 = new Fila();

            LerArquivo.Ler(p1,p2,p3,p4,p5);




            textBox1.Text = p1.quantidade.ToString();
            textBox2.Text = p2.quantidade.ToString();
            textBox3.Text = p3.quantidade.ToString();
            textBox4.Text = p4.quantidade.ToString();
            textBox5.Text = p5.quantidade.ToString();

        }
    }
}
