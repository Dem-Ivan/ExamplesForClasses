using System;
using System.Reflection;

namespace SemplForReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Tom", "778 25156");
            var client = new Client("Olga", "779 70529", 100);

            PrintObjectProperties_1(employee);
            PrintObjectProperties_1(client);
            PrintObjectProperties_2("SemplForReflection.Employee");
            DynamicLoadingAssemblies(employee);
        }

        static void PrintObjectProperties_1(object samObject)
        {
            var type = samObject.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            
            foreach (var property in properties)
            {
                Console.WriteLine($"prop name = {property.Name}, prop value = {property.GetValue(samObject)}");
            }
        }

        static void PrintObjectProperties_2(string typeName)
        {
            var type = Type.GetType(typeName, false, true);

            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                Console.WriteLine($"prop name = {property.Name}");
            }
        }

        static void DynamicLoadingAssemblies(Employee employee)
        {
            string path = @"E:\VS\Подготовка к курсам\SemplForFileStream\SemplForFileStream\bin\Debug\netcoreapp3.1\SemplForFileStream.dll";
            Assembly assembly = Assembly.LoadFrom(path);
            var type = assembly.GetType($"SemplForFileStream.Program", true, true);

            object obj = Activator.CreateInstance(type);
            MethodInfo methodInfo = type.GetMethod("WriteReader");
            object res = methodInfo.Invoke(obj, new object[] { $"Employee name: {employee.Name}, phone: {employee.Phone}" });
            Console.Write(res.ToString());
        }

    }
}
