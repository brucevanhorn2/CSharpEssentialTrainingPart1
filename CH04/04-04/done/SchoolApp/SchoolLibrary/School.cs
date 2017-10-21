using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class School
    {
        string Name { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        string PhoneNumber { get; set; }

        string _twitterAddress;
        string TwitterAddress
        {
            //make sure the twitter adderss starts with @
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }
    }
}
