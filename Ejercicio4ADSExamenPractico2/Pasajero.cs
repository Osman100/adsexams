using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4ADSExamenPractico2
{
    public class Pasajero
    {
        private int idPasajero;
        private string nombrePasajero;
        private string apellidoPasajero;
        private int idRegistrador;
        private string tipoAsiento;

        public int IdPasajero { get => idPasajero; set => idPasajero = value; }
        public string NombrePasajero { get => nombrePasajero; set => nombrePasajero = value; }
        public string ApellidoPasajero { get => apellidoPasajero; set => apellidoPasajero = value; }
        public string TipoAsiento { get => tipoAsiento; set => tipoAsiento = value; }


        public Registrador Registrador
        {
            get => default;
            set
            {
            }
        }



        public void agregarPasajero()
        {
            throw new System.NotImplementedException();
        }

        public void modificarPasajero()
        {
            throw new System.NotImplementedException();
        }

        public void buscarPasajero()
        {
            throw new System.NotImplementedException();
        }

        public void eliminarPasajero()
        {
            throw new System.NotImplementedException();
        }
    }
}