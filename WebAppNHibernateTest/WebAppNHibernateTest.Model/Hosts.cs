using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppNHibernateTest.Model
{
  public class Hosts
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
        public virtual string Age
        {
            get;
            set;
        }
        /// <summary>
        /// 一个主人有一条或者多条狗
        /// </summary>
        public virtual ISet<Dogs> Dogs { get; set; }
    }
}
