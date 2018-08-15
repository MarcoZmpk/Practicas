using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    class Program
    {
        enum TIPOSDECOMIDA { CROQUETAS, BASURA, AGUA }

        static void Main(string[] args)
        {
            bool aliementado = false;

            Perro Perro1 = new Perro();

            Perro1.Raza = "French Puddle";
            Perro1.Peso |= 7;
            Perro1.Sexo = "Macho";
            Perro1.Tamaño = "Pequeña";

            aliementado = Perro1.Comer((int)TIPOSDECOMIDA.BASURA);

            if (aliementado)
            {
                Console.WriteLine("El Perro " + Perro1.Raza + "comió " + Convert.ToString(TIPOSDECOMIDA.AGUA));
            }
            else
            {
                Console.WriteLine("El perro no ha sido alimentado");
            }
            Console.Read();

            Perro Perro2 = new Perro();
            Console.WriteLine("El Perro " + Perro2.Raza + "comió " + Convert.ToString(TIPOSDECOMIDA.AGUA));
            Console.Read();
        }
    }
}
