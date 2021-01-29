using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TISelvagem.Dominio
{
    public class Tarefa
    {
        public int IdTarefa { get; set; }
   

        /// esse campo é uma FK<summary>
        ///  public int IdUsuario { get; set; }
        /// </summary>
        

        

        [DisplayName("decrição tarefa")]
        [Required(ErrorMessage = "Inserir a descrição da tarefa")]
        public string Descricao { get; set; }  

        [DisplayName("Data de Atribuição")]
        [Required(ErrorMessage = "Preencha a data da atribuição da tarefa")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataAtribuicaoTarefa { get; set; }

        [DisplayName("Data da conclusão da tarefa")]
        [Required(ErrorMessage = "Preencha a data de conclusao da tarefa")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataConclusaoTarefa { get; set; }
    }
}
