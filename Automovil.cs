using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Final
{
    public class Automovil : Vehiculo
    {
        string nPuertas;
        int nPasajeros;

        public string NPuertas { get => nPuertas; set => nPuertas = value; }
        public int NPasajeros { get => nPasajeros; set => nPasajeros = value; }
    }
}