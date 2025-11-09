using System.Linq.Expressions;

namespace _3DPrintCostEstimator.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T? GetFirstOrDefault(Expression<Func<T, bool>> filter);
        IEnumerable<T>? GetAll();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void RemoveList(IEnumerable<T> entity);
        void RemoveAll();
    }
}
