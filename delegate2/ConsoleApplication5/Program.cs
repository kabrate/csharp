using System;

delegate int NumberChange(int n);
namespace DelegateApp1
{
    class TestDelagate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            //创建委托实例
            NumberChange nc;
            NumberChange nc1 = new NumberChange(AddNum);
            NumberChange nc2 = new NumberChange(MultNum);
            nc = nc1;
            nc += nc2;
            //调用多播
            nc(5);
            Console.WriteLine("value of num:{0}",getNum());
            Console.ReadKey();
        }
    }
}

