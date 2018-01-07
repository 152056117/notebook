using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnote
{
    public  delegate void MessageEventsend(int num);
   public  class User
    {
       public event MessageEventsend MessgeEvent;
       public void Message(int num)
       {
           Console.WriteLine("用户选择了操作{0}", num);
           if (MessgeEvent != null)
           {
               MessgeEvent(num);
           }


       }
    }
}
