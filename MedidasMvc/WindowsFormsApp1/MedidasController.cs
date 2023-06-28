using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MedidasController
    {
        MedidasModel model;
        IConverterView medidasView;

        public MedidasController(IConverterView _view, MedidasModel _model)
        {
            model = _model;
            medidasView = _view;
            medidasView.SetController(this);
        }

        public void Converter(int medida)
        {
            double resultado = 0;
            double valor = double.Parse(medidasView.Valor);
            resultado = this.model.Converter(valor, medida);
            medidasView.Resultado = resultado.ToString();

        }
    }
}
