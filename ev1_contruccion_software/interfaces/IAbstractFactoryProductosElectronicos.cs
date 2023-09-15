using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev1_contruccion_software.interfaces
{
    internal interface IAbstractFactoryProductosElectronicos
    {
        IAbstractCelulares CrearCelular();
        IAbstractNotebooks CrearNotebook();
    }
}
