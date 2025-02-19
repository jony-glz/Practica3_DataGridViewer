using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3_DataGridViewer
{
    public partial class frmDateTimePick : Form
    {
        public frmDateTimePick()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // guardar las dos fechas
            DateTime nacimiento = dtpNacimiento.Value;
            DateTime calculo = dtpCalculo.Value;

            // obtiene la edad de diferencia entre la edad y el calculo
            int edad = calculo.Year - nacimiento.Year;
            int meses = calculo.Month - nacimiento.Month;
            int dias = calculo.Day - nacimiento.Day;

            // calcular la edad exacta
            if (dias<0)
            {
                meses--;
                dias += calculo.Day;
            }
            
            if (meses<0)
            {
                edad--;
                meses+=12;
            }
            

            // salida del resultado
            MessageBox.Show("Años: " + edad + ", meses: " + meses + ", dias: " + dias, "Resultado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            // nos permite activar la fecha de calculo cuando se haya elegido la fecha de
            // nacimiento, ademas el valor minimo para hacer la operacion es la fecha de
            // nacimiento en delante
            dtpCalculo.Enabled = true;
            dtpCalculo.MinDate = dtpNacimiento.Value;
        }

        private void btnCurp_Click(object sender, EventArgs e)
        {
            // la funcion substring permite cortar solo una parte del valor de una cadena
            string fecha = tbCurp.Text.Substring(4, 6);
            string sexo = tbCurp.Text.Substring(10,1);
            string edoNac = tbCurp.Text.Substring(11, 2);

            // 1) obtenemos si es hombre o mujer
            string sexo_out;
            if (sexo == "H")
            {
                sexo_out = "Hombre";
            }
            else
            {
                sexo_out = "Mujer";
            }

            // 2) obtenemos el estado de nacimiento
            string estado_de_Nacimiento = "";
            string[] estados = {
                "Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Coahuila", "Colima", "Chiapas", "Chihuahua",
                "Ciudad de México", "Durango", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "México", "Michoacán", "Morelos",
                "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora",
                "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas"
            };

            string[] edosCurp =
            {
                "AS", "BC", "BS", "CC", "CL", "CM", "CS", "CH", "DF", "DG", "GT", "GR", "HG", "JC", "MC", "MN",
                "MS", "NT", "NL", "OC", "PL", "QT", "QR", "SP", "SL", "SR", "TC", "TS", "TL", "VZ", "YN", "ZS"
            };

            // 2.1) lo que nos garantiza es que si las dos letras obtenidas se encuentran dentro del arreglo
            //  el estado de nacimiento sera el nombre completo de donde se encuentre
            for (int i = 0; i < edosCurp.Length; i++)
            {
                if (edoNac == edosCurp[i])
                {
                    estado_de_Nacimiento = estados[i];
                }
            }

            // 3) obtenemos la edad a partir del año de nacimiento

            // determina si son del 2000 o 1900 (de 00 a 25 los considera del 2000
            // y del 26 al 99 los considera del 1900)
            string year = fecha.Substring(0, 2);
            string mes = fecha.Substring(2,2);
            string dia = fecha.Substring(4,2);

            int years = int.Parse(year);
            int meses = int.Parse(mes);
            int dias = int.Parse(dia);

            // considera que si el año de nacimiento esta entre 00 y 25, será de los años 2000
            // de lo contrario, lo considerará de años 1900
            if (years > 0 && years < 25)
            {
                years += 2000;
            }
            else {
                years += 1900;
            }

            int res_dias = DateTime.Now.Day - dias;
            int res_meses = DateTime.Now.Month - meses;
            int res_years = DateTime.Now.Year - years;

            if (res_dias<0)
            {
                res_meses--;
                res_dias += DateTime.Now.Day;
            }
            if (res_meses < 0) { 
                res_years--;
                res_meses += 12;
            } 

            // 4) Nos muestra los datos de la curp
            MessageBox.Show(
                "Edad: " + res_years + " años, "+res_meses+" meses, "+res_dias+" dias.\nSexo: " + sexo_out + ".\nEstado de nacimiento: " + estado_de_Nacimiento,
                "Resultado de Curp",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
