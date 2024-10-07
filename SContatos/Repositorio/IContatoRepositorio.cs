using SContatos.Models;

namespace SContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorID(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar (int id);
    }
}
