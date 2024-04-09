using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Dice
    {
        public Dice(int lados) 
        {
        
            Lados = lados;

        }

        //Atributos
        public int Lados { get; set; }
        
        public int Rolar()
        {           
            return new Random().Next(1,Lados);
        }


        //Metodos






    }
}
