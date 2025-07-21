#region Arry

#region Q01
//Console.WriteLine("Please enter the arry length");
//int length = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
//int[] numbers = new int[length];
//int sum = 0;
//if (length <= 0)
//{
//    Console.WriteLine("Invalid length. Please enter a positive integer.");
//    return;
//}
//else
//{
//    for (int i = 0; i < length; i++)
//    {
//        Console.WriteLine($"Please enter number {i + 1}");
//        numbers[i] = int.Parse(Console.ReadLine()!);
//        sum += numbers[i];
//    }
//    Console.WriteLine($"The sum of the numbers is: {sum}");
//}
#endregion

#region Q02
//Console.WriteLine("Please enter the length of the arrays");
//int length = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
//if (length <= 0)
//{
//    Console.WriteLine("Invalid length. Please enter a positive integer.");
//    return;
//}
//int[] array1 = new int[length];
//int[] array2 = new int[length];
//int[] mergedArray = new int[length * 2];

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine($"Please enter number {i + 1} for the first array");
//    array1[i] = int.Parse(Console.ReadLine()!);
//}

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine($"Please enter number {i + 1} for the second array");
//    array2[i] = int.Parse(Console.ReadLine()!);
//}

//mergedArray = array1.Concat(array2).ToArray();
//Array.Sort(mergedArray);
//Console.WriteLine("The merged and sorted array is:");
//foreach (var item in mergedArray)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Q03





#endregion

#region Q04 
//Console.WriteLine("Please enter the length of the array");
//int length = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
//if (length <= 0)
//{
//    Console.WriteLine("Invalid length. Please enter a positive integer.");
//    return;
//}
//int[] numbers = new int[length];
//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine($"Please enter number {i + 1}");
//    numbers[i] = int.Parse(Console.ReadLine()!);
//}
//int max = 0;
//int min = int.MaxValue;

//for (int i = 0; i < length; i++)
//{

//        if (numbers[i] > max)
//        {
//            max = numbers[i];
//        }
//        if (numbers[i] < min)
//        {
//            min = numbers[i];
//        }
//    }
//Console.WriteLine($"Max is {max}, and Min is {min}");


#endregion

#region Q05
//Console.WriteLine("Please enter the length of the array");
//int length = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
//if (length <= 0)
//{
//    Console.WriteLine("Invalid length. Please enter a positive integer.");
//    return;
//}
//int[] numbers = new int[length];
//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine($"Please enter number {i + 1}");
//    numbers[i] = int.Parse(Console.ReadLine()!);
//}

//Array.Sort(numbers);
//Array.Reverse(numbers);
//if (numbers.Length < 2)
//{
//    Console.WriteLine("Not enough numbers to find the second largest.");
//    return;
//}
//Console.WriteLine($"The 2nd Larget number is:{numbers[1]}");

#endregion

#region Q06

// Console.WriteLine("Please enter the length of the arrays");
//int length = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
//if (length <= 0)
//{
//    Console.WriteLine("Invalid length. Please enter a positive integer.");
//    return;
//}
//int[] array = new int[length];


//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine($"Please enter number {i + 1} for the first array");
//    array[i] = int.Parse(Console.ReadLine()!);
//}

//    Console.WriteLine("The array is:");
//    foreach (var item in array)
//    {
//        Console.WriteLine(item);
//    }


#endregion

#region Q07 


#endregion

#region Q08

//Console.WriteLine("Please enter you text");
//string input = Console.ReadLine()!;
//string[] words = input.Split(' ');
//Array.Reverse(words);

//foreach (var word in words)
//{
//    Console.Write($"{word} " );
//}


#endregion

#region Q09
//Console.WriteLine("Please enter the length of the array");
//int length = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
//if (length <= 0)
//{
//    Console.WriteLine("Invalid length. Please enter a positive integer.");
//    return;
//}
//int[,] numbers = new int[length,length];
//for (int i = 0; i< numbers.GetLength(0); i++)
//{
//    for(int x = 0; x< numbers.GetLength(1);x++)
//    {
//     Console.WriteLine($"Please enter number {i + 1} for the array");
//        numbers[i, x] = int.Parse(Console.ReadLine()!);

//    }
//}

//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int x = 0; x < numbers.GetLength(1); x++)
//        {
//        Console.Write($"{numbers[i,x]} ");
//    }
//}


#endregion

#region Q10

//Console.WriteLine("Please enter the length of the array");
//int length = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
//if (length <= 0)
//{
//    Console.WriteLine("Invalid length. Please enter a positive integer.");
//    return;
//}
//int[] numbers = new int[length];
//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine($"Please enter number {i + 1}");
//    numbers[i] = int.Parse(Console.ReadLine()!);
//}

//Array.Reverse(numbers);
//Console.WriteLine("The reversed array is:");
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}


#endregion

#endregion


#region Functions

#region Q01
// passing by value it pass the value of the variable
// passing by reference it pass the address

//int X = 10, Y=20;
//Console.WriteLine($"First no {X}, Second no {Y}  -- Before swap");
//void Swap(ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//    Console.WriteLine($"First no {a}, Second no {b}  -- After swap");
//}

//Swap(ref X, ref Y);



#endregion

#region Q02
// passing reference parameter mean passing the address of the variable
// both the caller and callee can modify the value of the variable
// both paasing by value and passing by reference can modify the value of the variable

//int[] x = { 1, 2, 3, 4, 5 };

//void ModifyArray(ref int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        arr[i] *= 2; // Modifying the array elements
//    }
//}

//ModifyArray(ref x);

//foreach(var item in x)
//{
//    Console.WriteLine(item); // Output will be 2, 4, 6, 8, 10
//}


#endregion


#region Q03

// void SumAndSub(int x, int y, out int sum, out int sub)
//{
//    sum = x + y;
//    sub = x - y;
//}

//int x = 10, y = 5, sum, sub;

//SumAndSub(x, y, out sum, out sub);

//Console.WriteLine("Sum {0}, Sub {1}", sum, sub);

#endregion

#region Q04
//Console.WriteLine("Enter the numbers");
//string input = Console.ReadLine()!;

//void CalculateSumOfDigits(ref string number)
//{
//    int sum = 0;
//    foreach (char digit in number)
//    {
//        if (char.IsDigit(digit))
//        {
//            sum += digit - '0'; // Convert char to int
//        }
//    }
//    Console.WriteLine($"The sum of the digits is: {sum}");
//}

//CalculateSumOfDigits(ref input);

#endregion



#region Q05

//int[] MinMaxArray(int[] numbers)
//{
//    int min = int.MaxValue;
//    int max = int.MinValue;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if(numbers[i] < min)
//        {
//            min = numbers[i];
//        }
//        if(numbers[i] > max)
//        {
//            max = numbers[i];
//        }

//    }

//    return new int[] { min, max };
//}

//int[] numbers = MinMaxArray(new int[] { 1,2,3,4,5,6,8});

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

#endregion

#region Q07

//Console.WriteLine("Please enter the number");
//int input = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

//void factorial(params int[] numbers)
//{
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        int fact = 1;
//        for (int j = 1; j <= numbers[i]; j++)
//        {
//            fact *= j;
//        }
//        Console.WriteLine($"The factorial of {numbers[i]} is: {fact}");
//    }
//}

//factorial(input);

#endregion

#region Q08
//Console.WriteLine("Please enter the string");
//string input = Console.ReadLine()!;

//void ChangeChar( char replacedchar, int pos, ref string input)
//{
//    if (pos < 0 || pos >= input.Length)
//    {
//        Console.WriteLine("Invalid position");
//        return;
//    }
//    char[] chars = input.ToCharArray();
//    chars[pos] = replacedchar;
//    input = new string(chars);
//    Console.WriteLine($"The modified string is: {input}");
//}
//ChangeChar('A', 0, ref input);


#endregion

#endregion


