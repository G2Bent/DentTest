using DentWhiteTest.Contacts;
using WhiteFrameDemo.TestCase;
using TestStack.White.UIItems.WindowItems;

namespace WhiteFrameDemo.Module
{
    public class LoginModule
    {
        public static void LoginAllTest()
        {

            //登陆成功
            //启动一个客户端
            bool res_Launch = LoginTest.Launch(out Window appWin, out string msg);
            if (res_Launch)
            {
                Global.win_Dent = appWin;
                Global.LstInfo.Add(msg);
            }
            else
            {
                Global.LstInfo.Add(msg);
                return;
            }

            //测试登录窗口,登录成功
            res_Launch = LoginTest.LoginDocker_Success(Global.win_Dent, out string msg1);
            if (res_Launch)
            {
                Global.LstInfo.Add(msg1);
            }
            else
            {
                Global.LstInfo.Add(msg1);
                return;
            }

            //关闭客户端
            Global.win_Dent.Close();


            //登陆账号密码为空
            //启动一个客户端
            res_Launch = LoginTest.Launch(out Window appWin1, out string msg2);
            if (res_Launch)
            {
                Global.win_Dent = appWin1;
                Global.LstInfo.Add(msg2);
            }
            else
            {
                Global.LstInfo.Add(msg2);
                return;
            }

             //测试登录窗口,账号密码为空
            res_Launch = LoginTest.LoginDocker_UserNull_PwdNull(Global.win_Dent, out string msg3);
            if (res_Launch)
            {
                Global.LstInfo.Add(msg3);
            }
            else
            {
                Global.LstInfo.Add(msg3);
                return;
            }

            //关闭客户端
            Global.win_Dent.Close();

            //登陆账号为空
            //启动一个客户端
            res_Launch = LoginTest.Launch(out Window appWin2, out string msg4);
            if (res_Launch)
            {
                Global.win_Dent = appWin2;
                Global.LstInfo.Add(msg4);
            }
            else
            {
                Global.LstInfo.Add(msg4);
                return;
            }

            //测试登录窗口,账号为空
            res_Launch = LoginTest.LoginDocker_UserNull(Global.win_Dent, out string msg5);
            if (res_Launch)
            {
                Global.LstInfo.Add(msg5);
            }
            else
            {
                Global.LstInfo.Add(msg5);
                return;
            }

            //关闭客户端
            Global.win_Dent.Close();


            //登陆密码为空
            //启动一个客户端
            res_Launch = LoginTest.Launch(out Window appWin3, out string msg6);
            if (res_Launch)
            {
                Global.win_Dent = appWin3;
                Global.LstInfo.Add(msg6);
            }
            else
            {
                Global.LstInfo.Add(msg6);
                return;
            }

            //测试登录窗口,密码为空
            res_Launch = LoginTest.LoginDocker_PwdNull(Global.win_Dent, out string msg7);
            if (res_Launch)
            {
                Global.LstInfo.Add(msg7);
            }
            else
            {
                Global.LstInfo.Add(msg7);
                return;
            }

            //关闭客户端
            Global.win_Dent.Close();


        }
    }
}
