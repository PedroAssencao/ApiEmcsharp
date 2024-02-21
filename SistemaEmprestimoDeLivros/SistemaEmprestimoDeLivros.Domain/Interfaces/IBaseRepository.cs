using SistemaEmprestimoDeLivros.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoDeLivros.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<List<T>> GetAll(Guid id, CancellationToken cancellationToken);
        Task<T> Get(Guid id, CancellationToken cancellationToken);

    }
}
