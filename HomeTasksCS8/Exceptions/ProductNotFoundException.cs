using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTasksCS8.Exceptions
{
    internal class ProductNotFoundException:Exception
    {
        public ProductNotFoundException():base("Bele bir mehsul yoxdur.")
        {

        }
    }
}
