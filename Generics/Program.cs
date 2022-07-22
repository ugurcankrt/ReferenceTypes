using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler1 = new List<string>();
            sehirler1.Add("Afyon");
            sehirler1.Add("Afyon");

            Console.WriteLine(sehirler1.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Adıyamman");
            sehirler2.Add("Adıyamman");
            sehirler2.Add("Adıyamman");

            Console.WriteLine(sehirler2.Count);

        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;


        public MyList()
        {
            _array = new T[0];

        }

        public void Add(T item) 
        {
            _tempArray = _array;
            _array = new T[_array.Length+ 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        
        }




        public int Count
        {
            get { return _array.Length; }

        }
    

    }

    }



