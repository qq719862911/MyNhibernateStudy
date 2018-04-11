using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppNHibernateTest.Model
{
    public class Dogs
    {

        public virtual string Id
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 狗的主人，狗对应的主人（多条狗对应一个主人）
        /// </summary>
        public virtual Hosts Hosts
        {
            get; set;
        }
    }
}
