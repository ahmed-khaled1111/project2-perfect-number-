namespace perfect_number_finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 , num2 , i , j , sum ;
            Console.WriteLine("please enter the two limits");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            //receiving input from the user 

            Console.WriteLine();
            Console.WriteLine(); //spaces so the program doesnt become cluttered 
            Console.WriteLine();


            if (num1 <= 1)
            {
                num1 = 2;   //an instruction to eliminate 0 , 1 since they are not perfect numbers
            }


            for (num1 = num1; num1 <= num2; num1++)  //invoking all numbers between the two limits   
            {
                sum = 1;
                for (i = 2; i < num1; i++) 
                {
                    if (num1 % i == 0)    //testing if the number was divisible or not 
                    {
                        sum += i;    
                    }
                }
                if (sum == num1)          //if the sum of the divisors was equal to the number then num1 is a perfect number therefore it is displayed 
                {
                    Console.WriteLine(num1);
                }
            }
        }    
    }
}