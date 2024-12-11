using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresComparativos
{
    public class OutrosOperadores
    {
        public bool casalIsFoda ()
        {
            bool gabrielIsFoda = false;
            bool iasmimIsFoda = false;

            if (gabrielIsFoda && iasmimIsFoda)
            {
                Console.WriteLine("QUE CASAL FODA!");
                return true;
            }
            else if (gabrielIsFoda || iasmimIsFoda)
            {
                Console.WriteLine("UM DOS DOIS SÃO FODAS");
                return true;
            }
            Console.WriteLine("GABRIEL E IASMIM AINDA VÃO SER UM CASAL FODA");
            return false;
        }
    }
}
