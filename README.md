# QQLight_SDK_For_Csharp
> 作者：Fanx繁星 更新时间：2020-01-31  希望用过的朋友把不稳定的有漏洞的反馈给我，谢谢
#### 介绍
QQLight_SDK_For_Csharp
QQLight开发插件时使用到的SDK

#### 更新
[2020-01-23] QQLight_SDK_For_Csharp V1.0<br>
1.第一个版本没有更新...<br>

[2020-01-24] QQLight_SDK_For_Csharp V1.1<br>
1.取指定QQ名片赞数量时发生闪退<br>
2.取指定QQ等级时发生闪退<br>
3.取QQ性别时闪退<br>

[2020-01-25]QQLight_SDK_For_Csharp V1.2<br>
1.获取群信息闪退<br>
2.获取群介绍闪退复现<br>

[2020-01-25]QQLight_SDK_For_Csharp V1.3<br>
1.演示设置窗口换成API　DEMO测试

[2020-01-26]QQLight_SDK_For_Csharp V1.4<br>
1.修复APi_Send_Msg 发送两次消息后闪退<br>
2.更换DLL引用的方式<br>
3.修复除APi_Send_Msg外，其他闪退问题<br>
4.修复其他小问题<br>
5.添加Tools第一个功能<br>
6.添加邀请好友入群API<br>
7.演示窗口恢复缺少引用后显示不全<br>

[2020-01-31]QQLight_SDK_For_Csharp V1.5<br>

1.可以获取群公告列表

2.发布群公告，可选是否置顶和是否向新人推送

3.发布作业，可选择是否需要提交，可自定义科目

4.添加搜索电影资源的API接口

#### 软件架构

目标框架 .net Framework 4.5

目标平台 Windows x86

适用机器人：QQLight

#### 安装教程

克隆/下载 V1.0（[下载ZIP](https://github.com/2217892328/QQLightSDK_For_Csharp/archive/master.zip)）
使用VisualStudio打开（推荐vs2019）

#### 使用教程

开发教程：
具体请看QQLight开发文档：（[https://www.kancloud.cn/iporus/qqlight/1394267](https://www.kancloud.cn/iporus/qqlight/1394267)）

Csharp版本开发手册：（[https://github.com/2217892328/QQLightSDK_For_Csharp/wiki](https://github.com/2217892328/QQLightSDK_For_Csharp/wiki)）

构造插件：

1.在Information方法内修改插件的信息


2.修改解决方案属性，程序集名称设置为插件ID + .ql


3.通过API及事件，实现插件功能

ps:如需要使用到演示窗口，请将packages\DMSKIN\dmskin.dll放在QQLight根目录下。


#### 事件方法（代码有注释）

Event_Initialization<br>
Event_pluginStart<br>
Event_pluginStop<br>
Event_GetNewMsg<br>
Event_GetSystemMsg<br>
Event_GetQQWalletData<br>
Event_AdminChange<br>
Event_GroupMemberIncrease<br>
Event_GroupMemberDecrease<br>
Event_AddGroup<br>
Event_AddFrinend<br>
Event_FriendChange<br>
Event_FileArrive<br>
Event_Menu<br>

#### API方法
QLAPI.Api_GetMovieJson(String name,String page)   获取影视资源接口调用

#### 联系我
如果有什么小bug，欢迎来告诉我

联系QQ:2217892328

邮箱：fanxing@fanxs.cn

个人网站：www.fanxs.cn
