using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppNHibernateTest.Model
{
    public class Dogs
    {
        private string id;
        private string name;
        private char sex;
        private float weight;

        public Dogs()
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

        /// <summary>
        /// 狗的主人，狗对应的主人（多条狗对应一个主人）
        /// </summary>
        public virtual Hosts Hosts
        {
            get; set;
        }
    }
}
