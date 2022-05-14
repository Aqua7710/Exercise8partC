class Exercise8
{
    public static void Main(string[] args)
    { 
        Console.WriteLine("Hey user! This program will ask you too enter 10 positive numbers and it will then display those numbers as well as the minimum and maximum numbers.\n\n65");
        int[] numberArray = new int[10];
        int counter = 0;
        while(counter < 10)
        {
            Console.Write("Please enter a positive interger number = ");
            numberArray[counter] = Convert.ToInt32(Console.ReadLine());
            counter++;
        }
        Console.Clear(); 
        foreach(var item in numberArray)
        {
            Console.WriteLine("Numbers you entered: " + item);
        }

        Array.Sort(numberArray);
        if(numberArray[0] < 0)
        {
            Console.WriteLine("\n\nInvalid Minimum Number! It's below zero!");
        }
        else
        {
            Console.WriteLine("\n\nMinimum number = " + numberArray[0] + "\nMaximum number = " + numberArray[9]);
        }
    }
}