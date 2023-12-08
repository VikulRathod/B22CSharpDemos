using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Generics
{
    public class Calculator
    {
        #region using method overloading
        //public bool AreEqual(int a, int b)
        //{
        //    return a.Equals(b);
        //}
        //public bool AreEqual(string a, string b)
        //{
        //    return a.Equals(b);
        //}
        //public bool AreEqual(float a, float b)
        //{
        //    return a.Equals(b);
        //}
        #endregion using method overloading

        #region using object type

        // problems with object type
        // 1. there is no type safety
        // 2. chances of boxing & unboxing operations

        //public bool AreEqual(object a, object b)
        //{
        //    return a.Equals(b);
        //}
        #endregion using object type

        #region using generics

        public bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }

        public void Add<T>(T a, T b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            Console.WriteLine(n1 + n2);
        }

        public TResult MethodName<Tin, TResult>(Tin a)
        {
            dynamic d = null;
            return d;
        }

        #endregion using generics
    }
}
