using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnote
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            New new1 = new New(user);
            Save save = new Save(user);
            Open open = new Open(user);
            Manager manager = new Manager(user);
            Leave leave = new Leave(user);
            string  flag = "T";
            while (flag == "T")
            { 
            Console.WriteLine("                  欢迎使用！");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-                 1.新建笔记                    -");
            Console.WriteLine("                  2.保存笔记                    -");
            Console.WriteLine("                  3.打开笔记                    -");
            Console.WriteLine("-                 4.分类管理                    -");
            Console.WriteLine("-                 5.退出                        -");
            Console.WriteLine("-------------------------------------------------");
            Console.Write("请输入要进行的操作（1-5）：");
           int num = int.Parse(Console.ReadLine());//从键盘输入操作         
           user.Message(num);
           flag = "f";
          // Console.ReadLine();
         Console.WriteLine("是否继续(T继续，其他键退出)");
           flag = Console.ReadLine();

            //switch(order)
            //{
            //    case 1:
            //        New new1 = new New();
            //        new1.newnote();                  
            //        break;
            //    case 2:
            //        Save save1 = new Save();
            //        save1.savenote();
            //        break;
            //    case 3:
            //        Open open1 = new Open();
            //        open1.opennote();
            //        break;
            //    case 4:
            //        Manager manager1 = new Manager();
            //        manager1.managernote();
            //        break;
            //    case 5:
            //        Leave leave1 = new Leave();
            //        leave1.leavenote();
            //        break;
            //        flag = false;
            //            break;
            //    default:
            //        Console.WriteLine("输入有误，请重试！"); 
            //        break;



            //}

            

        }
    }}
}
