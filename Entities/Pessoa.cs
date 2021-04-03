
using System;
using System.ComponentModel.DataAnnotations;

namespace cad_pessoa_blazor.Entities
{
    public class Pessoa
    {
        public Pessoa()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [MaxLength(200)]
        public string NomePessoa { get; set; }
        [MaxLength(20)]
        public string Telefone { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
    }
}