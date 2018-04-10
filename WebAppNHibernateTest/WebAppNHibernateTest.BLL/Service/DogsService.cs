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
    public class DogsService
    {
        public void Create(Dogs model)
        {

            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(model);
                tx.Commit();
                NHibernateHelper.CloseSession();
            }
        }

        public IList<Dogs> Query(string name)
        {
            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                ITransaction tx = session.BeginTransaction();
                IQuery query = session.CreateQuery("select c from Dogs as c where c.Name = :name");
                // query.SetCharacter("sex", 'F');
                query.SetString("name", name);
                var lists = query.List<Dogs>();
                tx.Commit();
                return lists;
            }
        }

    }
}
