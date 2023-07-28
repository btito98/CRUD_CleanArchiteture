using Clinica.Application.Interfaces;
using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clinica.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMedicoRepository _medicoRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ISessao _sessao;

        public LoginController(IUsuarioRepository usuarioRepository, IMedicoRepository medicoRepository, ISessao sessao)
        {
            _usuarioRepository = usuarioRepository;
            _medicoRepository = medicoRepository;
            _sessao = sessao;
        }
        public IActionResult Index()
        {
            if (_sessao.BuscarSessaoUsuario() != null) return RedirectToAction("Index", "Home");
            return View();
        }
        [HttpPost]
        public IActionResult Entrar(Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Usuario usuario = _usuarioRepository.BuscarLogin(login.LoginNome);
                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(login.Senha))
                        {
                            _sessao.CriarSessaoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Senha inválida. Verifique e tente novamente";
                    }
                    TempData["MensagemErro"] = $"Login e/ou senha inválido(s). Verifique as informações e tente novamente";
                }
                return View("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Ocorreu um erro ao realizar o login, detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Sair()
        {            
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }
    }
}
