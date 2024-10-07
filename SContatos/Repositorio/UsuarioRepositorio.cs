using SContatos.Data;
using SContatos.Models;
using System.Linq;

namespace SContatos.Repositorio
{
    public class UsuarioRepositorio: IUsuarioRepositorio
    {

        private readonly BancoContext _Context;

        public UsuarioRepositorio(BancoContext bancoContext) 
        {
           _Context = bancoContext;
        }


        public UsuarioModel BuscarPorLogin(string login)
        {
            return _Context.Usuarios.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());
        }

        public UsuarioModel ListarPorID(int id)
        {
            return _Context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public List<UsuarioModel> BuscarTodos()
        {
           return _Context.Usuarios.ToList();
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            _Context.Usuarios.Add(usuario);
            _Context.SaveChanges();
            return usuario;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = ListarPorID(usuario.Id);

            if (usuarioDB == null) throw new System.Exception("Houve um na atualizarçao do usuario!");

            usuarioDB.Name = usuario.Name;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Login = usuario.Login;
            usuarioDB.perfil = usuario.perfil;
            usuarioDB.DataAtualizacao = DateTime.Now;
           
            _Context.Usuarios.Update(usuarioDB);
            _Context.SaveChanges();

            return usuarioDB;

        }

        public bool Apagar(int id)
        {
            UsuarioModel usuarioDB = ListarPorID(id);

            if (usuarioDB == null) throw new System.Exception("Houve um na error na deleçao do usuario");
            _Context.Usuarios.Remove(usuarioDB);
            _Context.SaveChanges();

            return true;    

        }

    }
}
