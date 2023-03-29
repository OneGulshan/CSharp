using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public partial class Partial
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            set
            {
                _lastName = value;
            }
            get
            {
                return _lastName;
            }
        }        
    }
}

