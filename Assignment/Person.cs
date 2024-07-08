using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Person
    {
        #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.


        //#region Attributes
        //private string[] names;
        //private int[] ages;
        //private int size;
        //#endregion

        //public Person(int size)
        //{
        //    this.size = size;
        //    names = new string[size];
        //    ages = new int[size];
        //}

        //public int Size   // ReadOnly Property
        //{ get { return size; } }

        //public void AddPerson(int Position, string Name, int age)
        //{
        //    if (names is not null && ages is not null)
        //    {

        //        if (Position < size)
        //        {
        //            names[Position] = Name;
        //            ages[Position] = age;
        //        }

        //    }
        //}

        //public string this[int index]
        //{
        //    get
        //    {
        //        return $" Number: {index} \n Name: {names[index]} \n Age: {ages[index]}";
        //    }
        //}
        #endregion



        #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

        //#region Attributes
        //private string[] names;
        //private int[] ages;
        //private int size;
        //#endregion

        //public Person(int size)
        //{
        //    this.size = size;
        //    names = new string[size];
        //    ages = new int[size];
        //}

        //public int Size   // ReadOnly Property
        //{ get { return size; } }

        //public void AddPerson(int Position, string Name, int age)
        //{
        //    if (names is not null && ages is not null)
        //    {

        //        if (Position < size)
        //        {
        //            names[Position] = Name;
        //            ages[Position] = age;
        //        }

        //    }
        //}

        //public string this[int index]
        //{
        //    get
        //    {
        //        return $" Number: {index} \n Name: {names[index]} \n Age: {ages[index]}";
        //    }
        //}


        //public string GetOldestPerson()
        //{
        //    int OldAge = 0;
        //    int Index = 0;

        //    for (int i = 0; i < size; i++)
        //    {
        //        if (ages[i] > OldAge)
        //        {
        //            OldAge = ages[i];
        //            Index = i;
        //        }
        //    }

        //    return $"Oldest person is {names[Index]} with age {ages[Index]}";
        //}

        #endregion

    }
}
