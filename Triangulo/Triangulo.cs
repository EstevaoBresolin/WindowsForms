using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Triangulo
{
    public class Triangulo
    {


        public int VerificaTipo(int Lado1, int Lado2, int Lado3)
        {   
            int result = 0;
            if (Lado1 + Lado2 > Lado3 && Lado2 + Lado3 > Lado1 && Lado1 + Lado3 > Lado2)
            {

                if (Lado1 == Lado2 && Lado2 == Lado3) // equilatero
                {
                    result = 1;
                }

                else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3) // isóseceles
                {
                    result = 2;
                }

                else { result = 3; } //escaleno
            }
            else { MessageBox.Show("Não é um triangulo válido"); }
            return result;

        }


    }
}
