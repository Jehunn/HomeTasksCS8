using System;
using System.Collections.Generic;
using System.Text;
using HomeTasksCS8.Exceptions;

namespace HomeTasksCS8
{
    internal class Store
    {
        
        public Product[] Products=new Product[0];


        public void AddProduct(Product prd)
        {
            if(!HasProductByNo(prd.No))
            {
                Array.Resize(ref Products, Products.Length+1);
                Products[Products.Length - 1] = prd;
            }
        }

        public bool HasProductByNo(int no)
        {
            foreach(Product prd in Products)
            {
                if (prd.No == no)
                    return true;
            }
            return false;
        }

        public Product GetProductByNo(int no)
        {
            if(HasProductByNo(no))
            {
                return Products[no];
            }
            throw new ProductNotFoundException();
        }

       
    }
}
