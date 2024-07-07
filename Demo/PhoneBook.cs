using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal struct PhoneBook
    {
        #region Attributes
        private string[] names;
        private long[] numbers;
        int size;
        #endregion

        #region Consructors
        public PhoneBook(int size)
        {
            this.size = size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion

        #region Properties
        public int Size   // ReadOnly Property
        { get { return size; } }
        #endregion

        #region Methods
        public void AddPerson(uint Position, string Name, long number)
        {
            if (names is not null && numbers is not null)
            {
                if (Position < size)
                {
                    names[Position] = Name;
                    numbers[Position] = number;
                }
            }
        }
        #endregion

        #region Getter and Setter
        // I need to have access on the array 

        // Getter
        //public long GetNumber(string Name)
        //{
        //    if (names is not null && numbers is not null)
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (Name == names[i])
        //                return numbers[i];
        //        }
        //    }
        //    return -1;
        //}


        //// Setter 
        //public void SetNumber(string Name, long Number)
        //{
        //    if (names is not null && numbers is not null)
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (Name == names[i])
        //            {
        //                numbers[i] = Number;
        //                return;
        //                // Break: Code after this bracets will be done
        //                // Return: Function will be stopped after that
        //            }

        //        }
        //    }
        //}

        #endregion

        #region Property Using Indexer

        // Indexer is a special property [named always with keywoard "this"  and Take Parameter]

        public long this[string Name]     // this referes to object (Note)
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                            return numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                        {
                            numbers[i] = value;
                            return;
                            // Break: Code after this bracets will be done
                            // Return: Function will be stopped after that
                        }

                    }
                }
            }

            #endregion
        }

        public string this[int index]
        {
            get
            {
                return $"Position: {index+1} \n Name: {names[index]} \n Number: {numbers[index]}";
            }
        }
    }
}
