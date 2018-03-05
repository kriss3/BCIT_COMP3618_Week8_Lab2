using System;
using System.Reflection;
using static System.Console;

namespace ConAppAssemblyAttrDemo
{
    class MyApp
    {
        /// <summary>
        /// BCIT COMP3618 Week 8 Lab 2
        /// Krzysztof Szczurowski
        /// Repo: https://github.com/kriss3/BCIT_COMP3618_Week8_Lab2.git
        /// Helper class containing static methods used in the main app;
        /// </summary>
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
