using System.ComponentModel;

namespace JsonMVC.Web.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        [DisplayName("RG")]
        public string DocumentoRg { get; set; }
        [DisplayName("CPF")]
        public string DocumentoCpf { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
}