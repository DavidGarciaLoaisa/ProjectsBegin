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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void butScape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            SoliciteP.Enabled = false;
        }

        private void controlBotones ()
        {
            if (textName.Text.Trim() != String.Empty && textName.Text.All(Char.IsLetter))
            {
                SoliciteP.Enabled = true;
                errorProvider1.SetError(SoliciteP, "");
            }
            else
            {
                if (!(textName.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(SoliciteP, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(SoliciteP, "Debe introducir su nombre");
                }
                SoliciteP.Enabled = false;
                textName.Focus();
            }
        }
        
        private void textName_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
        private void SoliciteP_Click(object sender, EventArgs e)
        {
            using (Prestamos ventanaPrestamos = new Prestamos(textName.Text))
                ventanaPrestamos.ShowDialog();
        }
    }
}
