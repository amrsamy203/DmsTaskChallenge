using DmsTaskChallenge.Repository.Data;
using DmsTaskChallenge.Repository.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DmsChallenge.Repository.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DmsTaskChallengeContext _ctx;
        public Repository(DmsTaskChallengeContext context)
        {
            _ctx = context;
        }
        public T Add(T entity)
        {
            try
            {
                _ctx.Set<T>().Add(entity);
                _ctx.SaveChanges();
                return entity;
            } catch (Exception)
            {
                throw;
            }
            
        }

        public void Delete(T entity)
        {
            try 
            {
                _ctx.Set<T>().Remove(entity);
                _ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public IReadOnlyList<T> GetAll()
        {
            try
            {
                return _ctx.Set<T>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public T GetById(int id)
        {
            try
            { 
                return  _ctx.Set<T> ().Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public void Update(T entity)
        {
            try
            {
                _ctx.Set<T>().Update(entity);
                _ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
