using System;
using System.Reflection;
using static System.Console;

namespace ConAppAssemblyAttrDemo
{
    class MyApp
    {
        static void Main(string[] args)
        {
            Assembly a = Assembly.GetExecutingAssembly();
            Type attrType = typeof(AssemblyDescriptionAttribute);
            object[] attrs = a.GetCustomAttributes(attrType, false);
            if (attrs.Length > 0)
            {
                AssemblyDescriptionAttribute desc =
                (AssemblyDescriptionAttribute)attrs[0];
                WriteLine($"Description is: {desc.Description}");
            }
        }
    }
}
