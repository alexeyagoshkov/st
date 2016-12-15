using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    public enum Subject
    {
        Mathematic,
        Physicist,
        English
    }

    class Student
    {
        public static Random rnd = new Random();
        //public Random rnd = new Random();  // Почему при 2х рандомах, заполнение происходит одинаковыми числами
        public int _Year;
        public int _IndividualCode;
        public string _Name;
        private int [,]arr;
        private int _gradeCnt;

        public int StudentCounter
        {
            set
            {
                _gradeCnt = value;
            }
            get
            {
                return _gradeCnt;
            }
        }


        public override string ToString()
        {
            string text = "";
            text = _Name + ", " + _IndividualCode + ", " + _Year + "\n";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                text += (Subject)i + " " ;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    text += arr[i, j].ToString() + " ";
                }
                text += "\t" + "ср.балл: " + MidGrade(i) + "\n";
            }
            return text;
        }

        public void Grade()
        {
            arr = new int[3, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(2, 12);
                }
            }
        }

        public double MidGrade(int subj)
        {
            int total = 0;
			     for (int j = 0; j < arr.GetLength(1); j++)
			    {
                    total = total + arr[subj, j];
			    }
            return total / arr.GetLength(1);
        }

    }

   
}