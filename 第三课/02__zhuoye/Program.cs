namespace _02__zhuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //编写一个程序，要求用户从键盘输入2个float数,输出最大者------------------

            Console.WriteLine("Hello, World!");
            float a=float .Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("最大值为："+ a);
            }
            else
            {
                Console.WriteLine("最大值为："+ b);
            }





        }
    }
}
