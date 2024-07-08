using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        /// 1. Encapsulation: Separates Data_Defintion [Attributes]
        /// From its use [Getter setter Methods , Property]


        /// 1.1 Applying Encapsulation: using Old approach [Getter Setter Methods]
        /// On Name
        ///      1. change access modifiers to private
        ///      2. create getter and setter


        #region Attributes
        public int Id;
        private string? Name;
        private decimal salary;
        //private decimal deduction;   // [Derived Attributes] not needed (Calculated at Runtime)
        #endregion

        #region Constructor
        public Employee(int id, string name, decimal salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }
        #endregion

        #region Methods
        //if we want to print the attributes as a string
        public override string ToString()
        {
            return $" Id: {Id} \n Name: {Name} \n Salary: {Salary:c}";
        }

        // Getter
        public string? GetName()
        {
            return Name;
        }

        // Setter
        public void SetName(string? value)
        {
            Name = value?.Length > 10 ? value.Substring(0, 10) : value;
        }
        #endregion


        /// 1.2 applying Encapsulation using NEW Approach [Property] on Salary
        //full لو انا عامل ال اتربيوت بتاعها تبقي 
        #region Full Property
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Decimal Deduction   //ReadOnly Property
        {
            get
            {
                return salary * .2m;
            }
        }
        #endregion


        /// Automatic Property
        /// No need to create attribute  
        /// Complier will generate Backing Field "Hidden Private Attribute"
        public int Age { get; set; }
    }
}
