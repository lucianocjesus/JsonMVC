using System.Collections.Generic;
using JsonMVC.Domain.Model;

namespace JsonMVC.Domain.Contracts.Services
{
    public interface IUsuarioService
    {
        List<Usuario> Get();
        bool Create(Usuario usuario);
    }
}
