using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4ADSExamenPractico2
{
    public class Piloto
    {
        private int idPiloto;
        private int nombrePiloto;
        private int apellidoPilot;

        public int IdPiloto { get => idPiloto; set => idPiloto = value; }
        public int NombrePiloto { get => nombrePiloto; set => nombrePiloto = value; }
        public int ApellidoPilot { get => apellidoPilot; set => apellidoPilot = value; }

        public DetalleAsignacionPi DetalleAsignacionPi
        {
            get => default;
            set
            {
            }
        }

        public void agregarPiloto()
        {
            throw new System.NotImplementedException();
        }

        public void buscarPiloto()
        {
            throw new System.NotImplementedException();
        }

        public void modificarPiloto()
        {
            throw new System.NotImplementedException();
        }

        public void eliminarPiloto()
        {
            throw new System.NotImplementedException();
        }
    }
}