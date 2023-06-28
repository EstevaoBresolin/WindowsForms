using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estevão_Bresolin
{
    public interface ICalculaFracao
    {
        void SetController(Controller controller);

        string Numerador1 { get; set; }
        string Numerador2 { get; set; }

        string Denominador1 { get; set; }
        string Denominador2 { get; set; }

        string ResultadoNumerador { get; set; }
        string ResultadoDenominador { get; set; }
    }
}
