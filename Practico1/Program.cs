using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Parlamento parlamento = new Parlamento();

            int menu = 0;
            int NumCamaraBaja = 0;
            int NumCamaraAlta = 0;
            while (menu != 7)
            {
              
                do
                {
                    Console.WriteLine("Eliga una opcion");
                    Console.WriteLine("1.Registrar Legislador");
                    Console.WriteLine("2.Lista Camara");
                    Console.WriteLine("3.Conteo Legisladores");
                    Console.WriteLine("4.Propuesta Legislativa");
                    Console.WriteLine("5.Votar");
                    Console.WriteLine("6.Ingresar a debate");
                    Console.WriteLine("7.Salir");
                } while (Int32.TryParse(Console.ReadLine(), out menu) == false || menu < 1 || menu > 7);

                if (menu == 1) 
                {

                    int Legislador = 0;

                    do
                    {
                        Console.WriteLine("Crearas un Legislador");
                        Console.WriteLine("1.Diputado");
                        Console.WriteLine("2.Senador");

                    } while (Int32.TryParse(Console.ReadLine(), out Legislador) == false || Legislador > 2 || Legislador < 1);
                    
                    if (Legislador == 1)
                    {
                        Console.WriteLine("ingrese partido politico");
                        string PartidoPolitico = Console.ReadLine();

                        Console.WriteLine("ingrese departamento al cual representa");
                        string DepRepresenta = Console.ReadLine();

                        Console.WriteLine("ingrese el numero de despacho");
                        int NumDespacho = 0;
                        while (Int32.TryParse(Console.ReadLine(), out NumDespacho) == false || NumDespacho <= -1)
                        {
                            Console.WriteLine("ingrese el numero de despacho correctamente");
                        }
                        
                        Console.WriteLine("ingrese el nombre");
                        string Nombre = Console.ReadLine();

                        Console.WriteLine("ingrese apellido");
                        string Apellido = Console.ReadLine();

                        Console.WriteLine("ingrese edad");
                        int Edad = 0;
                        while (Int32.TryParse(Console.ReadLine(), out Edad) == false || Edad > 125 || Edad < 18)
                        {
                            Console.WriteLine("Ingrese edad del Diputado");
                        }

                        bool Casado = false;
                        string confiramarcasado = "";
                        while (confiramarcasado != "S" && confiramarcasado != "N" && confiramarcasado != "s" && confiramarcasado != "n")
                        {
                            Console.WriteLine("Escriba S para confirmar que esta casado, de lo contrario escriba N");
                            confiramarcasado = Console.ReadLine();
                        }
                        
                        if (confiramarcasado == "S" || confiramarcasado == "s")
                        {
                            Casado = true;
                        }

                        else if(confiramarcasado == "N" || confiramarcasado == "n")
                        {
                            Casado = false;
                        }

                        string Camara = "Diputado";

                        int NumAsientoCamaraBaja = NumCamaraBaja;
                        NumCamaraBaja++;
                        Diputado diputado = new Diputado(PartidoPolitico, DepRepresenta, NumDespacho, Nombre, Apellido, Edad, Casado, Camara, NumAsientoCamaraBaja);
                        parlamento.RegistrarLegislador(diputado);
                    }

                    if (Legislador == 2)
                    {
                        Console.WriteLine("ingrese partido politico");
                        string PartidoPolitico = Console.ReadLine();

                        Console.WriteLine("ingrese departamento al cual representa");
                        string DepRepresenta = Console.ReadLine();

                        Console.WriteLine("ingrese el numero de despacho");
                        int NumDespacho = 0;
                        while (Int32.TryParse(Console.ReadLine(), out NumDespacho) == false || NumDespacho <= -1)
                        {
                            Console.WriteLine("ingrese el numero de despacho correctamente");
                        }

                        Console.WriteLine("ingrese el nombre");
                        string Nombre = Console.ReadLine();

                        Console.WriteLine("ingrese apellido");
                        string Apellido = Console.ReadLine();

                        Console.WriteLine("ingrese edad");
                        int Edad = 0;
                        while (Int32.TryParse(Console.ReadLine(), out Edad) == false || Edad > 125 || Edad < 18)
                        {
                            Console.WriteLine("Ingrese edad del Senador");
                        }

                        bool Casado = false;
                        string confiramarcasado = "";
                        while (confiramarcasado != "S" && confiramarcasado != "N" && confiramarcasado != "s" && confiramarcasado != "n")
                        {
                            Console.WriteLine("Escriba S para confirmar que esta casado, de lo contrario escriba N");
                            confiramarcasado = Console.ReadLine();
                        }

                        if (confiramarcasado == "S" || confiramarcasado == "s")
                        {
                            Casado = true;
                        }

                        else if (confiramarcasado == "N" || confiramarcasado == "n")
                        {
                            Casado = false;
                        }

                        string Camara = "Senador";

            
                        int NumAsientoCamaraAlta = NumCamaraAlta;

                        NumCamaraAlta++;
                        Senador senador = new Senador(PartidoPolitico, DepRepresenta, NumDespacho, Nombre, Apellido, Edad, Casado, Camara, NumAsientoCamaraAlta);
                        parlamento.RegistrarLegislador(senador);

                    }

                }

                if (menu == 2)
                {
                    parlamento.ListarCamaras();
                }

                if (menu == 3)
                {
                    parlamento.CantidadLegisladores();
                }

                if (menu == 4)
                {
                    int Camara = 0;
                    Console.WriteLine("seleccione una camara");
                    do
                    {

                        Console.WriteLine("1.Diputado");
                        Console.WriteLine("2.Senador");

                    } while (Int32.TryParse(Console.ReadLine(), out Camara) == false || Camara > 2 || Camara < 1);
                    parlamento.PresentarPro(Camara);
                }

                if(menu == 5)
                {
                    int Camara = 0;
                    Console.WriteLine("seleccione una camara");
                    do
                    {

                        Console.WriteLine("1.Diputado");
                        Console.WriteLine("2.Senador");

                    } while (Int32.TryParse(Console.ReadLine(), out Camara) == false || Camara > 2 || Camara < 1);
                    parlamento.PresentarVoto(Camara);
                }

                if (menu == 6)
                {
                    int Camara = 0;
                    Console.WriteLine("seleccione una camara");
                    do
                    {

                        Console.WriteLine("1.Diputado");
                        Console.WriteLine("2.Senador");

                    } while (Int32.TryParse(Console.ReadLine(), out Camara) == false || Camara > 2 || Camara < 1);
                    parlamento.ParticiparDeb(Camara);
                }

                

             
            }
            
            

        }
    }
}
