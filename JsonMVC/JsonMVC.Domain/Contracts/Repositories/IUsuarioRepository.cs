using System;
using System.Collections.Generic;
using JsonMVC.Domain.Model;

namespace JsonMVC.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario Get(int id);
        Usuario GetEmail(string email);
        List<Usuario> Get();
        bool Create(Usuario usuario);
    }
}
