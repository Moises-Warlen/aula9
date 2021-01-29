using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TISelvagem.Dominio;

namespace TiSelvagem.Repositorio
{
    public class LoginRepositorioADO
    {

        private Contexto contexto;



        public Login Login(string Email, string senha)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format(" SELECT * FROM Usuario WHERE  Email  =  {0} and Senha = {1}", Email, senha);
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);

                var temObjeto = new Login();

                if (retornoDataReader.Read())
                {
                    temObjeto = new Login()
                    {
                        Senha = retornoDataReader["Senha"].ToString(),
                        Email = retornoDataReader["Email"].ToString()

                    };

                }
                retornoDataReader.Close();

                return temObjeto;


              }



        }
       


    }
}