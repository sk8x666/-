namespace _05__zhuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 提示用户输入生日日期
            Console.WriteLine("请输入您的生日（格式：YYYY-MM-DD）：");
            string input = Console.ReadLine(); // 读取用户输入

            DateTime birthDate;

            // 尝试将用户输入的字符串转换为日期
            if (DateTime.TryParse(input, out birthDate))
            {
                // 根据生日确定星座
                string zodiacSign = GetZodiacSign(birthDate);
                Console.WriteLine("您的星座是：" + zodiacSign); // 输出星座
            }
            else
            {
                // 如果用户输入的不是有效的日期格式
                Console.WriteLine("您输入的日期格式不正确，请使用 YYYY-MM-DD 格式。");
            }
        }

        static string GetZodiacSign(DateTime date)
        {
            int month = date.Month; // 获取月份
            int day = date.Day; // 获取日期

            // 使用 switch 表达式根据月份和日期判断星座
            return (month, day) switch
            {
                (1, <= 19) => "摩羯座",
                (1, > 19) => "水瓶座",
                (2, <= 18) => "水瓶座",
                (2, > 18) => "双鱼座",
                (3, <= 20) => "双鱼座",
                (3, > 20) => "白羊座",
                (4, <= 19) => "白羊座",
                (4, > 19) => "金牛座",
                (5, <= 20) => "金牛座",
                (5, > 20) => "双子座",
                (6, <= 21) => "双子座",
                (6, > 21) => "巨蟹座",
                (7, <= 22) => "巨蟹座",
                (7, > 22) => "狮子座",
                (8, <= 22) => "狮子座",
                (8, > 22) => "处女座",
                (9, <= 22) => "处女座",
                (9, > 22) => "天秤座",
                (10, <= 23) => "天秤座",
                (10, > 23) => "天蝎座",
                (11, <= 22) => "天蝎座",
                (11, > 22) => "射手座",
                (12, <= 21) => "射手座",
                (12, > 21) => "摩羯座",
                _ => "无效的日期" // 默认情况
            };
        }
    }
}
