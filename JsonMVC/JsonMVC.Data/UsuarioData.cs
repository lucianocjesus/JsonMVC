using System.Collections.Generic;
using JsonMVC.Domain.Contracts.Repositories;
using JsonMVC.Domain.Model;

namespace JsonMVC.Data
{
    public class UsuarioData : IUsuarioRepository
    {
        public Usuario Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Usuario GetEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public List<Usuario> Get()
        {
            throw new System.NotImplementedException();
        }

        public bool Create(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
