using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cnote
{
    class New
    {
        User user;
        public New(User user){
            this.user = user;
            user.MessgeEvent += new MessageEventsend(newnote);

    }
        public  static string text;
        public static string type;
        public void newnote(int num)
        {
            if (num == 1) { 
            Console.Write("请输入笔记分类：");
            type =Console.ReadLine();
            Console.WriteLine("请输入笔记：");
            text = Console.ReadLine();
            //StreamWriter sw = new StreamWriter(@"C:\Users\93985\Desktop\book11111\cnote\bin\Debug\a.text", true);
            //sw.WriteLine("内容：");
            //sw.WriteLine(Console.ReadLine());
            //sw.Flush();
            //sw.Close();
            Console.WriteLine("笔记本已新建完成");
           // Console.ReadKey();
            }
        }
    }
}
