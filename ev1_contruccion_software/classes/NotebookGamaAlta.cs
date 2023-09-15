using ev1_contruccion_software.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev1_contruccion_software.classes
{
    internal class NotebookGamaAlta : IAbstractNotebooks
    {
        public string apagado()
        {
            return "El equipo se esta apagando";
        }

        public string encendido()
        {
            return "El equipo se esta encendiendo, tiempo aproximado: 15 seg";
        }

        public string iniciarApp()
        {
            return "Se está ejecutando Fusion 360";
        }

        public string iniciarJuego()
        {
            return "Se está ejecutando Witcher 3 en calidad Alta";
        }
    }
}
