using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APISerializable.ViewModels
{
    public class Person
    {
        public Person()
        {

        }

        public Person (string name, int age)
        {
            _mName = name;
            _mAge = age;
        }
        private int _mAge;

        public int Age
        {
            get { return _mAge; }
            set { _mAge = value; }
        }

        private string _mName;

        public string Name
        {
            get { return _mName; }
            set { _mName = value; }
        }

    }
}