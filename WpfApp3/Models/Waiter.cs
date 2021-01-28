using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Waiter
    {
        public int id { get; set; }
        public string login, pass, tables, word;
        public int orders;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string Tables
        {
            get { return tables; }
            set { tables = value; }
        }
        public string Word
        {
            get { return word; }
            set { word = value; }
        }
        public int Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        public Waiter() { }
        public Waiter(string login, string pass, string tables = "", string word = "", int orders = 0)
        {
            this.login = login;
            this.pass = pass;
            this.tables = tables;
            this.word = word;
            this.orders = orders;
        }
    }
}
