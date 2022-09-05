using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_37450_37460_exercício_triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double valor1 = 0.0, valor2 = 0.0, valor3 = 0.0, altura = 0.0, Base = 0.0, area = 0.0;
        private void frmCalculadoraTriângulo(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcbImagem.BackgroundImage = null;
            label5.Visible = false;
            btnlimparl.Visible = false;
            cmbtp.SelectedIndex = 0;
            gbrar.Enabled = false;
        }

        private void rbtipot_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtipot.Checked)
            {
                gbtp.Enabled = true;
                cmbtp.SelectedIndex = 0;
            }
            else
            {
                gbtp.Enabled = false;
            }

        }

        private void rbar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbar.Checked)
            {
                gbrar.Enabled = true;
                cmbtp.SelectedIndex = 1;

            }
            else
            {
                gbrar.Enabled = false;
            }
        }

        private void cmbtp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtp.SelectedIndex == 0)
            {
                rbtipot.Checked = true;
            }
            if (cmbtp.SelectedIndex == 1)
            {
                rbar.Checked = true;

            }
        }

        private void pcbImagem_Click(object sender, EventArgs e)
        {
            EntradaTp();

        }

        private void EntradaTp()
        {
            valor1 = Convert.ToDouble(txtx.Text);
            valor2 = Convert.ToDouble(txty.Text);
            valor3 = Convert.ToDouble(txtz.Text);

        }

        private void entradaa()
        {
            Base = Convert.ToDouble(txtbase.Text);
            altura = Convert.ToDouble(txtaltura.Text);
        }

        private void txtbase_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            if (rbtipot.Checked)
            {
                LimparT();
            }
            if (rbar.Checked)
            {
                LimparA();
            }
        }

        private void rctxtresp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LimparA()
        {
            txtbase.Clear();
            txtaltura.Clear();
            txtare.Clear();
        }

        private void LimparT()
        {
            txtresul.Clear();
            txtx.Clear();
            txty.Clear();
            txtz.Clear();
            pcbImagem.Image = null;
        }

        private void btnlimparl_Click(object sender, EventArgs e)
        {
            rctxtresp.Clear();
        }

        private void crbhab_CheckedChanged(object sender, EventArgs e)
        {
            if (crbhab.Checked)
            {
                btnlimparl.Visible = true;
                label5.Visible = true;

            }
            else
            {
                btnlimparl.Visible = false;
                label5.Visible = false;
            }
        }

        private void btncalculadora_Click(object sender, EventArgs e)
        {
            
               
                

                if (rbtipot.Checked)
                {

                try
                {
                    EntradaTp();
                }
                catch
                {
                    MessageBox.Show("Erro na Entrada de dados!!", "Tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimparT();
                    return;
                }
                EntradaTp();
                    if (valor1 + valor2 > valor3)
                    {
                        if (valor2 + valor3 > valor1)
                        {
                            if (valor3 + valor1 > valor2)
                            {
                                if (valor1 == valor2 & valor1 == valor3)
                                {
                                    txtresul.Text = "triângulo equilátero";
                                    rctxtresp.Text += "x" + " = " + valor1 + "y" + " = " + valor2 + "z" + " = " + valor3 + " = " + "Triângulo Equilátero" + " \n";
                                    pcbImagem.Image = Properties.Resources.equilátero;
                                }
                                else
                                {
                                    if (valor1 == valor2 || valor1 == valor3 || valor2 == valor3)
                                    {
                                        txtresul.Text = " triângulo isósceles";
                                        rctxtresp.Text += "x" + " = " + valor1 + "y" + " = " + valor2 + "z" + " = " + valor3 + " = " + "Triângulo Isósceles" + " \n";
                                        pcbImagem.Image = Properties.Resources.isósceles;
                                    }
                                    else txtresul.Text = " triângulo escaleno";
                                    rctxtresp.Text += "x" + " = " + valor1 + "y" + " = " + valor2 + "z" + " = " + valor3 + " = " + "Triângulo Escaleno" + " \n";
                                    pcbImagem.Image = Properties.Resources.escaleno;

                                }

                            }
                            else
                            {
                                txtresul.Text = "Vc não possui um triângulo";
                                rctxtresp.Text += "x" + " = " + valor1 + "y" + " = " + valor2 + "z" + " = " + valor3 + " = " + "Não é um triângulo" + " \n";
                                pcbImagem.Image = Properties.Resources.nãotriângulo;
                            }
                        }
                        else
                        {
                            txtresul.Text = "Vc não possui um triângulo";
                            rctxtresp.Text += "x" + " = " + valor1 + "y" + " = " + valor2 + "z" + " = " + valor3 + " = " + "Não é um triângulo" + " \n";
                            pcbImagem.Image = Properties.Resources.nãotriângulo;
                        }
                    }
                    else
                    {
                        txtresul.Text = "Vc não possui um triângulo";
                        rctxtresp.Text += "x" + " = " + valor1 + "y" + " = " + valor2 + "z" + " = " + valor3 + " = " + "Não é um triângulo" + " \n";
                        pcbImagem.Image = Properties.Resources.nãotriângulo;
                    }

                }

                if (rbar.Checked)
                {
                
                {
                    try
                    {
                        entradaa();
                    }
                    catch
                    {
                        MessageBox.Show("Erro na Entrada de dados!!", "Tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimparA();
                        return;
                    }
                    entradaa();
                    area = (Base * altura) / 2;
                    txtare.Text = area.ToString();
                    rctxtresp.Text += "base" + " = " + Base + " altura " + " = " + altura + " = " + "área" + " = " + area + " \n";
                }
            }
        }
    }
}   
