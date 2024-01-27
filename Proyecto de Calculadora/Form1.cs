using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelCalculadoraE.Visible = true;
            panelCalculadoraP.Visible = false;
            panelCalculadoraC.Visible = false;
            this.ClientSize = new Size(465, 615);
            // Desactivar el botón de maximizar
            this.MaximizeBox = false;

            // Desactivar el botón de minimizar
            //    this.MinimizeBox = false;
        }

        private void programadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCalculadoraP.Visible = true;
            panelCalculadoraE.Visible = false;
            panelCalculadoraC.Visible = false;
            this.ClientSize = new Size(885, 620);
        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCalculadoraC.Visible = true;
            panelCalculadoraE.Visible = false;
            panelCalculadoraP.Visible = false;
            this.ClientSize = new Size(918, 620);
        }

        private void estandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCalculadoraE.Visible = true;
            panelCalculadoraP.Visible = false;
            panelCalculadoraC.Visible = false;
            this.ClientSize = new Size(465, 615);
        }

        #region Botones de Calculadora Estandar

        private void btn0_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + "0";
        }

        private void btn1_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + "1";
        }

        private void btn2_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + "2";
        }

        private void btn3_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + "3";
        }
        private void btn4_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + "4";
        }

        private void btn5_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + "5";
        }

        private void btn6_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + "6";
        }

        private void btn7_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + "7";
        }

        private void btn8_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + "8";
        }

        private void btn9_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + "9";
        }

        private void btnCE_E_Click(object sender, EventArgs e)
        {
            display_E.Text = "";
        }

        private void btnC_E_Click(object sender, EventArgs e)
        {
            display_E.Text = "";
        }

        private void btnComa_E_Click(object sender, EventArgs e)
        {
            display_E.Text = display_E.Text + ",";
        }

        #endregion



        #region Botones de Calculadora Programadora
        private void btn0_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + "0";
        }

        private void btn1_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + "1";
        }

        private void btn2_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + "2";
        }

        private void btn3_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + "3";
        }

        private void btn4_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + "4";
        }

        private void btn5_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + "5";
        }

        private void btn6_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + "6";
        }

        private void btn7_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + "7";
        }

        private void btn8_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + "8";
        }

        private void btn9_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + "9";
        }

        private void btnComa_P_Click(object sender, EventArgs e)
        {
            display_P.Text = display_P.Text + ",";
        }

        private void btnCE_P_Click(object sender, EventArgs e)
        {
            display_P.Text = "";
        }

        private void btnCc_P_Click(object sender, EventArgs e)
        {
            display_E.Text = "";
        }

        #endregion


        #region Botones de Calculadora Cientifica
        private void btn0_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + "0";
        }

        private void btn1_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + "1";
        }

        private void btn2_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + "2";
        }

        private void btn3_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + "3";
        }

        private void btn4_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + "4";
        }

        private void btn5_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + "5";
        }

        private void btn6_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + "6";
        }

        private void btn7_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + "7";
        }

        private void btn8_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + "8";
        }

        private void btn9_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + "9";
        }

        private void btnComa_C_Click(object sender, EventArgs e)
        {
            display_C.Text = display_C.Text + ",";
        }

        private void btnCE_C_Click(object sender, EventArgs e)
        {
            display_C.Text = "";
        }

        private void btnC_C_Click(object sender, EventArgs e)
        {
            display_C.Text = "";
        }


        #endregion
    }
}
