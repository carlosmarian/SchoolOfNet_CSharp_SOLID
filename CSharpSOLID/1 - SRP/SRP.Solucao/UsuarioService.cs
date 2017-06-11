using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSOLID._1___SRP.SRP.Solucao
{
    public class UsuarioService
    {
        public string AdicionarUsuario(Usuario usuario)
        {
            if (!usuario.IsValid())
                return "Dados inválidos";

            var repo = new UsuarioRepository();
            repo.AdicionarUsuario(usuario);

            EmailServices.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Usuário cadastrado com sucesso";
        }
    }
}
