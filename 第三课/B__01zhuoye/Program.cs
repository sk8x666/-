using static System.Runtime.InteropServices.JavaScript.JSType;

namespace B__01zhuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //某城市普通出租车收费标准如下："起步里程3公里，起步费10元；超起步里程后10公里内，每公里租费2元，
            //超过10公里以上的部分加收50%的回空补贴费，即每公里租费3元。营运过程中，因路阻及乘客要求临时停车的，
            //每5分钟按1公里租费计收。运价计费尾数四舍五入，保留到元。"。编写程序，输入行驶里程(公里)与等待时间(分钟)，计算并输出乘客应支付的车费(元)。
            //输入输出示例：括号内是说明
                   // 输入

               // 3.1 6(行驶3.1公里, 等待6分)

               // 输出
               // cost = 13
               //-----------------------------------------------------------------------------------------



            Console.WriteLine("请输入你的你的里程公里数：");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的等待时间：");
            int b = int.Parse(Console.ReadLine());
            float  c = 0;
            float d = 0;
            float  e = 0;
            float f = 0;
            float g = b / 5;
            float h = 0;
            switch (a)
            {
                case >= 3 and < 10:
                    c = 10;
                    d = 2;
                    e = a-3;
                    break;
                case > 10:
                    c = 10;
                    d = 2;
                    f = 3;
                    e = a-10;
                    break;

                  
                
            }
            switch (b)
            {
                case >= 5:
                    h = g * 3;
                    break;
                case < 5:
                    h = 0;
                    break;
            }
            float i = c + e * d + f * e + h;


            Console.WriteLine("cost:"+ $"{i:0}");
            
        
                    
            


        }
    }
}
