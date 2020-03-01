# PirateZombie.SDK（最好使用 vs2019 打开）
> 作者：Fanx繁星 （[更新日志(http://ql.fanxs.cn/)）  希望用过的朋友把不稳定的有漏洞的反馈给我，谢谢
#### 介绍
QQLight_SDK_For_Csharp
QQLight开发插件时使用到的SDK

#### 软件架构

目标框架 .net Framework 4.5

目标平台 Windows x86

适用机器人：QQLight

#### 安装教程

克隆/下载 V1.0（[下载ZIP](https://github.com/2217892328/PirateZombie.SDK/archive/master.zip/wiki)）
使用VisualStudio打开（推荐vs2019）

#### 使用教程

开发教程：
具体请看QQLight开发文档：（[https://www.kancloud.cn/iporus/qqlight/1394267](https://www.kancloud.cn/iporus/qqlight/1394267)）

Csharp版本开发手册：（[https://github.com/2217892328/PirateZombie.SDK/wiki](https://github.com/2217892328/PirateZombie.SDK/wiki)）

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
