using Infra.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class GeralRepository : IGeralRepository
    {
        public void Adicionar<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Atualizar<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Deletar<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
