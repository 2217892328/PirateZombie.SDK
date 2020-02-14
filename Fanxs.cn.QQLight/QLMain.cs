using fanxs.cn;
using Fanxs.cn.QQLight.MainFrom;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Fanxs.cn.QQLight
{
    class QLMain
    {
        /**
         QQLight SDK For C# (Csharp)
         Author:Fanx繁星
         QQ:221789238
         Url:http://ql.fanxs.cn
         LICENSE: Apache License 2.0 http://www.apache.org/licenses/
        */
        public const int MSG_CONTINUE = 0; //消息_继续执行
        public const int MSG_INTERCEPT = 1; //消息_拦截
        public const int ASK_CONSENT = 1;  //请求_同意
        public const int ASK_REFUSE = 2; //请求_拒绝
        public const int ASK_NEGLECT = 3; //请求_忽略
        public static string cjPath = "";  //插件目录
        public static int ac = 0;
        public static Form1 ff = new Form1(); //设置窗口
        public static repair re = new repair();


        // public string Informati();
        [DllExport("Information", CallingConvention = CallingConvention.Winapi)]
        public static string Information(int authCode)
        {
            ac = authCode;

            string szPluginInfo = "{\r\n" +

            "\"plugin_id\":\"fanxs.cn\",   //插件ID\r\n" +

            "\"plugin_name\":\"C#SDK_DEMO_API\",        //插件名称\r\n" +

            "\"plugin_author\":\"Fanx繁星\",         //插件作者\r\n" +

            "\"plugin_version\":\"1.5.2\",         //插件版本号\r\n" +

            "\"plugin_brief\":\"c#SDK_API演示，有些功能需要Pro支持，请确保您的框架版本为pro版本\",        // \\r代表换行\r\n" +

            "\"plugin_sdk\":\"1\",                 //SDK版本代号，固定值\r\n" +

            "\"plugin_menu\":\"true\"             //留空或者false代表无设置窗口，载入窗口请写在子程序 Event_Menu 内\r\n" +

            "}";

            return (szPluginInfo);
        }

        //
        //* 初始化插件，插件加载时会调用此事件
        //

        [DllExport("Event_Initialization", CallingConvention = CallingConvention.Winapi)]
        public static int Event_Initialization()
        {
            return 0;
        }

        //
        //* 插件被启用时调用此事件，机器人登录时如果插件开关是开启状态，此事件也会发生一次
        //

        //ORIGINAL LINE: int __Winapi Event_pluginStart()
        [DllExport("Event_pluginStart", CallingConvention = CallingConvention.Winapi)]
        public static int Event_pluginStart()
        {
            QLAPI.init();//初始化API，不可删除
            QLAPI.Api_SendLog("调试信息", "初始化API成功，运行目录：" + Application.StartupPath, 3, ac);
            QLAPI.CoInitialize(0);
            return 0;
        }

        //
        //* 插件被关闭时调用此事件,用来销毁运行中的线程或者其它资源
        //

        //ORIGINAL LINE: int __Winapi Event_pluginStop()
        [DllExport("Event_pluginStop", CallingConvention = CallingConvention.Winapi)]
        public static int Event_pluginStop()
        {

            QLAPI.CoUninitialize();
            return 0;
        }

        //
        //* 收到消息(好友/群/群临时/讨论组/讨论组临时消息/QQ临时消息/系统消息)时触发该事件
        //* type：1.好友消息 2.群消息 3.群临时消息 4.讨论组消息 5.讨论组临时消息 6.QQ临时消息
        //* GroupID： 类型为1或6的时候，此参数为空，其余情况下为 群号或讨论组号
        //* FromQQ：消息的来源对象
        //* Msg：消息内容
        //* MsgID：机器人用来撤回该消息时的ID
        //

        [DllExport("Event_GetNewMsg", CallingConvention = CallingConvention.Winapi)]
        public static int Event_GetNewMsg(int type, string GroupID, string FromQQ, string Msg, string MsgID)
        {
            QLAPI.Api_SendLog("收到信息", string.Format("type:{0},GroupID:{1},FromQQ:{2},Msg:{3},MsgID:{4}", type, GroupID, FromQQ, Msg, MsgID), 0, ac);
            return MSG_CONTINUE;

            // MSG_INTERCEPT 代表拦截消息不传递到下一个插件，插件的优先级可以通过拖拽插件列表来调整  
        }



        //
        //* 收到系统消息(Cookies更新，群内禁言，名片更改等一系列系统类消息)时触发该事件
        //* Type 1.群禁言事件 2.群名片更改事件 3.群名被更改事件 4.讨论组名称被更改事件 5.Cookies更新事件 6.好友个性签名变更 7.好友新说说提醒 
        //*      10.好友消息撤回 11.群消息撤回 12.群临时消息撤回 13.讨论组消息撤回 14.讨论组临时消息撤回
        //* GroupID 群号/讨论组号  
        //* Msg 消息内容
        //

        [DllExport("Event_GetSystemMsg", CallingConvention = CallingConvention.Winapi)]
        public static int Event_GetSystemMsg(int type, string groupId, string msg)
        {

            return MSG_CONTINUE;
        }

        //
        //* QQ财付通转账事件
        //* Type：1.好友转账 2.群临时转账 3.讨论组临时转账
        //* GroupID：类型1.此参数为空 2.群号 3.讨论组号
        //* QQID：转账的QQ
        //* Number：转账金额
        //* Info：QQ转账对方备注
        //* OrderID：QQ转账获取的订单号
        //
        [DllExport("Event_GetQQWalletData", CallingConvention = CallingConvention.Winapi)]
        public static int Event_GetQQWalletData(int type, string GroupID, string FromQQ, string Sum, string Msg, string Order)
        {
            return MSG_CONTINUE;
        }

        //
        //* 管理员变动事件
        //* type 1.xx被添加管理 2.xx被解除管理
        //* GroupID 群号
        //* FromQQ 来源QQ
        //

        [DllExport("Event_AdminChange", CallingConvention = CallingConvention.Winapi)]
        public static int Event_AdminChange(int type, string GroupID, string FromQQ)
        {


            return MSG_CONTINUE;
        }

        //
        //* 群成员增加事件
        //* type 1.主动入群  2.被xxx邀请入群
        //* GroupID 群号
        //* JQQ 加入的QQ
        //* OQQ 操作者QQ 类型为1.管理员 2.邀请人
        //

        [DllExport("Event_GroupMemberIncrease", CallingConvention = CallingConvention.Winapi)]
        public static int Event_GroupMemberIncrease(int type, string GroupID, string JQQ, string OQQ)
        {


            return MSG_CONTINUE;
        }

        //
        //* 群成员减少事件
        //* type 1.主动退群  2.被xxx踢出群
        //* GroupID 群号
        //* EQQ 退群的QQ
        //* OQQ 操作者QQ 类型为1时参数为空
        //

        [DllExport("Event_GroupMemberDecrease", CallingConvention = CallingConvention.Winapi)]
        public static int Event_GroupMemberDecrease(int type, string GroupID, string EQQ, string OQQ)
        {
            return MSG_CONTINUE;
        }

        //
        //* 群添加事件
        //* type 1.主动加群  2.被邀请进群 3.机器人被邀请入群
        //* GroupID 群号
        //* QQ QQ号
        //* IQQ 邀请者QQ 类型为1时参数为空
        //* additional 加群者的附加信息，类型为2，3时参数为空
        //* Seq 群添加事件产生的Seq标识
        //

        [DllExport("Event_AddGroup", CallingConvention = CallingConvention.Winapi)]
        public static int Event_AddGroup(int type, string GroupID, string QQ, string IQQ, string additional, string Seq)
        {
            return MSG_CONTINUE;
        }

        //
        //* 被添加好友事件
        //* QQ QQ号
        //* Msg 好友添加理由
        //

        [DllExport("Event_AddFrinend", CallingConvention = CallingConvention.Winapi)]
        public static int Event_AddFrinend(string QQ, string Msg)
        {
            return MSG_CONTINUE;
        }

        //
        //* 好友变动事件（包含成为单向好友，双向好友，被好友删除）
        //* type 1.成为好友（单向） 2、成为好友（双向） 3、解除好友关系
        //

        [DllExport("Event_FriendChange", CallingConvention = CallingConvention.Winapi)]
        public static int Event_FriendChange(int type, string qq)
        {
            return MSG_CONTINUE;
        }

        //
        //*  接收到离线文件
        //* Type 1.好友离线文件 2.群文件 3、讨论组文件
        //* GroupID 类型为2，3时为别为群号、讨论组号
        //* QQID 发文件的人
        //* FileName 文件名称
        //* FileSize 文件大小，单位 Byte
        //* FileMD5 文件MD5
        //* FileUrl 文件下载直链
        //* FileGUID 文件GUID，文件转发需用到
        [DllExport("Event_FileArrive", CallingConvention = CallingConvention.Winapi)]
        public static int Event_FileArrive(int Type, string GroupID, string QQID, string FileName, string FileSize, string FileMD5, string FileUrl, string FileGUID)
        {
            return MSG_CONTINUE;
        }

        //
        //* 插件设置窗口
        //

        [DllExport("Event_Menu", CallingConvention = CallingConvention.Winapi)]
        public static int Event_Menu()
        {

            //判断文件的存在
            if (System.IO.File.Exists(Application.StartupPath + @"\DMSkin.dll"))
            {
                QLAPI.Api_SendLog("调试信息", "打开设置窗口", 0, ac);
                if (ff.IsDisposed)
                {
                    ff = new Form1();
                }
                ff.Show();
            }
            else
            {
                QLAPI.Api_SendLog("调试信息", "未找到引用，载入恢复窗口", 0, ac);
                if (re.IsDisposed)
                {
                    re = new repair();
                }

                re.Show();
            }

            QLAPI.Api_SendLog("调试信息", "打开设置窗口", 0, ac);
            if (ff.IsDisposed)
            {
                ff = new Form1();
            }
            ff.Show();
            return 0;
        }

    }
}
