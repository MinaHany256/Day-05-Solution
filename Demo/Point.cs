using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        #region Attributes
        // Attributes
        public int x;
        public int y; 
        #endregion

        #region Constructors
        /// Constructor : is a special Function For 2 Reasons
        ///              1. Named always with the same name of its Class or Struct
        ///              2. Has No Return

        /// Parameterless Struct Constructor
        /// By Default in Struct , Compiler will always generate the parametrless constructor
        /// this constructor will intialize the Attributes with its default value
        ///public Point()
        ///{
        ///    x = default;
        ///    y = default;
        ///}

        // Constructor Overloading
        public Point(int number)
        {
            x = y = number;
        }

        public Point(int _X, int _Y)
        {
            x = _X;
            y = _Y;
        } 
        #endregion

        #region Methods
        // overriding on ToString()
        public override string ToString()
        {
            return $"({x} , {y})";
        } 
        #endregion

    }
}
