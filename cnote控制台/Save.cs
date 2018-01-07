using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace cnote
{
    class Save
    {
        User user = new User();
        public Save(User user)
        {
            this.user = user;
            user.MessgeEvent += new MessageEventsend(savenote);

        }
        public void savenote(int num)
        {
            if (num == 2)
            {
                //Console.WriteLine("请输入笔记：");//
                // String text = Console.ReadLine();
                String text = New.text;
                string type = New.type;
                StreamWriter sw = new StreamWriter(@"C:\Users\93985\Desktop\book11111\cnote\bin\Debug\a.text");
                sw.WriteLine(type);
                sw.WriteLine(text);
                Console.WriteLine("笔记已保存成功");
                //sw.Close();
                //Console.ReadKey();
            }
        }
    }
}
