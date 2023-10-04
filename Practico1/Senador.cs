using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Senador:Legislador
    {
        private int NumAsientoCamaraAlta;
        

        public Senador(string PartidoPolitico, string DepRepresenta, int NumDespacho, string Nombre, string Apellido, int Edad, bool Casado, string Camara, int NumAsientoCamaraAlta) : base(PartidoPolitico, DepRepresenta, NumDespacho, Nombre, Apellido, Edad, Casado, Camara)
        {
            this.NumAsientoCamaraAlta = NumAsientoCamaraAlta;
        }
        public Senador()
        {
            
        }
        public int GetNumAsiento()
        {
            return NumAsientoCamaraAlta;
        }
        public void SetNumAsiento(int NumAsiento)
        {
            NumAsientoCamaraAlta = NumAsiento;
        }
        public override void PresentarPropuesta(string Nombre)
        {
            Console.WriteLine("El senador" + " " + Nombre + " " + "presentó una propuesta");
        }
        public override void Votar(string Nombre)
        {
            Console.WriteLine("El senador" + " " + Nombre + " " + "he votado");
        }
        public override void ParticiparDebate(string Nombre)
        {
            Console.WriteLine("El senador" + " " + Nombre + " " + "Participo en un debate");
        }
    }
}
