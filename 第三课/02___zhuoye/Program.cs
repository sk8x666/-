namespace _02___zhuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //编写一个程序，要求用户从键盘输入3个不同整数,输出中间者---------------


            Console.WriteLine("请输入3个不同的整数");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int e = a + b + c;
            int g = 0, h = 0;
            if (a > b && b > c)
            {
                 g = a;
                 h = c;
                
                
            }
            else if (b > c && c > a)
            {
                 g = b;
                 h = a;
                
               
            }
            else if (c > b && b > a)
            {
                 g = c;
                 h = a;
                
               
            }
            else if (a > c && c > b)
            {
                 g = a;
                 h = b;
                
                
            }
            else if (b > a && a > c)
            {
                 g = b;
                 h = c;
                
                
            }
            else if (c > a && a > b)
            {
                g = c;
                h = b;
                
                

            }
            int k = e - g - h;
            Console.WriteLine("中间值为：" + k);
            Console.WriteLine("最大值为：" + g);

            Console.WriteLine("最小值为：" + h);

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //// 计算三个数的和
            //int e = a + b + c;

            //// 定义变量 g 和 h 来存储最大值和最小值
            //int g = 0, h = 0;

            //// 使用 if-else 条件语句判断中间值
            //if (a > b && b > c)
            //{
            //    g = a;
            //    h = c;
            //}
            //else if (b > c && c > a)
            //{
            //    g = b;
            //    h = a;
            //}
            //else if (c > b && b > a)
            //{
            //    g = c;
            //    h = a;
            //}
            //else if (a > c && c > b)
            //{
            //    g = a;
            //    h = b;
            //}
            //else if (b > a && a > c)
            //{
            //    g = b;
            //    h = c;
            //}
            //else if (c > a && a > b)
            //{
            //    g = c;
            //    h = b;
            //}

            //// 计算中间值
            //int k = e - g - h;

            //// 输出中间值、最大值和最小值
            //Console.WriteLine("中间值为：" + k);
            //Console.WriteLine("最大值为：" + g);
            //Console.WriteLine("最小值为：" + h);




        }
    }
}
