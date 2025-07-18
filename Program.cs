using System.Text;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 10;//boxing
            #region evaluation on switch in c#7
            //switch (obj)
            //{
            //    case int value://unboxing

            //        Console.WriteLine("Positive integer: " + value);
            //        break;
            //    case string value:
            //        Console.WriteLine("String: " + value);
            //        break;
            //    case decimal value:
            //        Console.WriteLine("Decimal: " + value);
            //        break;
            //    case double value:

            //        Console.WriteLine("Double: " + value);
            //        break;
            //    case float value:
            //        Console.WriteLine("Float: " + value);
            //        break;
            //    case bool value:
            //        Console.WriteLine("Boolean: " + value);
            //        break;
            //    default:

            //        Console.WriteLine("Unknown type: " + obj.GetType());
            //        break;
            //}
            #endregion

            #region switch with when clause
            //switch (obj)
            //{
            //    case int value when value >= 10:
            //        Console.WriteLine("Positive integer: " + value);
            //        break;
            //    case string value when value == "Hello":
            //        Console.WriteLine("String: " + value);
            //        break;
            //    case decimal value when value > 0:
            //        Console.WriteLine("Decimal: " + value);
            //        break;
            //    case double value when value > 0.0:
            //        Console.WriteLine("Double: " + value);
            //        break;
            //    case float value:
            //        Console.WriteLine("Float: " + value);
            //        break;
            //    case bool value:
            //        Console.WriteLine("Boolean: " + value);
            //        break;
            //    default:
            //        Console.WriteLine("Unknown type: " + obj.GetType());
            //        break;
            //}
            #endregion

            #region pattern matching without alies name 
            //switch(obj)
            //{
            //    case int when (int) obj >= 10://must casting //casting here is save because we check first if it is int then cast 
            //        Console.WriteLine("Positive integer greater than 10");
            //        break;
            //        case string when (string)obj == "Hello":
            //        Console.WriteLine("String is Hello");
            //        break;
            //        case decimal when (decimal)obj > 0:     
            //        Console.WriteLine("Decimal is positive");
            //        break;
            //        case double when (double)obj > 0.0:
            //        Console.WriteLine("Double is positive");
            //        break;
            //        case float when (float)obj > 0.0f:
            //        Console.WriteLine("Float is positive");
            //        break;
            //    default:
            //                            Console.WriteLine("Unknown type or value: " + obj.GetType());
            //        break;

            //}
            #endregion


            #region SWitch case befor switch expression pattern 
            //string option =Console.ReadLine();
            //string message;
            //switch(option)
            //{                 case "1":
            //        message = "You selected option 1";
            //        break;
            //    case "2":
            //        message = "You selected option 2";
            //        break;
            //    case "3":
            //        message = "You selected option 3";
            //        break;
            //    default:
            //        message = "Invalid option selected";
            //        break;
            //}
            #endregion
            #region SWitch case befor switch expression pattern 
            //string option = Console.ReadLine();
            string message;
            //message=option switch
            //{
            //    "1" => "You selected option 1",
            //    "2" => "You selected option 2",
            //    "3" => "You selected option 3",
            //    _ => "Invalid option selected"
            //};
            //Console.WriteLine(message);

            //Person obj2 = new Person()
            //{ Id = 1, Name = "John", Age = 30 };
            //message = obj2 switch
            //{
            //    { Id: 1, Name: "John", Age: >30 } => "Person is John with Id 1 and Age 30",
            //    { Id: 2, Name: "Jane", Age:< 25 } => "Person is Jane with Id 2 and Age 25",

            //    _ => "Unknown person"
            //};
            //Console.WriteLine(message);
            //int number = 10;
            //message =number switch
            //{
            //    >=10 => "Positive number",
            //    < 0and <-1 => "Negative number",
            //    0 => "Zero",
            //    _ => "Unknown number"
            //};

            #endregion
            #region String
            #region example1
            //string name="ahmed";//string is immutable
            //Console.WriteLine(name.GetHashCode());
            //name = "Alaa";
            //Console.WriteLine(name.GetHashCode());

            //string name;//declare for reference from type string 
            ////defult value of string is null
            ////clr will allocate 4 bytes for reference to string name in stack
            ////0 bytes allocated for string in heap
            //name = "ahmed";//now string is allocated in heap and reference is assigned to name variable
            //string name2 = "ahmed";
            ////two strings with same value will point to same location in heap
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine(name2.GetHashCode());

            #endregion

            #region example2
            //string name1 = "ahmed";
            //string name2 = "alaa";
            ////two strings with different values will point to different locations in heap   
            //Console.WriteLine("before assign operator");
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2.GetHashCode());
            //name1 = name2;//now name1 will point to same location in heap as name2
            //Console.WriteLine("after assign operator");
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2.GetHashCode());
            //name1 = "hana";
            ////now name1 will point to new location in heap because change in value and name2 will point to same location in heap
            //Console.WriteLine("after edit on string");
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2.GetHashCode());
            #endregion
            #region Example3
            //string name1 = "ahmed";
            //Console.WriteLine("before concat");
            //Console.WriteLine(name1.GetHashCode());
            //name1+= "alaa";//this will create new string in heap and name1 will point to new location in heap
            //               //any change on string will create new string in heap and reference will point to new location in heap
            //Console.WriteLine("after concat");
            //Console.WriteLine(name1.GetHashCode());
            #endregion
            #region STRING METHOUDS
            //string ms = " hello world";
            //Console.WriteLine(ms.Length);//return length of word with spaces in it
            //Console.WriteLine(ms.ToLower());
            //Console.WriteLine(ms.ToUpper());
            //Console.WriteLine(ms.Trim());//remove additional spaces
            //Console.WriteLine(ms.TrimEnd());
            ////remove additional spaces from end 
            //Console.WriteLine(ms.TrimStart());
            ////remove additional spaces from end 
            //Console.WriteLine(ms.Substring(0,3));
            ////cut string and return it
            //Console.WriteLine(ms.Replace('o','k'));
            ////replace ocharcter with another
            //Console.WriteLine(ms.Contains('w'));
            ////return true or false 


            #endregion

            #endregion


            #region String builder
            StringBuilder sb = new StringBuilder("hello girles");
            sb.Append(" how are you?");//append string to string builder
            sb.AppendLine(" I am fine");//append string to string builder and add new line
            sb.Insert(0, "hi");//insert string at index 0
            //shift all characters to right not replace them
            sb.Remove(0, 2);//remove string from index 0 to index 2
            //remove string from index 0 to index 2
            Console.WriteLine(sb.ToString());//convert string builder to string
            //StringBuilder is mutable and can be changed without creating new object in heap
            //StringBuilder is more efficient than string when concatenating multiple strings
            sb.Clear();//clear string builder
            sb.AppendFormat("");
            //append formatted string to string builder
            sb.AppendJoin('_',"ahmed", "ali");
            //append multiple strings with separator
            Console.WriteLine(sb);



            #endregion
        }
    }
}
