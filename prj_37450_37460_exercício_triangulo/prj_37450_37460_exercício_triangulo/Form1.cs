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
        double valor1 = 0.0, valor2 = 0.0, valor3 = 0.0;
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
            cmbtp.SelectedIndex = 0;
            btnlimparl.Enabled = false;
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

        private void txtbase_TextChanged(object sender, EventArgs e)
        {

        }

        private void crbhab_CheckedChanged(object sender, EventArgs e)
        {
            if (crbhab.Checked)
            {
                btnlimparl.Enabled = true;

            }
        }

        private void btncalculadora_Click(object sender, EventArgs e)
        {
            EntradaTp();
            if (rbtipot.Checked)
            {
                if (valor1 < valor2 + valor3)
                {
                    if (valor2 < valor1 + valor3)
                    {
                        if (valor3 < valor2 + valor1)
                        {
                            if (valor1 == valor2 & valor1 == valor3)
                            {
                                txtresul.Text = "Vc tem um triângulo equilatero";
                            }
                            else
                            {
                                if (valor1 == valor2 || valor1 == valor3 || valor2 == valor3)
                                {
                                    txtresul.Text = "Vc tem um triângulo isósceles";
                                }
                                else txtresul.Text = "Vc tem um triângulo escaleno";
                            }
                        }
                        else txtresul.Text = "Vc não possui um triângulo";
                    }

                }
            }
        }
    }
}    
