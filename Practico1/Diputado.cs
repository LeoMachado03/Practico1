using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Diputado:Legislador
    {
        private int NumAsientoCamaraBaja;

        public Diputado(string PartidoPolitico, string DepRepresenta, int NumDespacho, string Nombre, string Apellido, int Edad, bool Casado, string Camara, int NumAsientoCamaraBaja):base(PartidoPolitico,  DepRepresenta,  NumDespacho,  Nombre,  Apellido,  Edad, Casado, Camara)
        {
            this.NumAsientoCamaraBaja = NumAsientoCamaraBaja;
        }
        public Diputado()
        {
                
        }
        public int getNumAsiento()
        {
            return NumAsientoCamaraBaja;
        }
        public void SetNumAsiento(int NumAsiento)
        {
            NumAsientoCamaraBaja = NumAsiento;
        }
        public override void PresentarPropuesta(string Nombre)
        {
            Console.WriteLine("El diputado" + " " + Nombre + " " + "presento una propuesta");
        }
        public override void Votar(string Nombre)
        {
            Console.WriteLine("El diputado" + " " + Nombre + " " + "ha votado");
        }
        public override void ParticiparDebate(string Nombre)
        {
            Console.WriteLine("El diputado" + " " + Nombre + " " + "Participó en un debate");
        }
    }
}
