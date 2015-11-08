using semanaTec.Aplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semanaTec.Metodos
{
    public class vinculaObjeto
    {
        public BindingSource vincula(string itemCB)
        {
            eventoAplicacao evento = new eventoAplicacao();
            BindingSource novoEvento = new BindingSource();
            novoEvento.Add(evento.selectDTWhere(itemCB));
            return novoEvento;
        }
    }
}
