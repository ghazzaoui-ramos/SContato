using Microsoft.AspNetCore.Mvc;
using SContatos.Models;
using SContatos.Repositorio;

namespace SContatos.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuario = _usuarioRepositorio.BuscarTodos();

            return View(usuario);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorID(id);
            return View(usuario);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorID(id);
            return View(usuario);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _usuarioRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuario apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu usuraio, tente novamente";
                }

                return RedirectToAction("index");
            }

            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato, tente novamente, mas detalhes do erro:{erro.Message}";
                return RedirectToAction("index");
            }
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioRepositorio.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "Usuario cadrastrado com sucesso";
                    return RedirectToAction("index");
                }

                return View(usuario);
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu Usuario, tente novamente, detalhe do erro:{erro.Message}";
                return RedirectToAction("index");

            }
        }

        [HttpPost]
        public IActionResult Editar(UsuarioSemSenharModel usuarioSemSenharModel)
        {
            try
            {
                UsuarioModel  usuario = null;

                if (ModelState.IsValid)
                {
                    usuario = new UsuarioModel()
                    {
                        Id = usuarioSemSenharModel.Id,
                        Name = usuarioSemSenharModel.Name,
                        Login = usuarioSemSenharModel.Login,
                        Email = usuarioSemSenharModel.Email,
                        perfil = usuarioSemSenharModel.perfil,
                    };

                    usuario = _usuarioRepositorio.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Usuario alterado com sucesso";
                    return RedirectToAction("index");
                }

                return View("Editar", usuario);

            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu usuario, tente novamente, detalhe do erro:{erro.Message}";
                return RedirectToAction("index");

            }
        }
    }
}
