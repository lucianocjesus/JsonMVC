using System.ComponentModel;

namespace JsonMVC.Web.Models
{
    public class NomeViewModel
    {
        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Sobrenome")]
        public string LastName { get; set; }
    }
}