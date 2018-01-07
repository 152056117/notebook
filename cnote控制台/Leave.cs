using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnote
{
    class Leave
    {
        User user;
        public Leave(User user){
            this.user = user;
            user.MessgeEvent += new MessageEventsend(leavenote);
        }
        public void leavenote(int num)
        {
            if (num == 5)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
    }
}
