using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4ADSExamenPractico2
{
    public partial class RegistroPasajero : Form
    {
        public RegistroPasajero()
        {
            InitializeComponent();
        }

        public void registrarPasajero()
        {
            Pasajero pasajero = new Pasajero();
            pasajero.IdPasajero = int.Parse(idPasajero.Text);
            pasajero.NombrePasajero = nombrePasajero.Text;
            pasajero.ApellidoPasajero = apellidoPasajero.Text;
            pasajero.TipoAsiento = tipoAsiento.Text;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void registro_Click(object sender, EventArgs e)
        {
            registrarPasajero();
        }
    }
}
