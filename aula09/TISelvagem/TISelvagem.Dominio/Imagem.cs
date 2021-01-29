using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TISelvagem.Dominio
{
    public class Imagem
    {
        public int IdImagem { get; set; }
       
        public string URL { get; set; }

        /// esse campo é uma FK<summary>
        ///  public int IdUsuario { get; set; }
        /// </summary>

    }
}
