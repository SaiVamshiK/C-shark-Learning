using System;

namespace ClassLibrary1
{
    public class DivClass
    {
        public double divide(int a,int b)
        {
            try
            {
                return a / b;
            }
            catch(Exception e)
            {
                throw new Exception("Dividend cannot be zero");
            }
        }
    }
}
