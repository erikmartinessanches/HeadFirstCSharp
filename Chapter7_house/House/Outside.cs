using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Outside : Location
    {
        private bool Hot { get; set; }

        public Outside(string name, bool hot) : base(name)
        {
            this.Hot = hot;
        }

        public override string Description
        {
            get
            {
                if (Hot)
                {
                    string newDescription = base.Description;
                    return newDescription += " It's very hot here.";
                }
                else
                {
                    return base.Description;
                }
            }
        }
    }

}
