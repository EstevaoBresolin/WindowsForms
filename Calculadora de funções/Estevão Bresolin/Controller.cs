using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estevão_Bresolin
{
    public class Controller
    {
        Calcula_Fracoes_Model model;
        ICalculaFracao view;

        public Controller(ICalculaFracao _view, Calcula_Fracoes_Model _model)
        {
            model = _model;
            view = _view;
            view.SetController(this);
        }
        public void CalcularNumerador(int operacao)
        {
            int resultadoNumerador = 0;            
            int numerador1 = int.Parse(view.Numerador1);
            int numerador2 = int.Parse(view.Numerador2);
            int denominador1 = int.Parse(view.Denominador1);
            int denominador2 = int.Parse(view.Denominador2);
            resultadoNumerador = this.model.CalcularNumerador(numerador1,numerador2,denominador1,denominador2,operacao);
            view.ResultadoNumerador = resultadoNumerador.ToString();

        }
        public void CalcularDenominador(int operacao)
        {
            int resultadoDenominador = 0;
            int numerador1 = int.Parse(view.Numerador1);
            int numerador2 = int.Parse(view.Numerador2);
            int denominador1 = int.Parse(view.Denominador1);
            int denominador2 = int.Parse(view.Denominador2);
            resultadoDenominador = this.model.CalcularDenominador(numerador1, numerador2, denominador1, denominador2, operacao);
            view.ResultadoDenominador = resultadoDenominador.ToString();

        }
    }
}
