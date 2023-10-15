using Microsoft.Data.SqlClient;
using NWCProject;
using NWCProject.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;
using Microsoft.EntityFrameworkCore;

namespace DemoApplication
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int sum = 0;
            int[] Result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {

                    sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        Result[0] = i;
                        Result[1] = j;
                        return Result;

                    }


                }


            }
            return Result;



        }

        public static bool Sum(int num1, int num2, out int sum)
        {

            if (num1 > 0 && num2 > 0)
            {
                sum = num1 + num2;
                return true;

            }
            sum = 0;
            return false;




        }


        public static string RemoveStars(string s)
        {
            Stack<char> result = new Stack<char>();


            for (int i = 0; i < s.Length; ++i)
            {

                if (s[i] != '*')
                {
                    result.Push(s[i]);

                }
                else
                {
                    if (result.Count != 0)
                        result.Pop();

                }

            }

            if (result.Count == 0)
            {
                s = "";
                return s;

            }
            string con = "";
            int sizestack = result.Count;
            char[] res = new char[sizestack];
            result.CopyTo(res, 0);
            for (int i = res.Length - 1; i >= 0; i--)
            {

                con += res[i];



            }


            return con;
        }


        public static int AfterMoreYear(int LemaikAge, int BobAge)
        {
            int x = 0;
            if (LemaikAge <= BobAge)
            {
                while (LemaikAge <= BobAge)
                {

                    LemaikAge = LemaikAge * 3;
                    BobAge = BobAge * 2;
                    x++;




                }
            }

            return x;


        }
        public static int PeakIndexInMountainArray(int[] arr)
        {
            int max = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; ++i)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;


                }

            }


            return index;


        }

        public static string RemoveLastAndFirstCharacter(string Word)
        {


            string newWord = "";
            for (int i = 1; i <= Word.Length - 2; ++i)
            {
                newWord += Word[i];


            }

            return newWord;


        }
        public static StringBuilder StringRepeat(string Word, int numberOfRepeat)
        {


            StringBuilder newWord = new StringBuilder();
            for (int i = 1; i <= numberOfRepeat; ++i)
            {
                newWord.Append(Word);


            }

            return newWord;


        }
        public static string RemoveStringSpaces(string Word)
        {


            string NewWord = "";
            for (int i = 1; i < Word.Length; ++i)
            {
                if (Word[i] == ' ')
                {

                }
                else
                {
                    NewWord += Word[i];


                }


            }

            return NewWord;


        }
        public static int NumberOfRepeatCharacter(string Word, char c)
        {


            int count = 0;
            for (int i = 1; i < Word.Length; ++i)
            {
                if (Word[i] == c)
                {
                    ++count;
                }



            }

            return count;


        }


        public static bool Zero_Fuel(double Distance_To_Pump, double mpg, double Fuel_Left)
        {

            double Result = mpg * Fuel_Left;
            if (Result >= Distance_To_Pump)
            {


                return true;
            }

            return false;


        }


        public static int[] ReturnRepeatedNumbers(int[] arr)
        {

            Dictionary<int, int> Map = new();
            for (int i = 0; i < arr.Length; i++)
            {


                int value;
                if (!Map.TryGetValue(arr[i], out value))
                {

                    Map.Add(arr[i], 1);
                }
                else
                {

                    ++value;
                    Map.Remove(arr[i]);
                    Map.Add(arr[i], value);

                }


            }
            int[] Arr = { };
            foreach (var item in Map)
            {

                Arr = Arr.Append(item.Value).ToArray();






            }
            return Arr;


        }



        public static int[] repeatNumber(int N, int M, int[] arr)
        {

            int[] Arr = new int[5];
            for (int i = 1; i <= N; ++i)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == i)
                    {
                        ++count;


                    }
                }
                Arr[i - 1] = count;


            }
            return Arr;

        }
        public static bool IsPlaindrome(int x)
        {
            int num = x;
            int temp = 0;
            if (x < 0)
            {
                return false;
            }
            while (x != 0)
            {
                temp = temp + (x % 10);
                x = x / 10;
                if (x != 0)
                    temp = temp * 10;






            }


            if (temp == num)
            {

                return true;

            }
            return false;





        }


        public static string ReplaceWords(string str, IList<string> dictionary)
        {

            List<string> newArr = new List<string>();

            string temp = "";

            for (int i = 0; i < str.Length; i++)
            {


                if (str[i] == ' ')
                {
                    newArr.Add(temp);
                    temp = "";
                    continue;



                }


                temp += str[i];




            }
            newArr.Add(temp);

            for (int i = 0; i < dictionary.Count; i++)
            {
                for (int j = 0; j < newArr.Count; j++)
                {

                    if (dictionary[i].Length > newArr[j].Length)
                    {

                        continue;


                    }
                    else
                    {


                        //string[] exceed = newArr[j].Split(dictionary[i]);

                        //if (exceed.Length != 1) {


                        //  str=  str.Replace(newArr[j], dictionary[i]);


                        //}





                    }



                }
            }
            return str;

        }



        public static string complete(IList<string> dictionary, string sentence)
        {

            var newsentance = sentence.Split(' ').ToList();

            for (int i = 0; i < dictionary.Count; i++)
            {

                for (int j = 0; j < newsentance.Count; j++)
                {
                    if (newsentance[j].StartsWith(dictionary[i]) || newsentance[j] == dictionary[i])
                    {

                        newsentance[j] = dictionary[i];
                    }

                }

            }
            string newstring = "";

            for (int i = 0; i < newsentance.Count; i++)
            {
                if (i == newsentance.Count - 1)
                {
                    newstring += newsentance[i];


                }
                else
                {
                    newstring += newsentance[i] + " ";

                }

            }

            return newstring;

        }
        public static int FindKthPositive(int[] arr, int k)
        {
            int count = 0;
            bool isfind = false;
            int i = 1;
            while (count != k)
            {

                for (int j = 0; j <= arr.Length - 1; j++)
                {

                    if (i == arr[j])
                    {
                        isfind = true;

                    }



                }
                if (isfind)
                {

                    isfind = false;


                }
                else
                {

                    ++count;

                }

                ++i;


            }


            return i - 1;





        }
        public static int CountDistinctIntegers(int[] nums)
        {

            Dictionary<int, int> Numbers = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                int res = 0;
                int l;
                if (!Numbers.TryGetValue(nums[i], out l))
                {
                    Numbers.Add(nums[i], nums[i]);
                }
                int item = nums[i];
                while (item != 0)
                {

                    res = res + (item % 10);

                    item = item / 10;
                    if (item == 0)
                        break;
                    res = res * 10;

                }
                int j;
                if (!Numbers.TryGetValue(res, out j))
                {

                    Numbers.Add(res, res);


                }




            }
            return Numbers.Count;



        }



        public static int MaxCoins(int[] nums)
        {
            List<int> list = nums.ToList();
            int i = 0;
            int sum = 0;
            List<int> indexes = new List<int>();
        

            for (int j = 0; j < list.Count - 1; j++)
            {

                int prev = 0;
                int next = 0;
                if ((j - 1) < 0 || (j - 1) > nums.Length - 1)
                {
                    prev = 1;

                }
                if ((j + 1) < 0 || (j + 1) > nums.Length - 1)
                {

                    next = 1;


                }
                if (next == 0 && prev == 0)
                {

                    indexes.Add(list[j]);

                }

            }

            while (list.Count != 0)
            {

                int prev = 0;
                int next = 0;
                if (((i - 1) < 0 || (i - 1) > list.Count - 1) && ((i + 1) < 0 || (i + 1) > list.Count - 1))
                {


                    sum = (1 * list[i] * 1) + sum;
                    list.Remove(list[i]);
                    continue;

                }
                if ((i - 1) < 0 || (i - 1) > list.Count - 1)
                {
                    prev = 1;
                    if (indexes.Count == 0)
                    {
                    
                        if (list.Min() == list[i])
                        {
                            sum = (prev * list[i] * list[i + 1]) + sum;
                            list.Remove(list[i]);
                            i = 0;
                            continue;
                        }
                        i++;
                        continue;
                    }

                }
                if ((i + 1) < 0 || (i + 1) > list.Count - 1)
                {
                    next = 1;
                    if (list.Min() == list[i])
                    {
                        sum = (list[i - 1] * list[i] * next) + sum;
                        list.Remove(list[i]);
                        i = 0;
                        continue;
                    }
                    i++;
                    continue;
                }
                if (next == 0 && prev == 0)
                {
                    if (indexes.Count != 0)
                    {
                     
                        Dictionary<int, int> Sums = new Dictionary<int, int>();

                        for (int k = 1; k <= list.Count-2; k++) {

                          
                            Sums.Add(k, list[k - 1] * list[k + 1]);


                        }
                       
                        var maxValueKey = Sums.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                        var m = list[maxValueKey];
                          sum = (Sums.Values.Max()* m) + sum;
                        indexes.Remove(list[maxValueKey]);
                            list.Remove(list[maxValueKey]);
                            i = 0;
                       

                    }
                    continue;
                }

                i++;
            }
        return sum;

        }



        public static int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
        public static void permutation(int[] nums , List<int> PossibleResults) {
        
        
        
        
        
        }
        static void Main(string[] args)
        {
            // StringBuilder newString = StringRepeat("mohamed",9);
            //Console.WriteLine( RemoveStringSpaces("           ahmed        said"));
            // Console.WriteLine(newString);
            // Console.WriteLine(NumberOfRepeatCharacter("Allolllllllooooo", 'o'));
            //Console.WriteLine( Zero_Fuel(90, 2, 40));
            // int[] arr = { 1,2,3,4,5,3,2,1,5,3 };
            //var s = ReturnRepeatedNumbers(arr);
            // foreach (var item in s) {

            //     Console.WriteLine($"{item}");
            // }

            //     string x = "le absbs bbab cadsfafs";
            //     List<string> dictionary = new() { "catt", "cat", "bat", "rat" };
            //     complete(dictionary, "the cattle was rattled by battery");
            //     Console.WriteLine(complete(dictionary, "the cattle was rattled by battery"));

            //     int[] arr = { 1, 2, 3, 4 };
            //var t =   FindKthPositive(arr, 2);

            //     SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=company;Integrated Security= True");
            //     string sqlCommand = "SELECT Empno from employee";
            //   var result= sql.Query(sqlCommand).FirstOrDefault();
            //     //result.ForEach(i => Console.WriteLine(i));
            //     Console.WriteLine(result);
            //int[] arr = { 35, 16, 83, 87, 84, 59, 48, 41, 20 };
            //var p = MaxCoins(arr);
            //// CountDistinctIntegers(arr);
            //int i = 3;
           var star = ClimbStairs(5);
            TrieNode N = new TrieNode();
            TrieNode.root = N;

            //TrieNode.Insert("ahmedo");
            //TrieNode.Insert("ahmed");
            //var s =  TrieNode.search("ahmed");
            string[] arr = { "flower", "flow", "flight" };
           string patt= TrieNode.LongestCommonPrefix(arr);
            char id = '4';
       
        // var query= dbcontext?.NWC_Invoices?.FromSqlInterpolated($"select * from NWC_Invoices where Invoice_Number=4").FirstOrDefault();

            //if ((i - 1) < 0 || (i - 1) > arr.Length - 1)
            //{

            //    arr[i - 1] = 1;
            //    Console.WriteLine("out of range");

            //}
            //for(int i = 0; i < 4; i++)
            //{

            //    if (i > 2)
            //        break;
            //    for (int j = 0; j < 5; j++) {

            //        Console.WriteLine(i*j);
            //        if (j == 3)
            //            break;


            //    }


            //}

            //int o = 123456;
            //int res = 0;
            //while (o != 0) {

            //    res=res+(o % 10);

            //    o = o / 10;
            //    if (o == 0)
            //        break;
            //    res = res * 10;

            //}
            ////res = res / 10;
            //Console.WriteLine(res);


            //var res=   repeatNumber(5, 10, arr);




        }
    }
}