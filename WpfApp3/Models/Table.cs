using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Table
    {
        //free
        //busy
        //reserved
        //undefind
        public int id { get; set; }
        public string status, order;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Order
        {
            get { return order; }
            set { order = value; }
        }
        public Table() { }
        public Table(string status, string order = "")
        {
            this.status = status;
            this.order = order;
        }
    }
}
