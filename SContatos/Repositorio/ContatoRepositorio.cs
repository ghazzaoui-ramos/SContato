using SContatos.Data;
using SContatos.Models;
using System.Linq;

namespace SContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {

        private readonly BancoContext _Context;

        public ContatoRepositorio(BancoContext bancoContext) 
        {
            _Context = bancoContext;
        }

        public ContatoModel ListarPorID(int id)
        {
            return _Context.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
           return _Context.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _Context.Contatos.Add(contato);
            _Context.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorID(contato.Id);

            if (contatoDB == null) throw new System.Exception("Houve um na atualizarçao do contato!");

           // contatoDB.Id = contato.Id;
            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _Context.Contatos.Update(contatoDB);
            _Context.SaveChanges();

            return contatoDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorID(id);

            if (contatoDB == null) throw new System.Exception("Houve um na error na deleçao do contato");
            _Context.Contatos.Remove(contatoDB);
            _Context.SaveChanges();

            return true;    

        }
    }
}
