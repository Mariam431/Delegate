using static Classwork18._03part3.DelegateClass;
namespace Classwork18._03part3

{
    internal class Program
    {
        public static void MethodG(int k) { Console.WriteLine(k); } //Method
        static void Main(string[] args)
        {
            DelegateClass delegateClass = new DelegateClass(); //ClassInstance
            DelegateName delegateName = new DelegateName(delegateClass.Meth1); //InstanceDelegate
            delegateName += delegateClass.Meth2; //Add Methods
            delegateName += delegateClass.Meth3;
            delegateName += MethodG;
            delegateName(5); //Parametrize Method
        }
    }
}












