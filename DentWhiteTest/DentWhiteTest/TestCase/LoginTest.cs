﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using System.Threading;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
using DentWhiteTest.Contacts;

namespace WhiteFrameDemo.TestCase
{
    public class LoginTest
    {
        /// <summary>
        /// 启动客户端
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool Launch(out Window appWin, out string msg)
        {
            //启动客户端
            try
            {
                var startTime = DateTime.Now;
                TestStack.White.Application appTest = TestStack.White.Application.Launch(@"C:\Users\heygears\Desktop\德雅客户端\DentManager.Client.exe");
                appWin = appTest.GetWindow(SearchCriteria.ByAutomationId("docker_window"), InitializeOption.NoCache);
                var endTime = DateTime.Now;
                msg = "启动客户端--通过，用时：" + (endTime - startTime).TotalSeconds;
                return true;
            }
            catch (Exception e)
            {
                appWin = null;
                msg = "启动客户端--失败，原因：" + e.ToString();
                return false;
            }
        }

        

        /// <summary>
        /// 测试登录窗口,账号密码为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDocker_UserNull_PwdNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //账号和密码为空
                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));
                tbUser.Text = "";
                tdPwd.Text = "";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));

                //抓不到按钮，登录成功
                if (loginbt == null)
                {
                    msg = "测试登录窗口,账号密码为空--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                else
                {
                    msg = "测试登录窗口,账号密码为空--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }


            }
            catch (Exception e)
            {
                msg = "测试登录窗口,账号密码为空--失败，原因：" + e.ToString();
                Global.appWin.Close();
                return false;
            }
        }

        /// <summary>
        /// 测试登录窗口,账号为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDocker_UserNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //账号为空
                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));
                tbUser.Text = "";
                tdPwd.Text = "123456";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));

                //抓不到按钮，登录成功
                if (loginbt == null)
                {
                    msg = "测试登录窗口,账号为空--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                else
                {
                    msg = "测试登录窗口,账号为空--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }


            }
            catch (Exception e)
            {
                msg = "测试登录窗口,账号为空--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 测试登录窗口,成功登陆
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDocker_Success(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //账号：dent_bicheno
                //密码：123456789
                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));
                //Language.Set("en");
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                tbUser.Text = "dent_bicheno";
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);
                tdPwd.Text = "123456789";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));

                //抓不到按钮，登录成功
                if (loginbt == null)
                {
                    msg = "测试登录窗口,登陆不成功--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                else
                {
                    msg = "测试登录窗口,登陆成功--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试登录窗口,登陆失败--失败，原因：" + e.ToString();
                Global.appWin.Close();
                return false;
            }
        }


        /// <summary>
        /// 测试登录窗口,密码为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDocker_PwdNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //账号：dent_bicheno
                //密码：123456789
                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));
                //Language.Set("en");
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                tbUser.Text = "dent_bicheno";
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);
                tdPwd.Text = "";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));

                //抓不到按钮，登录成功
                if (loginbt == null)
                {
                    msg = "测试登录窗口,密码为空--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                else
                {
                    msg = "测试登录窗口,密码为空--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试登录窗口,密码为空--失败，原因：" + e.ToString();
                Global.appWin.Close();
                return false;
            }
        }



        //<-------------------------------------------------------------------------->华丽的分割线
        ///医院管理模块
        /// <summary>
        /// 测试登录窗口,成功登陆
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
    }
}
