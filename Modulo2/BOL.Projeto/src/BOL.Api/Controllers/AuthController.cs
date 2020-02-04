using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Api.ViewModel;
using BOL.Busines.Notificações;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BOL.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    public class AuthController : MainController
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SettingsJWT _settingsJWT;
        public AuthController
        (
            INotificador notificador, 
            SignInManager<IdentityUser> signInManager, 
            UserManager<IdentityUser> userManager,
            IOptions<SettingsJWT> settingsJWT
        ) :base(notificador)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _settingsJWT = settingsJWT.Value;
        }

        [HttpPost("registrar")]
        [AllowAnonymous]
        public async Task<ActionResult> Registrar(RegistrarViewModel registrar)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var user = new IdentityUser
            {
                UserName = registrar.Login
            };

            var result = await _userManager.CreateAsync(user, registrar.Senha);

            if (result.Succeeded)
            {
                return Result("Usuário criado com sucesso!");
            }
            foreach (var erro in result.Errors)
            {
                NotificarErro(erro.Description);
            }

            return Result();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var result = await _signInManager.PasswordSignInAsync(login.Login, login.Senha, false, true);

            if (result.Succeeded)
            {
                return Result(GerarToken());
            }

            if (result.IsLockedOut)
            {
                NotificarErro("Usuário temporáriamente bloqueado por excesso de tentativas!");
            }
            else
            {
                NotificarErro("Login e/ou senha inválido!");
            }

            return Result();
        }

        private string GerarToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_settingsJWT.Secret);

            var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _settingsJWT.Emissor,
                Audience = _settingsJWT.ValidoEm,
                Expires = DateTime.UtcNow.AddHours(_settingsJWT.ExpiracaoHoras),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            });

            var encoderToken = tokenHandler.WriteToken(token);
            return encoderToken;
            //eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYmYiOjE1NzgzNTY1NjgsImV4cCI6MTU3ODM2Mzc2OCwiaWF0IjoxNTc4MzU2NTY4LCJpc3MiOiJCT0wuQXBpIiwiYXVkIjoiaHR0cHM6Ly9Mb2NhbGhvc3QifQ.God9APBs_t9hI9mtfMBfTlEyFU0x2KY61vnveKI8_vk
        }
    }
}