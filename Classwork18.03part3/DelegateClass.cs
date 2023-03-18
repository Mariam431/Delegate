using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork18._03part3
{
    internal class DelegateClass
    {
        public delegate void DelegateName(int x); //Delegate
        public void Meth1(int a) { Console.WriteLine("1"+a); } //Method
        public void Meth2(int b) { Console.WriteLine("2"+b); } //Method
        public void Meth3(int c) { Console.WriteLine("3"+c); } //Method


        //ThreeMethodDelegate delegateObj = new ThreeMethodDelegate(Meth1);
        //delegateObj += new ThreeMethodDelegate(Meth2);
        //delegateObj += new ThreeMethodDelegate(Meth3);
        //delegateObj();
    }
    //delegate int ThreeMethodDelegate(int t);
}
