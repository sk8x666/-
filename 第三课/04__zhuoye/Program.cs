namespace _04__zhuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一个成绩(0到100之间的整数),如果大于等于90输出: 优秀; 小于90而大于等于80输出: 良好;
            //小于80而大于等于70输出: 一般; 小于70而大于等于60输出: 及格,否则输出: 不及格。


            Console.WriteLine("请输入你的成绩（0-100的整数）");
            int a = int .Parse(Console.ReadLine());
            switch (a)
            {
                case >= 90 and <= 100:
                    Console.WriteLine("优秀");
                    break;
                case < 90 and >= 80:
                    Console.WriteLine("良好");
                    break;
                case < 80 and >= 70:
                    Console.WriteLine("良好");
                    break;
                case < 70 and >= 60:
                    Console.WriteLine("良好");
                    break;
                default:
                    Console.WriteLine("不及格");
                    break;
            }
        }
    }
}
