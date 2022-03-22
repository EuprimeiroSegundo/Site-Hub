using System.Runtime.Serialization;
using System;
using System.ComponentModel.DataAnnotations;


namespace Hub.Models
{
    [DataContract]
    public abstract class BaseModel
    {
        [DataMember]
        public int Id { get; set; }
    }

    public class CadastroUsuario : BaseModel{
        public CadastroUsuario(){}

        public CadastroUsuario(string nome, DateTime dataNascimento, string email, string senha, string cargo, string pronome)
        {
        }

        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        
        [Required]
        public string Email { get; set; }
        [Required]
        public string senha { get; set; }
        [Required]
        public string Cargo { get; set; }
        [Required]
        public string Pronome { get; set; }

    }
}