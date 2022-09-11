using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.DynamicProg
{
    public class DynamicPro
    {
        public static dynamic Mean(dynamic x, dynamic y)
        {
            dynamic result = (((dynamic)x + y)/2);
            return result;
        }



        public static T Mean<T> (T x, T y)
        {
            //dynamic result = ( x + y / (dynamic) 2);

            dynamic result = (dynamic)x + (dynamic)y;

            return (T)result;

        }
    }
}
