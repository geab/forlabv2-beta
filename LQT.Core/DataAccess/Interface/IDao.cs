using System;
using System.Collections.Generic;


namespace LQT.Core.DataAccess.Interface
{
    public interface IDao<T>
    {
        void SaveOrUpdate(T t);
        void Delete(T t);
        IList<T> GetAll();
        T GetById(int id);
        T Load(int id);
        List<T> ListUsingQuery(string hql, params object[] args);
        IList<T> ListUsingSQLQuery(string hql);
    }
}
