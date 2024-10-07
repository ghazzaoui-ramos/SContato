using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SContatos.Models;
using SContatos.Repositorio;

namespace SContatos.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public LoginController(IUsuarioRepositorio usuarioRepositorio) 
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                     UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);

                    if (usuario != null)
                    {

                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"Senha do usuario invalida. por avor tente novamente.";
                    }

                    TempData["MensagemErro"] = $"Usuario e/ou senha invalido(s). por avor tente novamente.";

                }
                return View("index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login o, tente novamente, mas detalhes do erro:{erro.Message}";
                return RedirectToAction("index");
            }

        }
    }
}