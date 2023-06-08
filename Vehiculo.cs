using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Final
{
    public class Vehiculo
    {
        string numeroP;
        string marca;
        string modelo;

        public string NumeroP { get => numeroP; set => numeroP = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}