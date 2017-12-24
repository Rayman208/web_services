using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Reader
    {
        long Id { set; get; }
        string Name { set; get; }
        string Description { set; get; }

        public Reader(long id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
    
}
