using Domain.Common;
using System.Linq.Expressions;

namespace Repository.Repositories.Interfaces
{
    public interface IBaseRepositoy<T> where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        void Edit (T entity);
        T GetById(int id);
        List<T> GetAll();
        List<T> GetdAllByExpression(Expression<Func<T, bool>> expression);
    }
}
