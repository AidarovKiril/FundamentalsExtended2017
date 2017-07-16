using System;

class Phone
{
    
        static void Main(string[] args)
        {
            string[] phonenumbers = Console.ReadLine().Split(' ');
            string[] phoneNames = Console.ReadLine().Split(' ');

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "done")
                {
                    break;
                }
                else if (command[0] == "call")
                {
                    CallMetod(phonenumbers, phoneNames, command);
                }
                else if (command[0] == "message")
                {
                    MessageMetod(phonenumbers, phoneNames, command);
                }

            }
        }

        static void CallMetod(string[] phoneNumbers, string[] phoneNames, string[] command)
        {
            int sum = 0;
            int position = 0;

            for (int i = 0; i < phoneNumbers.Length; i++)
            {

                if (command[1] == phoneNumbers[i])
                {
                    Console.WriteLine($"calling {phoneNames[i]}...");
                    position = i;
                }
                else if (command[1] == phoneNames[i])
                {
                    Console.WriteLine($"calling {phoneNumbers[i]}...");
                    position = i;
                }
            }
            char[] digits = phoneNumbers[position].ToCharArray();
            for (int j = 0; j < digits.Length; j++)
            {

                if (digits[j] == '1' || digits[j] == '2' || digits[j] == '3' || digits[j] == '4'
                    || digits[j] == '5' || digits[j] == '6' || digits[j] == '7' || digits[j] == '8'
                    || digits[j] == '9')
                {
                    int tempNum = (int)char.GetNumericValue(digits[j]);
                    sum += tempNum;
                }
            }
            int minutes = sum / 60;
            int seconds = sum % 60;
            string duration = $"{minutes:d2}:{seconds:d2}";
            if (sum % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                Console.WriteLine($"call ended. duration: {duration}");
            }


        }
        static void MessageMetod(string[] phoneNumbers, string[] phoneNames, string[] command)
        {

            int sum = 0;
            int position = 0;

            for (int i = 0; i < phoneNumbers.Length; i++)
            {

                if (command[1] == phoneNumbers[i])
                {
                    Console.WriteLine($"sending sms to {phoneNames[i]}...");
                    position = i;
                }
                else if (command[1] == phoneNames[i])
                {
                    Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                    position = i;
                }
            }
            char[] digits = phoneNumbers[position].ToCharArray();
            for (int j = 0; j < digits.Length; j++)
            {

                if (digits[j] == '1' || digits[j] == '2' || digits[j] == '3' || digits[j] == '4'
                    || digits[j] == '5' || digits[j] == '6' || digits[j] == '7' || digits[j] == '8'
                    || digits[j] == '9')
                {
                    int tempNum = (int)char.GetNumericValue(digits[j]);
                    sum -= tempNum;
                }
            }
            if (sum % 2 != 0)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine("meet me there");
            }
        }
}








    

