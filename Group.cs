using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class Group
    {
        private Student[] students;
        private int _studentCounter;

        public Group(int studentCounter)
        {
            _studentCounter = studentCounter;
        }

        public int StudentCounter
        {
            set
            {
             _studentCounter = value; 
            }
            get
            {
                return _studentCounter;
            }
        }

        public Student this[int index]
        {
            set
            {
                students[index] = value;
            }
            get
            {
                return students[index];
            }
        }

        public void Input()
        {
            students = new Student[100];
            for (int i = 0; i < StudentCounter; i++)
            {
                students[i] = new Student();
                GetInfo(i);
                students[i].Grade();
            }
        }

        private void GetInfo(int i)
        {
            View.SystemMessage("Enter Name - " + (i + 1));
            students[i]._Name = Console.ReadLine();
            View.SystemMessage("Enter Year - " + (i + 1));
            students[i]._Year = int.Parse(Console.ReadLine());
            View.SystemMessage("Enter Code - " + (i + 1));
            students[i]._IndividualCode = int.Parse(Console.ReadLine());
        }

        //public void Remove()
        //{
        //    for (int i = 0; i < StudentCounter; i++)
        //    {
        //       
        //    }


        //}


   
    }
}
