using System;
using System.Text;

internal class Program
{

    static void Main(string[] args)
    {
        #region Task 1: Print numbers from 1 to N
        //Console.Write("Enter a number: ");
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= n; i++)
        //{
        //    Console.Write(i);
        //    if (i != n) Console.Write(", ");
        //}
        //Console.WriteLine();
        #endregion

        #region Task 2: Multiplication table up to 12
        //Console.Write("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= 12; i++)
        //{
        //    Console.Write(num * i + " ");
        //}
        //Console.WriteLine();
        #endregion

        #region Task 3: Print even numbers up to N
        //Console.Write("Enter a number: ");
        //n = int.Parse(Console.ReadLine());
        //for (int i = 2; i <= n; i += 2)
        //{
        //    Console.Write(i + " ");
        //}
        //Console.WriteLine();
        #endregion

        #region Task 4: Power calculation
        //Console.Write("Enter the base number: ");
        //int baseNum = int.Parse(Console.ReadLine());
        //Console.Write("Enter the exponent: ");
        //int exponent = int.Parse(Console.ReadLine());
        //int result = 1;
        //for (int i = 0; i < exponent; i++)
        //{
        //    result *= baseNum;
        //}
        //Console.WriteLine("Result: " + result);
        #endregion

        #region Task 5: Reverse a string
        //Console.Write("Enter a string: ");
        //string input = Console.ReadLine();
        //char[] charArray = input.ToCharArray();
        //Array.Reverse(charArray);
        //Console.WriteLine(new string(charArray));
        #endregion

        #region Task 6: Prime numbers in a range
        //Console.Write("Enter the starting number: ");
        //int start = int.Parse(Console.ReadLine());
        //Console.Write("Enter the ending number: ");
        //int end = int.Parse(Console.ReadLine());
        //Console.WriteLine("Prime numbers:");
        //for (int i = start; i <= end; i++)
        //{
        //    if (IsPrime(i))
        //        Console.Write(i + " ");
        //}
        //Console.WriteLine();
        #endregion

        #region Task 7: Decimal to binary conversion
        //Console.Write("Enter a number: ");
        //int decimalNumber = int.Parse(Console.ReadLine());
        //Console.Write("Binary: ");
        //while (decimalNumber > 0)
        //{
        //    Console.Write(decimalNumber % 2);
        //    decimalNumber /= 2;
        //}
        //Console.WriteLine();
        #endregion

        #region Task 8: Identity matrix
        //Console.Write("Enter the size of the identity matrix: ");
        //n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        Console.Write(i == j ? "1 " : "0 ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion
    
        #region Task 9: Extract a substring
        //Console.Write("Enter a string: ");
        //string mainString = Console.ReadLine();
        //Console.Write("Enter the starting index: ");
        //int startIndex = int.Parse(Console.ReadLine());
        //Console.Write("Enter the length of the substring: ");
        //int length = int.Parse(Console.ReadLine());
        //string substring = mainString.Substring(startIndex, length);
        //Console.WriteLine("Substring: " + substring);
        #endregion

        #region Task 10: Concatenate two strings
        //Console.Write("Enter the first string: ");
        //string string1 = Console.ReadLine();
        //Console.Write("Enter the second string: ");
        //string string2 = Console.ReadLine();
        //Console.WriteLine("Concatenated String: " + string1 + string2);
        #endregion

        #region Task 11: Identity matrix (again)
        //Console.Write("Enter the size of the identity matrix: ");
        //n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        Console.Write(i == j ? "1 " : "0 ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region Task 12: Sum of array elements
        //Console.Write("Enter the size of the array: ");
        //int arraySize = int.Parse(Console.ReadLine());
        //int[] array = new int[arraySize];
        //Console.WriteLine("Enter the elements of the array:");
        //for (int i = 0; i < arraySize; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        //int sum = 0;
        //foreach (int element in array)
        //{
        //    sum += element;
        //}
        //Console.WriteLine("Sum of elements: " + sum);
        #endregion

        #region Task 13: Merge and sort two arrays
        //Console.Write("Enter the size of the arrays: ");
        //int size = int.Parse(Console.ReadLine());
        //int[] array1 = new int[size];
        //int[] array2 = new int[size];
        //Console.WriteLine("Enter elements of the first array:");
        //for (int i = 0; i < size; i++)
        //{
        //    array1[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Enter elements of the second array:");
        //for (int i = 0; i < size; i++)
        //{
        //    array2[i] = int.Parse(Console.ReadLine());
        //}
        //int[] mergedArray = new int[2 * size];
        //array1.CopyTo(mergedArray, 0);
        //array2.CopyTo(mergedArray, size);
        //Array.Sort(mergedArray);
        //Console.WriteLine("Merged and sorted array: " + string.Join(" ", mergedArray));
        #endregion

        #region Task 14: Frequency of elements in an array
        //Console.Write("Enter the size of the array: ");
        //int freqArraySize = int.Parse(Console.ReadLine());
        //int[] freqArray = new int[freqArraySize];
        //Console.WriteLine("Enter the elements of the array:");
        //for (int i = 0; i < freqArraySize; i++)
        //{
        //    freqArray[i] = int.Parse(Console.ReadLine());
        //}
        //Dictionary<int, int> frequency = new Dictionary<int, int>();
        //foreach (int element in freqArray)
        //{
        //    if (frequency.ContainsKey(element))
        //    {
        //        frequency[element]++;
        //    }
        //    else
        //    {
        //        frequency[element] = 1;
        //    }
        //}
        //foreach (var pair in frequency)
        //{
        //    Console.WriteLine($"Element {pair.Key} occurs {pair.Value} times");
        //}
        #endregion

        #region Task 15: Find max and min in an array
        //Console.Write("Enter the size of the array: ");
        //int minMaxArraySize = int.Parse(Console.ReadLine());
        //int[] minMaxArray = new int[minMaxArraySize];
        //Console.WriteLine("Enter the elements of the array:");
        //for (int i = 0; i < minMaxArraySize; i++)
        //{
        //    minMaxArray[i] = int.Parse(Console.ReadLine());
        //}
        //int max = minMaxArray[0];
        //int min = minMaxArray[0];
        //foreach (int element in minMaxArray)
        //{
        //    if (element > max) max = element;
        //    if (element < min) min = element;
        //}
        //Console.WriteLine($"Maximum: {max}, Minimum: {min}");
        #endregion

        #region Task 16: Second largest element
        //Console.Write("Enter the size of the array: ");
        //int secondLargestSize = int.Parse(Console.ReadLine());
        //int[] secondLargestArray = new int[secondLargestSize];
        //Console.WriteLine("Enter the elements of the array:");
        //for (int i = 0; i < secondLargestSize; i++)
        //{
        //    secondLargestArray[i] = int.Parse(Console.ReadLine());
        //}
        //Array.Sort(secondLargestArray);
        //Console.WriteLine("Second largest element: " + secondLargestArray[secondLargestSize - 2]);
        #endregion

        #region Task 17: Longest distance between equal elements
        //Console.Write("Enter the size of the array: ");
        //int distanceArraySize = int.Parse(Console.ReadLine());
        //int[] distanceArray = new int[distanceArraySize];
        //Console.WriteLine("Enter the elements of the array:");
        //for (int i = 0; i < distanceArraySize; i++)
        //{
        //    distanceArray[i] = int.Parse(Console.ReadLine());
        //}
        //Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
        //int longestDistance = 0;
        //for (int i = 0; i < distanceArraySize; i++)
        //{
        //    if (firstOccurrence.ContainsKey(distanceArray[i]))
        //    {
        //        longestDistance = Math.Max(longestDistance, i - firstOccurrence[distanceArray[i]]);
        //    }
        //    else
        //    {
        //        firstOccurrence[distanceArray[i]] = i;
        //    }
        //}
        //Console.WriteLine("Longest distance: " + longestDistance);
        #endregion
    }
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}