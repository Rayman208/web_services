using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Reader
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

        public Reader(long id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
    
}
