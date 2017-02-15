using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;
using NHibernate.Expression;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHibernateDao<T> : IDao<T>
    {

        public void SaveOrUpdate(T t)
        {
            ISession session = NHibernateHelper.OpenSession();
            using (ITransaction trans = session.BeginTransaction())
            {
                session.SaveOrUpdate(t);
                session.Flush();
                trans.Commit();
            }
            //session.Flush();
        }

        public void Delete(T t)
        {
            ISession session = NHibernateHelper.OpenSession();

            using (ITransaction trans = session.BeginTransaction())
            {
                session.Delete(t);
                session.Flush();
                trans.Commit();
            }
            
        }

        public IList<T> GetAll()
        {
            return NHibernateHelper.OpenSession().CreateCriteria(typeof(T)).List<T>();
            //return GetByCriteria(null);
        }

        public IList<T> GetByCriteria(params string[] sortProperties)
        {
            ISession session = NHibernateHelper.OpenSession();
            ICriteria crit = session.CreateCriteria(typeof(T));
            if (sortProperties != null)
            {
                foreach (string sortProperty in sortProperties)
                {
                    crit.AddOrder(Order.Asc(sortProperty));
                }
            }

            return crit.List<T>();
        }

        public T GetById(int id)
        {
            ISession session = NHibernateHelper.OpenSession();
                return (T)session.Get(typeof(T), id);
            
        }

        public T Load(int id)
        {
            ISession session = NHibernateHelper.OpenSession();
                return (T)session.Load(typeof(T), id);
        }

        public List<T> ListUsingQuery(string hql, params object[] args)
        {
            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            
            
            return (List<T>)q.List<T>();
        }

        public IList<T> ListUsingSQLQuery(string hql)
        {
            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateSQLQuery(hql);

            return q.List<T>();
        }
    }
}
