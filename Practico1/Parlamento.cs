using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Parlamento
    {
        List<Legislador> Legisladores;

        public Parlamento()
        {
            Legisladores = new List<Legislador>();
        }

        List<Legislador> senadores = new List<Legislador>();
        List<Legislador> diputados = new List<Legislador>();
        public void RegistrarLegislador(Legislador legislador)
        {
            Legisladores.Add(legislador);
            
            if (legislador.GetCamara() == "Senador")
            {
                senadores.Add(legislador);
            }
            else
            {
                diputados.Add(legislador);
            }
        }

        
        public void ListarCamaras()
        {

            Console.WriteLine("Senadores:");
            foreach (Legislador senador in senadores)
            {
                Console.WriteLine("Numero de despacho:" + " " + senador.GetNumDespacho() + " " + "Camara a la cual representa:" + " " + senador.GetCamara());
            }
            Console.WriteLine("Diputados:");
            foreach (Legislador diputado in diputados)
            {
                Console.WriteLine("Numero de despacho:" + " " + diputado.GetNumDespacho() + " " + "Camara a la cual representa:" + " " + diputado.GetCamara());
            }

        }

        public void CantidadLegisladores()
        {

            int senadore = 0;
            int diputado = 0;
            foreach (Legislador legislador in Legisladores)
            {
                if (legislador.GetCamara() == "Senador")
                {
                    senadore++;
                }
                else
                {
                    diputado++;
                }
            }

            Console.WriteLine("Senadores:" + " " + senadore + " " + "Diputados:" + " " + diputado);

        }

        public void PresentarPro(int cam)
        {
            if(cam == 1)
            {
                int num = 0;
                foreach (Legislador senador in senadores)
                {
                    Console.WriteLine(num + "." + senador.GetNombre());
                    num++;
                }

                int nombr = 0;

                do
                {
                    Console.WriteLine("introdusca el numero correspondiente al nombre");

                } while (Int32.TryParse(Console.ReadLine(), out nombr)== false);
                
                string Nombre = senadores[nombr].GetNombre();
                senadores[nombr].PresentarPropuesta(Nombre);

            }

            if (cam == 2)
            {
                int num = 0;
                foreach (Legislador diputado in diputados)
                {
                    Console.WriteLine(num + "." + diputado.GetNombre());
                    num++;
                }

                int nombr = 0;

                do
                {
                    Console.WriteLine("introdusca el numero correspondiente al nombre");

                } while (Int32.TryParse(Console.ReadLine(), out nombr) == false);

                string Nombre = diputados[nombr].GetNombre();
                diputados[nombr].PresentarPropuesta(Nombre);

            }
        }

        public void PresentarVoto(int cam)
        {
            if (cam == 1)
            {
                int num = 0;
                foreach (Legislador senador in senadores)
                {
                    Console.WriteLine(num + "." + senador.GetNombre());
                    num++;
                }

                int nombr = 0;

                do
                {
                    Console.WriteLine("introdusca el numero correspondiente al nombre");

                } while (Int32.TryParse(Console.ReadLine(), out nombr) == false);

                string Nombre = senadores[nombr].GetNombre();
                senadores[nombr].Votar(Nombre);

            }

            if (cam == 2)
            {
                int num = 0;
                foreach (Legislador diputado in diputados)
                {
                    Console.WriteLine(num + "." + diputado.GetNombre());
                    num++;
                }

                int nombr = 0;

                do
                {
                    Console.WriteLine("introdusca el numero correspondiente al nombre");

                } while (Int32.TryParse(Console.ReadLine(), out nombr) == false);

                string Nombre = diputados[nombr].GetNombre();
                diputados[nombr].Votar(Nombre);

            }
        }

        public void ParticiparDeb(int cam)
        {
            if (cam == 1)
            {
                int num = 0;
                foreach (Legislador senador in senadores)
                {
                    Console.WriteLine(num + "." + senador.GetNombre());
                    num++;
                }

                int nombr = 0;

                do
                {
                    Console.WriteLine("introdusca el numero correspondiente al nombre");

                } while (Int32.TryParse(Console.ReadLine(), out nombr) == false);

                string Nombre = senadores[nombr].GetNombre();
                senadores[nombr].ParticiparDebate(Nombre);

            }

            if (cam == 2)
            {
                int num = 0;
                foreach (Legislador diputado in diputados)
                {
                    Console.WriteLine(num + "." + diputado.GetNombre());
                    num++;
                }

                int nombr = 0;

                do
                {
                    Console.WriteLine("introdusca el numero correspondiente al nombre");

                } while (Int32.TryParse(Console.ReadLine(), out nombr) == false);

                string Nombre = diputados[nombr].GetNombre();
                diputados[nombr].ParticiparDebate(Nombre);

            }
        }
    }
}
