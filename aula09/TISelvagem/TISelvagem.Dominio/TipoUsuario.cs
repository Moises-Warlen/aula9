using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TISelvagem.Dominio
{
    public class TipoUsuario
    {
        public int IdTipoUsuario { get; set; }
        [Required(ErrorMessage = "Insira uma descrição")]
        public string Descricao { get; set; }
        
       
    }
}
