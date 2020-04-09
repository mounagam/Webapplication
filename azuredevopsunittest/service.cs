using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace azuredevopsunittest
{
    public static class service
    {
        public static int add(int a, int b)
        {

            return Businesslayer.add(a, b);
        }

        public static int multi(int a, int b)
        {

            return Businesslayer.multi(a, b);
        }
        public static int minus(int a, int b)
        {

            return Businesslayer.minus(a, b);
        }
    }
}