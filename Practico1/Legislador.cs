using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Legislador
    {
        protected string PartidoPolitico;
        protected string DepRepresenta;
        protected int NumDespacho;
        protected string Nombre;
        protected string Apellido;
        protected int Edad;
        protected bool Casado;
        protected string Camara;

        public Legislador()
        {
            PartidoPolitico = "ninguno";
            DepRepresenta = "ninguno";
            NumDespacho = 0;
            Nombre = "ninguno";
            Apellido = "ninguno";
            Edad = 0;
            Casado = false;
            Camara = "ninguna";
        }
        public Legislador(string PartidoPolitico, string DepRepresenta, int NumDespacho, string Nombre, string Apellido, int Edad, bool Casado, string Camara)
        {
            this.PartidoPolitico = PartidoPolitico;
            this.DepRepresenta = DepRepresenta;
            this.NumDespacho = NumDespacho;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Casado = Casado;
            this.Camara = Camara;
        }

        public string GetPartidoPol() => this.PartidoPolitico;
        public string GetDepRepresenta() => this.DepRepresenta;
        public int GetNumDespacho() => this.NumDespacho;
        public string GetNombre() => this.Nombre;
        public string GetApellido() => this.Apellido;
        public int GetEdad() => this.Edad;
        public bool GetCasado() => this.Casado;
        public string GetCamara() => this.Camara;

        public void SetPartidoPol(string PartidoPolitico) => this.PartidoPolitico = PartidoPolitico;
        public void SetDepRepresenta(string DepRepresenta) => this.DepRepresenta = DepRepresenta;
        public void SetNumDespacho(int NumDespacho) => this.NumDespacho = NumDespacho;
        public void SetNombre(string Nombre) => this.Nombre = Nombre;
        public void SetApellido(string Apellido) => this.Apellido = Apellido;
        public void SetEdad(int Edad) => this.Edad = Edad;
        public void SetCasado(bool Casado) => this.Casado = Casado;
        public void SetCamara(string Camara) => this.Camara = Camara;

        public virtual void PresentarPropuesta(string Nombre)
        {
            
        }
        public virtual void Votar(string Nombre)
        {
            
        }
        public virtual void ParticiparDebate(string Nombre)
        {
           
        }
    }
    
}
