using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        /// <summary>
        /// This methiod takes in two integers adds them and
        /// returns the result 
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public int Add(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }


        /// <summary>
        /// This method takes in to integers subtracts values and 
        /// returns the result
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public int Subtract(int firstValue, int secondValue)
        {
            return firstValue - secondValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public int Divide(int firstValue, int secondValue)
        {
          // change return type to int &
          // uncomment to trigger divide by zero ex
             return firstValue/secondValue;
          
          // change return type to double
          // Dividing by zero desn't throw ex wilth code below
          // return (double)firstValue/(double)secondValue;
        }

        // Example of Front End Code
        public int Test(int dividend, int divisor)
        {
            var calculator = new Calculator();
            int result = 0;
            try
            {
                result = calculator.Divide(dividend, divisor);
            }
            catch (DivideByZeroException)
            {
                return int.MaxValue;
            }
            catch (Exception)
            {
                result = int.MinValue;
            }
            return result;
        }
    }
}
