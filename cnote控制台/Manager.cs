using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace cnote
{
    class Manager
    {
        User user;
        public Manager(User user)
        {

            this.user = user;
            user.MessgeEvent += new MessageEventsend(managernote);
        }
        public void managernote(int num)
        {
            if (num == 4)
            {
                StreamReader sr = new StreamReader(@"C:\Users\93985\Desktop\book11111\cnote\bin\Debug\a.text");
                string type = sr.ReadLine();
                Console.WriteLine(type);
                sr.Close();
                Console.ReadKey();
            }
            
            
        }
    }
}
