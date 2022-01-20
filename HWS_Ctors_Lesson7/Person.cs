using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HWS_Ctors_Lesson7
{
    internal class Person
    {
        public string name;
        public int age;
        public int id = 1248131923;

        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name: {name}. age: {age}.";
            //return JsonConvert.SerializeObject(this);
        }
    }
}
