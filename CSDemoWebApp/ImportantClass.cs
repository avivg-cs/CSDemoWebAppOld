using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSDemoWebApp
{
    public class ImportantClass
    {
        private int num;

        public ImportantClass()
        {
            this.num = 0;
        }

        public int GetNum()
        {
            return this.num;
        }

        public void AddToNum(int add)
        {
            this.num += add;
        }

        public void SubFromNum(int sub)
        {
            this.num -= sub;
        }

        public void ResetNum()
        {
            this.num = 0;
        }
    }
}