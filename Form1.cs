using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculadora
{
    public partial class Form1 : Form
    { 

       double memoria_pre_operacao;
        double memoria_pos_operacao;
        double resultado;

        string operacao_selecionada;

        public Form1()
    {
        InitializeComponent();
    }
        private void button1_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            visor.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            visor.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            visor.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            visor.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            visor.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            visor.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            visor.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            visor.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            visor.Text += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = txtVisor.Text + "2";
            visor.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            memoria_pre_operacao = Convert.ToDouble(visor.Text);
            visor.Text = "";
            operacao_selecionada = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            memoria_pre_operacao = Convert.ToDouble(visor.Text);
            visor.Text = "";
            operacao_selecionada = "-";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            memoria_pre_operacao = Convert.ToDouble(visor.Text);
            visor.Text = "";
            operacao_selecionada = "*";
        }

        private void btn_dividir_Click(object sender, EventArgs e)
    {
        memoria_pre_operacao = Convert.ToDouble(visor.Text);
        visor.Text = "";
        operacao_selecionada = "/";
    }

    private void button17_Click(object sender, EventArgs e)
    {
        memoria_pos_operacao = Convert.ToDouble(visor.Text);

        if (operacao_selecionada == "+")
            resultado = memoria_pre_operacao + memoria_pos_operacao;

            if (operacao_selecionada == "-")
                resultado = memoria_pre_operacao - memoria_pos_operacao;

            if (operacao_selecionada == "*")
                resultado = memoria_pre_operacao * memoria_pos_operacao;

            if (operacao_selecionada == "/")
                resultado = memoria_pre_operacao / memoria_pos_operacao;

            visor.Text = resultado.ToString();

    }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            visor.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double valor_visor = Convert.ToDouble(visor.Text);

            valor_visor = valor_visor / 100;
            visor.Text = valor_visor.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            visor.Text += ",";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            visor.Clear();
        }
    }
}