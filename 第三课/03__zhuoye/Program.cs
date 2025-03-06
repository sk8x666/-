namespace _03__zhuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------从键盘输入一个算数运算式，使用if语句实现正确的算数运算，并输出运算结果。---------------


            Console.WriteLine("请输入一个算数运算式");
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            double num1 = double.Parse(b[0]);
            string operation = b[1];
            double num2 = double.Parse(b[2]);
            double c = 0;
            switch (operation)
            {
                case "+":
                    c = num1 + num2;
                    break;
                case "-":
                    c = num1 - num2;
                    break;
                case "*":
                    c = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        c = num2 / num1;
                    }
                    else
                    {
                        Console.WriteLine("除数不能为0！");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("该运算式是无效运算符");
                    return;

            }
            Console.WriteLine("运算结果为：" + c);




            ////------------------------------参考-------------------------------


            //// 提示用户输入一个简单的算术运算式
            //Console.WriteLine("请输入一个简单的算术运算式（例如：5 + 3）：");
            //string input = Console.ReadLine(); // 读取用户输入的内容

            //// 把输入的内容分成三部分：第一个数字、运算符、第二个数字
            //string[] parts = input.Split(' ');

            //// 把分出来的部分分别存到不同的变量里
            //double num1 = double.Parse(parts[0]); // 第一个数字
            //string operation = parts[1]; // 运算符（+、-、*、/）
            //double num2 = double.Parse(parts[2]); // 第二个数字

            //// 结果变量，用来存储运算后的结果
            //double result = 0;

            //// 根据运算符来判断要进行什么运算
            //switch (operation)
            //{
            //    case "+":
            //        result = num1 + num2; // 如果是加法
            //        break;
            //    case "-":
            //        result = num1 - num2; // 如果是减法
            //        break;
            //    case "*":
            //        result = num1 * num2; // 如果是乘法
            //        break;
            //    case "/":
            //        if (num2 != 0) // 检查除数是否为零
            //        {
            //            result = num1 / num2; // 如果除数不为零，进行除法
            //        }
            //        else
            //        {
            //            Console.WriteLine("除数不能为零！"); // 如果除数为零，提示错误
            //            return; // 结束程序
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("无效的运算符！"); // 如果输入的运算符不对，提示错误
            //        return; // 结束程序
            //}

            //// 输出运算结果
            //Console.WriteLine("运算结果是：" + result);




        }
    }
}
