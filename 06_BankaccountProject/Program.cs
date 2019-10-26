using System;

namespace Exercise__Git
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare  variables
            int verificationCode, pintrial = 1;
            string pin, userName, userNameLower, realPin = "0000",  savedBankccountNumber = "0100353689800", bankAccountNumber, recipients;

           // label
            rex:   
            
            Console.WriteLine("Please input your User Name.");
            userName = Console.ReadLine();

            // convert userName to lower and trim by removing empty spaces
            userNameLower = userName.Trim().ToLower();

            Console.WriteLine("Please provide your bank account number");
            bankAccountNumber = Console.ReadLine();

            if( userName == "lilian" && bankAccountNumber ==  savedBankccountNumber )
            {
                // Generate a random numnber using Random class
                Random rand = new Random();
                verificationCode = rand.Next();
                Console.WriteLine("Input the verification code provided: \n " +  verificationCode);
            }

            // Checks for the provided bank account number and User name and compares against the values in the program for verification
            else if(userName !=" lilian" && bankAccountNumber !=   savedBankccountNumber)
            {
                
                    Console.WriteLine("Wrong details entered, please try again");
                     goto rex;
                
            }

            Console.WriteLine();

         
            Console.WriteLine("WELCOME TO MOBILE BANKING.");
            Console.WriteLine("TO SEND MONEY PLEASE INPUT THE GIVEN RECEPIENTS NUMBER. TO TERMINATE SERVICES TYPE EXIT");

            recipients = Console.ReadLine();

            yeap:
            Console.WriteLine("Input your pin");

            pin = Console.ReadLine();
            
            if (pin == realPin)
            {
                Console.WriteLine("THANKYOU FOR BANKING WITH US");
            }

            else if (pin == "exit")
            {
                Console.WriteLine("THANKYOU FOR BANKING WITH US");
            }

            else
            {
              
                if(pintrial < 3)
                {
                    Console.WriteLine(" Wrong pin entered please try again");
                    Console.WriteLine($"You have depleted your {pintrial} attempts.");
                    pintrial += 1;
                    goto yeap;
                }
                else  if(pintrial ==3)
                {
                    Console.WriteLine("You have depleted all your attempts, kindly go to the nearest bank for further assistance.");
                }
                          
            }
           
        }                     
       
    }
}
