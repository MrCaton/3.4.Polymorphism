using System;
using System.Collections.Generic;

namespace _3._4.Polymorphism
{
    class Program
    {
        //UserError userError=new UserError();
        static void Main(string[] args)
        {
                Console.ReadLine();
                UserError text = new NumericInputError();
                UserError number = new TextInputError();
                text.UEMessage();
                number.UEMessage();
            
            



            //foreach (var userError in UserError)
            //{

            //}
        }
    }
    abstract class UserError
    {
        // private List<UserError> userError;
        public virtual  string UEMessage()
        {
            return "Error";
        }
        //public UserError()
        //{
        //    userError = new List<UserError>();
        //}
    }
    class NumericInputError:UserError
    {
 
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";

        }
    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";

        }
    }
}
