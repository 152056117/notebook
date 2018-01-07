using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace note
{
    class connection
    {
         public static string GetConnString()
        {
            string sqlconnStringMode1 = System.Configuration.ConfigurationManager.AppSettings["connect2"];
            //在配置文件中添加connectionStrings节中的MyConnectionStringMode2后，必须双击项目中“Properties”下的“Settings.settings”添加并保存才能正常读取连接字符串配置
            string sqlconnStringMode2 = Properties.Settings.Default["connect1"].ToString();
            if (sqlconnStringMode1 == null)
            {
                return null;
            }
            else
            {
                return sqlconnStringMode1;
            }
        }
    }
}
