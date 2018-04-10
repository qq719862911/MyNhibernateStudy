using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppNHibernateTest.BLL.Dal;
using WebAppNHibernateTest.Model;

namespace WebAppNHibernateTest.BLL.Service
{
    public class HostsService
    {
        public string Create(Hosts model)
        {
            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                ITransaction tx = session.BeginTransaction();

                string newId = (string)session.Save(model);
                tx.Commit();
                NHibernateHelper.CloseSession();
                return newId;
            }
        }

        public void Update(Hosts model)
        {
            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                session.Update(model);
                session.Flush();
                NHibernateHelper.CloseSession();
            }
        }
        public void SaveOrUpdate(IList<Hosts> models)
        {
            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                foreach (var model in models)
                {
                    session.SaveOrUpdate(model);
                }
                session.Flush();
                NHibernateHelper.CloseSession();
            }
        }
        public void Delete(Hosts model)
        {
            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                session.Delete(model);
                session.Flush();
            }
        }

        public IList<Hosts> GetAll()
        {
            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                //select c from Hosts as c
                IQuery query = session.CreateQuery("select c from Hosts as c");
                var lists = query.List<Hosts>();
                return lists;
            }
        }
        public IList<Hosts> Query(string name)
        {
            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                ITransaction tx = session.BeginTransaction();
                IQuery query = session.CreateQuery("select c from Hosts as c where c.Name = :name");
                // query.SetCharacter("sex", 'F');
                query.SetString("name", name);
                var lists = query.List<Hosts>();
                tx.Commit();
                return lists;
            }
        }
    }
}
