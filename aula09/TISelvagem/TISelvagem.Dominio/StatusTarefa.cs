using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TISelvagem.Dominio
{
    public class StatusTarefa
    {
        public int IdStatusTarefa { get; set; }
        [Required(ErrorMessage = "Inserir uma descrição")]
        public string Descricao { get; set; }
        
 
    }
}
