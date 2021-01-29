using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TISelvagem.Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Preencha o nome do Usuario")]
        public string Nome { get; set; }
        
        
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Preencha a data de nascimento do Usuario")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o Telefone do Usuario")]
        public string Telefone { get; set; }

        [Required(ErrorMessage =" Inserir o numero  do celular")]
        public string Celular { get; set; }


        [Required(ErrorMessage = "Preencha o Email do Usuario")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Inserir a senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Preencha o endereço do Usuario")]
        public string Endereco { get; set; }

        /// esse campo é uma FK<summary>
        ///  public int IdTipoUsuario { get; set; }
        /// </summary>


    }
}
