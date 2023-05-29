using System;
using System.Collections.Concurrent;

namespace AlokatuUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> almacenPrincipal = new BlockingCollection<int>(100);
            BlockingCollection<int> almacenSecundario = new BlockingCollection<int>(100);
            bool finAlquiler = false;

            // Tarea consumidor desde Gros
            Task tareaGros = Task.Run(() =>
            {
                // Se muestra el mensaje de inicio de alquiler en la Zona de Gros
                Console.WriteLine("*****************************************\n" +
                                  "* INICIO DE ALQUILER EN LA ZONA DE GROS *\n" +
                                  "*****************************************\n\n");

                while (!finAlquiler) // Chequea si se ha terminado el terminado el tiempo de alquiler
                {
                    // Si se ha terminado la fabricación de bicicletas y vaciado el almacen principal, se marca el fin del tiempo de alquiler
                    if (almacenPrincipal.IsAddingCompleted && almacenPrincipal.Count() == 0)
                    {
                        finAlquiler = true;
                    }
                    else
                    {
                        // Se inicializa a -1 el número de la bicicleta a alquilar
                        int numeroBicicleta = -1;

                        // Si no hay bicicleta para alquilar en el almacen principal se queda a la espera
                        try
                        {
                            Thread.Sleep(100);
                            // Se coge para alquilar la primera bicicleta que esté disponible del almacen principal
                            numeroBicicleta = almacenPrincipal.Take();
                        }
                        catch (InvalidOperationException) { }

                        // Si se ha cogido bicicleta para alquilar se muestra el mensaje
                        if (numeroBicicleta != -1)
                        {
                            Console.WriteLine("ALQUILER:    Bicicleta número {0} alquilada en la Zona de Gros\n" +
                                              "STOCK:       Número de bicicletas actualmente en almacen principal: {1}\n\n", numeroBicicleta, almacenPrincipal.Count());

                            if (numeroBicicleta % 3 == 0) // Se comprueba si el número de bicicleta es múltiplo de 3 para devolverla
                            {
                                // Se chequea si el almacen principal está completado para, en ese caso, devolver la bicicleta al almacén secundario
                                if (almacenPrincipal.IsAddingCompleted) 
                                {
                                    try
                                    {
                                        almacenSecundario.Add(numeroBicicleta);
                                        Console.WriteLine("DEVOLUCION:  Bicicleta número {0} devuelta al almacen secundario desde la Zona de Gros\n" +
                                                          "STOCK:       Número de bicicletas actualmente en almacen secundario: {1}\n\n", numeroBicicleta, almacenSecundario.Count());
                                    }
                                    catch (InvalidOperationException) { }

                                }
                                else
                                {
                                    try
                                    {
                                        almacenPrincipal.Add(numeroBicicleta);
                                        Console.WriteLine("DEVOLUCION:  Bicicleta número {0} devuelta al almacen principal desde la Zona de Gros\n" +
                                                          "STOCK:       Número de bicicletas actualmente en almacen principal: {1}\n\n", numeroBicicleta, almacenPrincipal.Count());
                                    }
                                    catch (InvalidOperationException) { }
                                }                      
                            }
                        }
                    }
                }

            });


            // Tarea consumidor desde Amara
            // Esta tarea es similar a tareaGros pero sin devoluciones de bicicletas
            Task tareaAmara = Task.Run(() =>
            {
                // Se muestra el mensaje de inicio de alquiler en la Zona de Amara
                Console.WriteLine("******************************************\n" +
                                  "* INICIO DE ALQUILER EN LA ZONA DE AMARA *\n" +
                                  "******************************************\n\n");

                while (!finAlquiler) 
                {
                    if (almacenPrincipal.IsAddingCompleted && almacenPrincipal.Count() == 0)
                    {
                        finAlquiler = true;
                    }
                    else
                    {
                        int numeroBicicleta = -1;

                        try
                        {
                            Thread.Sleep(100);
                            numeroBicicleta = almacenPrincipal.Take();
                        }
                        catch (InvalidOperationException) { }

                        if (numeroBicicleta != -1)
                        {
                            Console.WriteLine("ALQUILER:    Bicicleta número {0} alquilada en la Zona de Amara\n" +
                                              "STOCK:       Número de bicicletas actualmente en almacen principal: {1}\n\n", numeroBicicleta, almacenPrincipal.Count());
                        }
                    }
                }
            });


            // Tarea productor que creará 200 bicicletas y las dejará en el almacen principal
            Task tareaProductor = Task.Run(() =>
            {
                int numeroBicicleta = 1;
                bool anadirBicicleta = true;

                // Se muestra el mensaje de inicio de la fabricación de bicicletas
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("* INICIO DE LA FABRICACION Y ENVIO DE BICICLETAS AL ALMACEN PRINCIPAL *");
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("");

                //Mientras haya una bicicleta por añadir (menos de 200) entra dentro del bucle
                while (anadirBicicleta)
                {
                    // Añadimos una bicicleta al almacén
                    almacenPrincipal.Add(numeroBicicleta);
                    Console.WriteLine("FABRICACION: Bicicleta número {0} enviada y añadida al almacén Principal\n" +
                                      "STOCK:       Número de bicicletas actualmente en almacen principal: {1}\n\n", numeroBicicleta, almacenPrincipal.Count());

                    // Se incrementa el índice de bicicleta
                    numeroBicicleta++;

                    if (numeroBicicleta == 201) // Se chequea si se han fabricado las 200 bicicletas
                    {
                        // Se ha fabricado la última bicicleta
                        anadirBicicleta = false;
                    }

                }
                // Se marca el fin de la fabricación de bicicletas marcando el almacen principal como cerrado
                almacenPrincipal.CompleteAdding();
                Console.WriteLine("********************************************************************\n" +
                                  "* FIN DE LA FABRICACION Y ENVIO DE BICICLETAS AL ALMACEN PRINCIPAL *\n" +
                                  "********************************************************************\n\n");
            });

            tareaGros.Wait();
            tareaAmara.Wait();
            tareaProductor.Wait();

            // Se muestra el estado de los almacenes al finalizar
            Console.WriteLine("*********************************************");
            Console.WriteLine("* FIN DEL PERIODO DE ALQUILER DE BICICLETAS *");
            Console.WriteLine("*********************************************");
            Console.WriteLine("");
            Console.WriteLine("STOCK ACTUAL DEL ALMACEN PRINCIPAL:  " + almacenPrincipal.Count());
            Console.WriteLine("STOCK ACTUAL DEL ALMACEN SECUNDARIO: " + almacenSecundario.Count());
            Console.WriteLine("");
        }
    }
}
