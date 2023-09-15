
using ev1_contruccion_software.classes;
using ev1_contruccion_software.interfaces;
using System;

Console.WriteLine("Construcción de Software"); 
Console.WriteLine("Evaluación 1");
Console.WriteLine("Integrantes:\n - Kristell Molina\n - Joaquin Rios\n - Monica Vergara\n");
Console.WriteLine("Bienvenido a la Tienda de Samsung\n");
IAbstractFactoryProductosElectronicos fabrica = seleccionarFabrica();
seleccionarEquipo(fabrica);



IAbstractFactoryProductosElectronicos seleccionarFabrica()
{

    Console.WriteLine("Tenemos para ofrecer: \n1. Equipos de Gama Baja\n2. Equipos de Gama Alta\n");
    int opcion = leerNumero("Por favor elija que equipo esta buscando:",1,2);
    Console.Clear();
    switch (opcion)
    {
        case 1:
        {
            Console.WriteLine("Has seleccionado equipos de gama baja\n");
            return GamaBajaFactory.GetInstance();
        }
        case 2:
        {
            Console.WriteLine("Has seleccionado equipos de gama alta");
            return GamaAltaFactory.GetInstance();
        } 
        default:
        {
            return null;
        }
    }
}

void seleccionarEquipo(IAbstractFactoryProductosElectronicos fabrica) 
{
    Console.WriteLine("¿Que tipo de equipo buscas?");
    Console.WriteLine("\n1. Smartphone\n2. Notebook\n");
    int opcion = leerNumero("Elija una opción:", 1, 2);
    Console.Clear();
    switch (opcion)
    {
        case 1:
            {
                Console.WriteLine("Has seleccionado Smartphone\n");
                fabrica.CrearCelular();
                break;
            }
        case 2:
            {
                Console.WriteLine("Has seleccionado Notebook");
                fabrica.CrearNotebook();
                break;
            }
        default:
            {
                break;
            }
    }
}



int leerNumero(string mensaje, int? min = null, int? max = null)
{
    int numero;
    bool esValido;

    do
    {
        Console.Write(mensaje);
        esValido = int.TryParse(Console.ReadLine(), out numero);

        if (!esValido)
        {
            Console.WriteLine("Ingreso no valido, Por favor intente un numero.");
        }
        else if (min.HasValue && numero < min)
        {
            Console.WriteLine($"El número debe ser igual o mayor que {min}.");
            esValido = false;
        }
        else if (max.HasValue && numero > max)
        {
            Console.WriteLine($"El número debe ser igual o menor que {max}.");
            esValido = false;
        }
    } while (!esValido);

    return numero;
}