using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cnote
{
    class Open
    {
        User user;
        public Open(User user)
        {
            this.user = user;
            user.MessgeEvent += new MessageEventsend(opennote);

        }
        public void opennote(int num)
        {
            if (num == 3)
            {
                Console.WriteLine("已经打开笔记");
                String Opentext = string.Empty;
                StreamReader sr = new StreamReader(@"C:\Users\93985\Desktop\book11111\cnote\bin\Debug\a.text");
                Opentext = sr.ReadToEnd();//调用该方法读取文件中的全部内容
                Console.WriteLine(Opentext);
                sr.Close();
                Console.ReadKey();
            }
            
        }
    }
}
