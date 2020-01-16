// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using CleanArchitecture.Core.Requests;

namespace CleanArchitecture.ConsoleApp
{
    /// <summary>
    /// Main application entry point.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main application entry point.
        /// </summary>
        /// <param name="args">Arguments passed into the application at runtime.</param>
        public static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentException("args cannot be null");
            }

            var getContactInteractor = new GatherContactInfoInteractor(new MockCreditScoreService(), new CustomerDatabaseInMemoryImpl());

            Console.WriteLine("Name?");
            var name = Console.ReadLine();

            Console.WriteLine("Address?");
            var address = Console.ReadLine();

            Console.WriteLine("Date of birth (yyyy-MM-dd)?");
            var dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("NI Number?");
            var niNumber = Console.ReadLine();

            var getContactResponse = getContactInteractor.Handle(new GatherContactInfoRequest(name, address, dateOfBirth, niNumber));

            if (getContactResponse.HasError)
            {
                foreach (var error in getContactResponse.Errors)
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                var result = getContactResponse.IsAcceptedForLoan ? "accepted" : "rejected";

                Console.WriteLine($"Credit score is {getContactResponse.CreditScore} so customer has been {result}");
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
