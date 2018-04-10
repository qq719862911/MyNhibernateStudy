using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppNHibernateTest.Model
{
  public class Hosts
    {
        private string id;
        private string name;
        private string age;

        public Hosts()
        {
        }

        public virtual string Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual string Age
        {
            get { return age; }
            set { age = value; }
        }
        /// <summary>
        /// 一个主人有一条或者多条狗
        /// </summary>
        public virtual ISet<Dogs> Dogs { get; set; }
    }
}
