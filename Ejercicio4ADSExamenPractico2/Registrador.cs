using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio4ADSExamenPractico2
{
    public class Registrador
    {
        private int idRegistrador;
        private string nombreRegistrador;
        private int apellidoRegistrador;

        public int IdRegistrador { get => idRegistrador; set => idRegistrador = value; }
        public string NombreRegistrador { get => nombreRegistrador; set => nombreRegistrador = value; }
        public int ApellidoRegistrador { get => apellidoRegistrador; set => apellidoRegistrador = value; }

        public void agregarRegistrador()
        {
            throw new System.NotImplementedException();
        }

        public void buscarRegistrador()
        {
            throw new System.NotImplementedException();
        }

        public void eliminarRegistrador()
        {
            throw new System.NotImplementedException();
        }

        public void modificarRegistrador()
        {
            throw new System.NotImplementedException();
        }
    }
}