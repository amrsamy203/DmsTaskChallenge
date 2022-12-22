using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DmsTaskChallenge.Repository.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
