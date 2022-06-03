using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuario.Clases
{
    //poner publica
     public class Coche
    {
        //por defecto es privada, mejor poner publico al menos en el examen
        public string matricula { get; set;}
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int cilindrada { get; set; }

        //constructor vacio si serializo o deserelializo
        public Coche()
        {
        }

        public Coche(string matricula, string marca, string modelo, string color, int cilindrada)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.cilindrada = cilindrada;
        }

        



    }
}
