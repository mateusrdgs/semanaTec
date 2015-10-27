using semanaTec.Aplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semanaTec.Métodos_e_validações
{
    public class vinculaObjeto
    {
        public BindingSource vincula(string itemCB)
        {
            eventoAplicacao evento = new eventoAplicacao();
            BindingSource novoEvento = new BindingSource();
            novoEvento.Add(evento.selectEventoWhere(itemCB));
            return novoEvento;
        }
    }
}
