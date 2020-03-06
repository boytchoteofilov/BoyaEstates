using System;
using System.Collections.Generic;
using System.Text;

namespace BoyaEstates.Data
{
    public class Property : BaseModel<int>
    {
        public int Price { get; set; }

        public string Description { get; set; }

        public int Bedrooms { get; set; }

        public int Bathrooms { get; set; }

        public int Area { get; set; }

        public int Floor { get; set; }
    }
}
