using System.Runtime.InteropServices.Marshalling;

namespace C__02zhuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //让用户输入两个整数，然后再输入0-3之间的一个数，0代表加法，1代表减法，2代表乘法，3代表除法,
            //计算这两个数字的结果

            Console.WriteLine("请输入两个整数，每输完一个数按一下回车");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("然后再输入0 - 3之间的一个数,0代表加法，1代表减法，2代表乘法，3代表除法：");
            int c = int.Parse(Console.ReadLine());
            double d = 0;
            switch (c)
            {
                case 1:
                    d = a - b;
                    break;
                case 2:
                    d = a * b;
                    break;
                case 0:
                    d = a + b;
                    break;
                case 3:
                    if (b != 0)
                        d = (double)a / b;
                    else
                        d = double.NaN;
                    break;

                default:
                    Console.WriteLine("输入的数字无效");
                    break;

            }
            if (double.IsNaN(d))
                Console.WriteLine("结果为：无效的运算（除数不能为零）");
            else
                Console.WriteLine("结果为：" + d);
            

            //-----------------------------------方法2-------------------------------
            //// 提示用户输入两个整数
            //Console.WriteLine("请输入第一个整数：");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("请输入第二个整数：");
            //int num2 = int.Parse(Console.ReadLine());

            //// 提示用户输入0-3之间的一个数字
            //Console.WriteLine("请输入0-3之间的一个数字，0代表加法，1代表减法，2代表乘法，3代表除法：");
            //int operation = int.Parse(Console.ReadLine());

            //// 结果变量，用来存储运算结果
            //double result = 0;

            //// 使用switch表达式根据输入的operation选择运算
            //result = operation switch
            //{
            //    0 => num1 + num2, // 0代表加法
            //    1 => num1 - num2, // 1代表减法
            //    2 => num1 * num2, // 2代表乘法
            //    3 => num2 != 0 ? (double)num1 / num2 : double.NaN, // 3代表除法，注意除数不能为零
            //    _ => double.NaN // 如果输入不在0-3范围内，返回NaN（表示非法操作）
            //};

            //// 判断运算是否有效，并输出结果
            //if (double.IsNaN(result))
            //{
            //    Console.WriteLine("输入的运算无效或除数不能为零！");
            //}
            //else
            //{
            //    Console.WriteLine("运算结果是：" + result);

        }
    }
}
