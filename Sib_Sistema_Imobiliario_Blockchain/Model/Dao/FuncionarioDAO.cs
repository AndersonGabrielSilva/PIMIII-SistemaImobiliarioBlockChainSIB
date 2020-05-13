using Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades;
using Sib_Sistema_Imobiliario_Blockchain.Dominio.Interface;
using Sib_Sistema_Imobiliario_Blockchain.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sib_Sistema_Imobiliario_Blockchain.Model.Dao
{
    public class FuncionarioDAO : ICrud<Funcionario>
    {
        private Contexto contexto;
        public FuncionarioDAO()
        {
            contexto = new Contexto();
        }

        /// <summary>
        /// Adiciona um novo registro no Banco de Dados
        /// </summary>
        /// <param name="objeto"></param>
        public void Adicionar(Funcionario objeto)
        {
            contexto.Funcionario.Add(objeto);
            Console.WriteLine(contexto.ChangeTracker); 
            contexto.SaveChanges();
        }

        /// <summary>
        /// Atualiza o registro no Banco de dados
        /// </summary>
        /// <param name="objeto"></param>
        public void Atualizar(Funcionario objeto)
        {
            contexto.Funcionario.Attach(objeto);
            contexto.Entry(objeto).State = System.Data.Entity.EntityState.Modified;
            contexto.Entry(objeto.Cargo).State = System.Data.Entity.EntityState.Modified;
            contexto.Entry(objeto.TelefoneList.ElementAt(0)).State = System.Data.Entity.EntityState.Modified;
            contexto.Entry(objeto.TelefoneList.ElementAt(1)).State = System.Data.Entity.EntityState.Modified;
            contexto.Entry(objeto.EnderecoCliente).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();            
        }

        /// <summary>
        /// Select no Banco de Dados
        /// </summary>
        /// <returns></returns>
        public IList<Funcionario> Listar()
        {
            return contexto.Funcionario
           .Include("EnderecoCliente")
           .Include("Cargo")
           .Include("TelefoneList")
           .Where(x => x.Fg_Ativo != 0)           
           .ToList();
        }

        /// <summary>
        /// Pesquisa por Primary Key
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Funcionario PesquisarPorPK(Funcionario obj)
        {
            return contexto.Funcionario
                           .Find(obj.Cpf);
        }

        /// <summary>
        /// Remoção logiga, a tupla não será realmente deletada da tabela
        /// </summary>
        public void RemoverLog(Funcionario objeto)
        {
            contexto.Funcionario.Attach(objeto);
            contexto.Entry(objeto).State = System.Data.Entity.EntityState.Modified;
            contexto.Entry(objeto.Cargo).State = System.Data.Entity.EntityState.Modified;
            //contexto.Entry(objeto.Telefones).State = System.Data.Entity.EntityState.Modified;
            contexto.Entry(objeto.EnderecoCliente).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();

        }

        /// <summary>
        /// Remoção Total. O a tupla será realmente apagada do banco 
        /// </summary>
        /// <param name="objeto"></param>
        public void Remover(Funcionario objeto)
        {
            var RemoverCliente = contexto.Funcionario.Find(objeto.Cpf);

            contexto.Funcionario.Remove(RemoverCliente);
            contexto.SaveChanges();
        }
    }
}
