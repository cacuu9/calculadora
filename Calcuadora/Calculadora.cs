using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuadora
{
    public partial class Calculadora : Form
    {
        Color colorInicial; // colocamos esto aca para que quede un respaldo del color inicial (gris claro)

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Efectuo("+");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Efectuo("-");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Efectuo("x");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Efectuo("/");
        }

        void Efectuo(string operacion)
        {
            double num1, num2, resultado = 0;
            string resuelvo = "";

            num1 = NumeroDouble(txtNum1.Text);
            num2 = NumeroDouble(txtNum2.Text);
            Boolean operok = true;
            txtNum1.Text = Convert.ToString(num1);
            txtNum2.Text = Convert.ToString(num2);
            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    //resuelvo = num1 + "+" + num2 + "=" + resultado;
                    break;
                case "-":
                    resultado = num1 - num2;
                    //resuelvo = num1 + "-" + num2 + "=" + resultado;
                    break;
                case "x":
                    resultado = num1 * num2;
                    //resuelvo = num1 + "x" + num2 + "=" + resultado;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        //resuelvo = num1 + "/" + num2 + "=" + resultado;
                    }
                    else
                    {
                        operok = false;
                    }
                    break;
            }//Switch

            if (operok)
            {
                resuelvo = num1 + operacion + num2 + "=" + resultado;
                lblResultado.Text = Convert.ToString(resultado);
                cboResultados.Items.Add(resuelvo);
                lstResultados.Items.Add(resuelvo);
                //cboResultados.Items.Add(resultado);
                //lstResultados.Items.Add(resultado);
            }
            else
            {
                lblResultado.Text = "No existe";
            }

        }//Efectuo



        double NumeroDouble(string valor)
        {
            double resultado;
            if (!double.TryParse(valor, out resultado))
            {
                resultado = 0;
            }
            return (resultado);
        }//NumeroDouble

        private void btnPotencia_Click(object sender, EventArgs e)
        {

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {

        }

        private void btnLogaritmo_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            colorInicial = this.BackColor;
            chkResultados.Checked = true;
            chkFondoAmarillo.Checked = false;
            rbEstandar.Checked = true;

            ActualizoPantalla();
        }

        void ActualizoPantalla()
        {
            lstResultados.Visible = chkResultados.Checked;
            cboResultados.Visible = chkResultados.Checked;
            if (chkFondoAmarillo.Checked){
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = colorInicial;
            }

            gbCientificas.Visible = rbCientifica.Checked;
        }

        private void chkFondoAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }

        private void rbEstandar_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }

        private void rbCientifica_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }

        private void chkResultados_CheckedChanged(object sender, EventArgs e)
        {
            ActualizoPantalla();
        }
    }
}