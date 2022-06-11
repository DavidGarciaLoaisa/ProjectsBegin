using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosApp
{
    public partial class Prestamos : Form
    {
        string nombre_cliente;
        string[] estado_civil = {"Soltero", "Casado", "Unión Libre"};
        int[] Cuotas_disponibles = { 12, 18, 24, 36, 48, 60, 72, 90, 120, 180, 240 };
        string[] lugares_disponibles;
        Dictionary<int, double> intereses_base;
        public Prestamos(string textName)
        {
            InitializeComponent();
            nombre_cliente = textName;

            string listado_Ciudades = Properties.Resources.Listado.ToString();
            lugares_disponibles = listado_Ciudades.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);

            intereses_base = new Dictionary<int, double>();
            int i;
            double intereses;
            for (i = 0, intereses = 3.0; i < Cuotas_disponibles.Length; i++, intereses += 0.5)
            {
                intereses_base[Cuotas_disponibles[i]] = intereses;
            }
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            popularCuotas();
            popularEstado_civil();
            popularCiudades();
            Saludo.Text += nombre_cliente;
        }
        void popularCuotas()
        {
            for (int i = 0; i < Cuotas_disponibles.Length; ++i)
            {
                cuota.Items.Add(Cuotas_disponibles[i]);
            }
        }
        void popularEstado_civil()
        {
            for (int i = 0; i < estado_civil.Length; ++i)
            {
                estado.Items.Add(estado_civil[i]);
            }
        }
        void popularCiudades()
        {
            for (int i = 0; i < lugares_disponibles.Length; ++i)
            {
                lugares.Items.Add(lugares_disponibles[i]);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double Calcular_intereses ()
        {
            int cuotasPedidas = (int)cuota.SelectedItem;
            string estadoSelect = estado.SelectedItem.ToString().ToLower();
            string lugarSelect = lugares.SelectedItem.ToString().ToLower();
            double intereses = intereses_base[cuotasPedidas];

            if (new[] { "Casado" }.Contains(estadoSelect))
            {
                intereses -= 0.3;
            }
            if (new[] {"Soltero"}.Contains(estadoSelect))
            {
                intereses += 0.3;
            }
            if (new[] { "buga", "cartago", "palmira", "roldanillo", "toro", "tumaco" }.Contains(lugarSelect))
            {
                intereses -= 0.3;
            }
            return intereses;
        }

        private void buttonComfirmar_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(DatosPersonales, "");
                        errorProvider1.SetError(DatosPrestamo, "");
                        double interes_Mensual = Calcular_intereses();
                        double monto_Pedido = double.Parse(monto.Text);
                        int cuotas_Pedidas = (int)cuota.SelectedItem;
                        double intereses_Total = monto_Pedido * (interes_Mensual / 100) * cuotas_Pedidas;
                        double monto_a_pagar = monto_Pedido + intereses_Total;
                        string mensaje = "Su prestamo por " + monto_Pedido + " en " + cuotas_Pedidas + " cuotas se concederá con un interés del " + interes_Mensual + "% mensual.\nEL monto final asciende a " + monto_a_pagar;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Calculo de intereses", buttons);
                        break;
                    }

                case 1:
                    {
                        errorProvider1.SetError(DatosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(DatosPrestamo, "");
                        break;
                    }

                case 2:
                    {
                        errorProvider1.SetError(DatosPrestamo, "Debe ingresar un monto numerico y una cantidad de cuotas");
                        errorProvider1.SetError(DatosPersonales, "");
                        break;
                    }
            }
        }
        int validaciones ()
        {
            if ((estado.SelectedIndex <= -1) || (lugares.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                if (!(monto.Text.All(Char.IsDigit)) || (monto.Text == "") || (cuota.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
