using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4ADSExamenPractico2
{
    public class Vuelo
    {
        private int codigo;
        private string fechaVuelo;
        private string hora;

        public int Codigo { get => codigo; set => codigo = value; }
        public string FechaVuelo { get => fechaVuelo; set => fechaVuelo = value; }
        public string Hora { get => hora; set => hora = value; }

        public Pasajero Pasajero
        {
            get => default;
            set
            {
            }
        }

        public Registrador Registrador
        {
            get => default;
            set
            {
            }
        }

        public DetalleAsignacionPi DetalleAsignacionPi
        {
            get => default;
            set
            {
            }
        }

        public DetalleAsignacionAer DetalleAsignacionAer
        {
            get => default;
            set
            {
            }
        }

        public void agregarVuelo()
        {
            throw new System.NotImplementedException();
        }

        public void modificarVuelo()
        {
            throw new System.NotImplementedException();
        }

        public void eliminarVuelo()
        {
            throw new System.NotImplementedException();
        }

        public void buscarVuelo()
        {
            throw new System.NotImplementedException();
        }
    }
}