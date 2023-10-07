using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4ADSExamenPractico2
{
    public class Aeromoza
    {
        private int idAeromoza;
        private string nombreAeromoza;
        private string apellidoAeromoza;
        private double sueldo;

        public int IdAeromoza { get => idAeromoza; set => idAeromoza = value; }
        public string NombreAeromoza { get => nombreAeromoza; set => nombreAeromoza = value; }
        public string ApellidoAeromoza { get => apellidoAeromoza; set => apellidoAeromoza = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public DetalleAsignacionAer DetalleAsignacionAer
        {
            get => default;
            set
            {
            }
        }

        public void agregarAeromoza()
        {
            throw new System.NotImplementedException();
        }

        public void buscarAeromoza()
        {
            throw new System.NotImplementedException();
        }

        public void eliminarAeromoza()
        {
            throw new System.NotImplementedException();
        }

        public void modificarAeromoza()
        {
            throw new System.NotImplementedException();
        }
    }
}