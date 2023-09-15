
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
    int opcion = leerNumero("Por favor elija que equipo esta buscando: ",1,2);
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
    int opcion = leerNumero("Elija una opción: ", 1, 2);
    switch (opcion)
    {
        case 1:
            {
                Console.WriteLine("Has seleccionado Smartphone\n");
                IAbstractCelulares celular = fabrica.CrearCelular();
                telefonoSeleccionado(celular);
                break;
            }
        case 2:
            {
                Console.WriteLine("Has seleccionado Notebook\n");
                IAbstractNotebooks notebook = fabrica.CrearNotebook();
                notebookSeleccionado(notebook);
                break;
            }
        default:
            {
                break;
            }
    }
}

void telefonoSeleccionado(IAbstractCelulares celular)
{
    Console.WriteLine("Es hora de probarlo, que quieres hacer con tu equipo?");
    Console.WriteLine("1. Encender\n2. Apagar\n3. Abrir una aplicacion\n4. Tomar una foto\n5. Salir\n");
    int opcion;
    do
    {
        opcion = leerNumero("Elija una opción:", 1, 5);
        switch (opcion)
        {
            case 1:
                {
                    Console.WriteLine(celular.encendido());
                    break;
                }
            case 2:
                {
                    Console.WriteLine(celular.apagado());
                    break;
                }
            case 3:
                {
                    Console.WriteLine(celular.iniciarApp());
                    break;
                }
            case 4:
                {
                    Console.WriteLine(celular.tomarFoto());
                    break;
                }
            case 5:
                {
                    break;
                }
        }
    } while(opcion < 5);
    
}

void notebookSeleccionado(IAbstractNotebooks notebook)
{
    Console.WriteLine("Es hora de probarlo, que quieres hacer con tu equipo?");
    Console.WriteLine("1. Encender\n2. Apagar\n3. Abrir una aplicacion\n4. Iniciar un juego\n5. Salir\n");
    int opcion;
    do
    {
        opcion = leerNumero("Elija una opción: ", 1, 5);
        switch (opcion)
        {
            case 1:
                {
                    Console.WriteLine(notebook.encendido());
                    break;
                }
            case 2:
                {
                    Console.WriteLine(notebook.apagado());
                    break;
                }
            case 3:
                {
                    Console.WriteLine(notebook.iniciarApp());
                    break;
                }
            case 4:
                {
                    Console.WriteLine(notebook.iniciarJuego());
                    break;
                }
            case 5:
                {
                    break;
                }
        }
    } while (opcion < 5);
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