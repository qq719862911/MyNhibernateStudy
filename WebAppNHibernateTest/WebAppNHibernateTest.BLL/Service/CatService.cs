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
    public class CatService
    {
        public void Create(Cat model)
        {

            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                ITransaction tx = session.BeginTransaction();
               
                session.Save(model);
                tx.Commit();
                NHibernateHelper.CloseSession();
            }
        }

        public IList<Cat> Query(string sex)
        {
            using (ISession session = NHibernateHelper.GetCurrentSession())
            {
                ITransaction tx = session.BeginTransaction();
                IQuery query = session.CreateQuery("select c from Cat as c where c.Sex = :sex");
                // query.SetCharacter("sex", 'F');
                query.SetString("sex", sex);
                var lists = query.List<Cat>();
                tx.Commit();
                return lists;
            }
        }
    }
}
