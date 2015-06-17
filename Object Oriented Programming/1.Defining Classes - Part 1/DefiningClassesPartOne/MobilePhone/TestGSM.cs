// Problem 7. GSM test

// Write a class GSMTest to test the GSM class:
// Create an array of few instances of the GSM class.
// Display the information about the GSMs in the array.
// Display the information about the static property IPhone4S.
namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class TestGSM
    {
        public static void Main()
        {
            Console.WriteLine("Test GSM");
            GSMTest();
            Console.WriteLine("\nTest Call History");
            CallHistoryTest();
        }

        // Problem 12. Call history test

        // Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        // Create an instance of the GSM class.
        // Add few calls.
        // Display the information about the calls.
        // Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        // Remove the longest call from the history and calculate the total price again.
        // Finally clear the call history and print it.
        private static void CallHistoryTest()
        {
            var callGsm = new GSM("Nekva stroshena nokia", "Nokia", 50, "Az", new Battery("Gotina bateriq"), new Display("256x480"));
            var firstCall = new Call("25/12/2014", "11:00", "08876451", 120);
            var secondCall = new Call("25/01/2015", "15:30", "0887645112", 150);

            callGsm.AddCall(firstCall);
            callGsm.AddCall(secondCall);

            foreach (var call in callGsm.CallHistory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine("{0:C}",callGsm.CalculateCallPrice(0.37M));

            callGsm.DeleteCall(secondCall);
            Console.WriteLine("{0:C}", callGsm.CalculateCallPrice(0.37M));

            callGsm.ClearCallHistory();
            foreach (var call in callGsm.CallHistory)
            {
                Console.WriteLine(call);
            }
        }

        private static void GSMTest()
        {
            var firstGsm = new GSM("Nekva stroshena nokia", "Nokia", 50, "Az", new Battery("Gotina bateriq"), new Display("256x480"));
            var secondGsm = new GSM("Nekvo lenovo", "Lenovo", 150, "Pesho", new Battery("Bateria", 20, 50, BatteryType.NiCd), new Display("256x480", 256));

            var gsms = new List<GSM>() { firstGsm, secondGsm };
            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm);
                Console.WriteLine();
            }

            var iphone = GSM.IPhone4S;
            Console.WriteLine(iphone);
        }
    }
}
