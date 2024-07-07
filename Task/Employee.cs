using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    enum Gender
    {
        Male,
        Female
    }
    internal struct Employee
    {

        #region Attributes
        private int id;
        private string name;
        private decimal salary;
        private Gender gender;
        #endregion

        #region Constructor

        public Employee (int Id, string Name, decimal Salary, Gender Gender)
        {
            this.id = Id;
            this.name = Name;   
            this.salary = Salary;
            this.gender = Gender;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $" Id: {id} \n Name: {name} \n Salary: {salary} \n Gender: {gender}";
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }      
            set { id = value; }
        }
        public string Name
        { get { return name; } set { name = value; } }

        public decimal Salary
            { get { return salary; } set { salary = value; } }

        public Gender Gender { get { return gender; } set { gender = value; } }

        #endregion

    }
}
