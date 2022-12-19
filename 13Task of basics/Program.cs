using System;
namespace Tasks{
    class Task{
       static void Main(string[] args)
       {
          // Task 1 Revese string

         //  string s;
         //  Console.WriteLine("Please Enter Word");
         //  s=Console.ReadLine();
         //  if(s==null) return;
         //  for(int i=s.Length-1;i>=0;i--)
         //  {
         //    Console.Write(s[i]);
         //  }

          // -----------------------------------------------------

          // Task2  Count of a

          //  string s;
          //  Console.WriteLine("Please Enter Word: ");
          //  s=Console.ReadLine();
          //  if(s==null) return;
          //  int c=0;
          //  foreach (var item in s.ToLower())
          //  {
          //   if(item=='a')
          //     c++;
          //  }
          //  Console.WriteLine("Count Of a = " +c);
          
          // ----------------------------------------------------------

          // Task 3 Last index of a

          // string s;
          // Console.WriteLine("Please Enter Word: ");
          // s=Console.ReadLine();
          // if(s==null) return;
          // for(int i=s.Length-1;i>=0;i--)
          // {
          //   if(s[i]=='a'){
          //     Console.WriteLine("Last index of a = " + i);
          //     break;
          //   }
          // }

          // -----------------------------------------------------------

          // Task 4 remove all a

          // string s;
          // Console.WriteLine("Please Enter Word: ");
          // s=Console.ReadLine();
          // if(s==null) return;
          // for(int i=0;i<s.Length;i++)
          // {
          //     if(s[i]=='a')
          //       s=s.Replace(s[i].ToString(),"");
          // }
          // Console.WriteLine("New String = " + s);

          // --------------------------------------------------

          // Task 5 add 0 after each a

          // string s;
          // Console.WriteLine("Please Enter Word: ");
          // s=Console.ReadLine();
          // if(s==null) return;
          // for(int i=0;i<s.Length;i++)
          // {
          //     if(s[i]=='a')
          //       s=s.Insert(i+1,"0");
          // }
          // Console.WriteLine("New String = " + s);

          // ---------------------------------------------------------

          // Task 6 countForNonLiteral 
          //      string s;
          //     Console.WriteLine("Please Enter Word: ");
          //     s=Console.ReadLine();
          //     if(s==null) return;
          //      countForNonLiteral = 0;
          //      foreach (var c in s)
          //   {
          //       if (c>=65 && c<= 122)continue;
          //       countForNonLiteral++;
          //   }
          //   Console.Write($"there was {countForNonLiteral} non-literal character");

         //  ---------------------------------------------------------------

         // Task 7 Is palindroma
         //    Console.Write("please enter a  string:");
         //    string s = Console.ReadLine();
         //    if (s == null) return;
         //    var arr = s.ToCharArray();
         //    Array.Reverse(arr);
         //    var isPalindrome = true;
         //    for (int i = 0; i < s.Length; i++)
         //   {
         //       if (s[i] == arr[i]) continue;
         //       isPalindrome = false;
         //       break;
         //    }

         //   var result = isPalindrome == true
         //       ? "string is Palindrome"
         //       : "String is not Palindrome";
         //   Console.Write(result);

         // -------------------------------------------------

         // Task 8 Remove Duplicate
         
         // Console.Write("please enter a  string:");
         // var s = Console.ReadLine();
         // if (s == null) return;
         // var unique =new HashSet<char>(s);
         // foreach (var c in unique)
         // {
         //    Console.Write(c);
         // }

         // --------------------------------------------------

         // Task 9 Earliest Nearst Value from Mean

         // Console.Write("please enter a  size of list:");
         // var size = Convert.ToInt32(Console.ReadLine());
         // var arr = new int[size];
         // for (int i = 0; i < size; i++)
         // {
         //    Console.Write($"please enter element {i+1}: ");
         //    arr[i] = Convert.ToInt32(Console.ReadLine());
         // }

         // var average = arr.Average();
         // var minDistance = double.PositiveInfinity;
         // var num = -1;
         // for (int i = 0; i < arr.Length; i++)
         // {
         //    var distance = average - arr[i];
         //    if (!(Math.Abs(distance) < minDistance)) continue;
         //    minDistance = Math.Abs(distance);
         //    num = arr[i];
         // }
        
         // Console.WriteLine($"{average} is the average ");
         // Console.Write($"{num} is the nearest to the mean \n the difference is {minDistance} ");
         
         // --------------------------------------------------
          
         //  Task 10
      
        //    Console.Write("please enter a  size of list:");
        //   var size = Convert.ToInt32(Console.ReadLine());
        //   var arr = new int[size];
        //   for (int i = 0; i < size; i++)
        //   {
        //       Console.Write($"please enter element {i+1}: ");
        //       arr[i] = Convert.ToInt32(Console.ReadLine());
        //   }

        //   var min = arr[0];
        //   var max = arr[0];

        //   foreach (var i in arr)
        //   {
        //       if (i>max )
        //       {
        //           max = i;
        //       }

        //       if (i<min)
        //       {
        //           min = i;
        //       }
        //   }
        //   Console.WriteLine($"the min of the array is {min}");
        //   Console.WriteLine($"the max of the array is {max}");

         // -------------------------------------------------------

         // Task 11
          
         //  Console.Write("please enter a list separated by space :");
         //  var s = Console.ReadLine()?.Split();
         //  if (s== null)return;
         //  var newString = "";
         //  for (int i = 0; i < s.Length; i++)
         //  {
         //    if (i == s.Length-1)
         //    {
         //        newString = newString.Insert(newString.Length  , s[i]);
         //        break;
         //    }
         //    newString = newString.Insert(newString.Length  , $"{s[i]} , ");
         //    var current = Convert.ToInt32(s[i]);
         //    var next = Convert.ToInt32(s[i+1]);
         //    while ((current + 1) != next)
         //    {
         //        newString = newString.Insert(newString.Length, $"{++current} , ");
         //    }
         //  }
         //  Console.Write(newString);

         // ---------------------------------------------------------
         
         // Task 12
          
         //  Console.Write("please enter a  size of list:");
         //  var size = Convert.ToInt32(Console.ReadLine());
         //  var arr = new int[size];
         //  for (int i = 0; i < size; i++)
         //  {
         //    Console.Write($"please enter element {i+1}: ");
         //    arr[i] = Convert.ToInt32(Console.ReadLine());
         // }

         // var average = arr.Average();
         // var lessThanAvgCount = 0;
        
         // foreach (var i in arr)
         // {
         //    if (i >= average)continue;
         //    lessThanAvgCount++;
         // }
         // Console.WriteLine($"{average} is the average");
         // Console.Write($"the numbers less than average are {lessThanAvgCount} number");

         // ---------------------------------------------------------

         // Task 13

         //    Console.Write("please enter a  size of list:");
         //   var size = Convert.ToInt32(Console.ReadLine());
         //   var arr = new int [size];
         //   for (int i = 0; i < arr.Length; i++)
         //   {
         //       Console.Write($"please enter element {i+1}: ");
         //       arr[i] = Convert.ToInt32(Console.ReadLine());
         //   }

         //   var average = arr.Average();
         //   Console.Write("the numbers greater than avg are : " );
         //   foreach (var i in arr)
         //   {
          //       if (i>average)
         //       {
         //           Console.Write($"{i} ");
         //       }
          //   }
       }
    }
}
