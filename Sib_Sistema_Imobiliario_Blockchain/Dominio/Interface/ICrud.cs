using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sib_Sistema_Imobiliario_Blockchain.Dominio.Interface
{
    public interface ICrud<T>
    {
        void Adicionar(T objeto);        
        void RemoverLog(T objeto);
        void Remover(T objeto);
        void Atualizar(T objeto);
        T PesquisarPorPK(T obj);
        IList<T> Listar();
    }
}
