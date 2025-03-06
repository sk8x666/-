namespace C__01zhuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入四个整数,每输完一个数按一下回车");
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int max = a;
            int min = a;
            if (b > max)
            {
                max = b;
            }
            if (b < min)
            {
                min = b;
            }
            if (c > max)
            {
                max = c;
            }
            if (c < min)
            {
                min = c;
            }
            if (d > max)
            {
                max =d;
            }
            if (d < min)
            {
                min = d;
            }
            Console.WriteLine("最大值:"+ max);
            Console.WriteLine("最小值:" + min);


            //-----------------------------------方法2-------------------------------

        //    // 提示用户输入4个整数，每输入一个后按回车
        //Console.WriteLine("请输入4个整数，每输入一个后按回车：");

        //// 读取用户输入的4个整数，并把它们转换为整数类型
        //int num1 = int.Parse(Console.ReadLine()); // 第一个数字
        //int num2 = int.Parse(Console.ReadLine()); // 第二个数字
        //int num3 = int.Parse(Console.ReadLine()); // 第三个数字
        //int num4 = int.Parse(Console.ReadLine()); // 第四个数字

        //// 把所有的数字存储在一个数组中，方便后续处理
        //int[] numbers = { num1, num2, num3, num4 };

        //// 初始化最大值和最小值为数组中的第一个数字
        //int max = numbers[0];
        //int min = numbers[0];

        //// 使用循环，逐一检查每个数字是否比当前的最大值大，或者比当前的最小值小
        //foreach (int number in numbers)
        //{
        //    max = Math.Max(max, number); // 更新最大值
        //    min = Math.Min(min, number); // 更新最小值
        //}

        //// 输出最大值和最小值
        //Console.WriteLine("最大值为：" + max);
        //Console.WriteLine("最小值为：" + min);

        }
    }
}
