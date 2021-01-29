using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TISelvagem.Dominio;
using TiSelvagem.Repositorio;

namespace TISelvagem.Aplicacao
{
    public class LoginAplicacao
    {
        private readonly LoginRepositorioADO repositorio;

        public LoginAplicacao()
        {
            repositorio = new LoginRepositorioADO();
        }

      
        public Login Login(string Email ,string senha)
        {

            return repositorio.Login(Email, senha);


        }
    }
}
