//You have an array of numbers example :  [5,10,15,20,3] , create a new result
//array out of this  where  result[0] = sum of all elements of input array but
//ignore the input[0],  result[1] =  sum of all elements of input array but
//ignore input[1]  and so on..  Try to use the best complexity algorithm

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter array size :");
        int inputArrayLength = int.Parse(System.Console.ReadLine());

        int[] inputArray = new int[inputArrayLength];
        for(int i = 0; i < inputArrayLength; i++)
        {
            System.Console.WriteLine("Enter element "+(i+1)+" of the array..");
            inputArray[i] = int.Parse(System.Console.ReadLine());

        }

        int sumOfInputArray = 0;

        for(int i=0 ; i < inputArrayLength; i++)
        {
            sumOfInputArray = sumOfInputArray+inputArray[i]; 
        }

        int[] resultArray = new int[inputArrayLength];

        for(int i= 0;i < inputArrayLength;i++)
        {
            resultArray[i] = sumOfInputArray - inputArray[i];
        }

        //display result array
        for(int i=0;i<inputArrayLength;i++)
        {
            System.Console.Write(resultArray[i] + " ");
        }
        //System.Console.WriteLine(inputArray);
        System.Console.ReadKey();



    }
}
