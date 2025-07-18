namespace assignment44
{
    internal class assignment
    {
        static void Main(string[] args)
        {
            #region q1
            //int n = int.Parse(Console.ReadLine());
            //if (n % 3 == 0 && n % 4 == 0) Console.WriteLine("Yes");
            //else Console.WriteLine("No");

            #endregion
            #region q2
            //int n = int.Parse(Console.ReadLine());
            //string ms;
            //ms = n switch
            //{
            //    > 0 => "Positive",
            //    < 0 => "negative"
            //};
            //Console.WriteLine(ms);
            #endregion
            #region q3
            //int n, m, k;
            //int.TryParse(Console.ReadLine(), out n);
            //int.TryParse(Console.ReadLine(), out m);
            //int.TryParse(Console.ReadLine(), out k);
            //int minn = n,maxx = n;

            //if (m < n) minn = m;
            // if (k < n) minn = k;
            //Console.WriteLine($"Min element ={minn}");
            //if (m >maxx) maxx = m;
            // if (k > maxx) maxx = k;
            //Console.WriteLine($"Max element{maxx}");



            #endregion
            #region q4
            //int n = int.Parse(Console.ReadLine());
            //if(n%2==0) Console.WriteLine("even number");
            //else Console.WriteLine("odd numbers");


            #endregion
            #region q5
            //char s = char.Parse(Console.ReadLine());
            //if (s == 'a' || s == 'e' || s == 'I' || s == 'u' || s == 'o' || s == 'A' || s == 'E' || s == 'i' || s == 'u' || s == 'O')
            //    Console.WriteLine("vowel");
            //else Console.WriteLine("constant");
            #endregion
            #region q6
            //int n = int.Parse(Console.ReadLine());
            //for(int i=1;i<=n;i++) Console.WriteLine(i);
            #endregion
            #region q7
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++) {

            //    Console.WriteLine(n*i); }
            #endregion
            #region q8
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++) {
            //    if(i%2==0)
            //    Console.WriteLine(i); }
            #endregion
            #region q9
            //int n = int.Parse(Console.ReadLine());
            //int power = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < power; i++) {
            //    result *= n;
            //}
            //Console.WriteLine(result);
            #endregion



            #region q10
            //int sum = 0;
            //for(int i = 0; i < 5; i++)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    sum += n;
            //}
            //Console.WriteLine("total sum"+sum );
            //Console.WriteLine("average"+sum/5);
            #endregion
            #region q11
            //int month = int.Parse(Console.ReadLine());
            //switch(month){
            //    case 1:  
            //    case 3:  
            //    case 5:  
            //    case 7:  
            //    case 8:  
            //    case 10: 
            //    case 12:
            //        Console.WriteLine(31);
            //        break;
            //        case 2:
            //    case 4:  
            //    case 6:  
            //    case 9:  
            //    case 11:
            //        Console.WriteLine(30);
            //        break;




            //}



            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //Char O = char.Parse(Console.ReadLine());
            //switch (O) { 
            //case '+':
            //        Console.WriteLine(n+m);
            //        break;
            //    case '-':
            //        Console.WriteLine(n - m);
            //        break;
            //    case '*':
            //        Console.WriteLine(n * m);
            //        break;
            //    case '/':
            //        Console.WriteLine(n / m);
            //        break;



            //}
            #endregion
            #region 13
            //string s=Console.ReadLine();
            //for(int i=s.Length-1;i>=0;i--)
            //{
            //    Console.WriteLine(s[i]);
            //}


            #endregion

            #region 14
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i < end; i++)
            { bool t = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) { t = false;break; }
                }
                if (t) Console.WriteLine(i);
            }
            #endregion





        }
    }
}
