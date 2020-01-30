using System;

namespace Fanxs.cn.QQLight.FanxsTool
{
    class Qlvar
    {
        /**
        QQLight SDK For C# (Csharp)
        Author:Fanx繁星
        QQ:221789238
        Url:http://ql.fanxs.cn
        LICENSE: Apache License 2.0 http://www.apache.org/licenses/
       */


        /// <summary>
        /// 换行
        /// </summary>
        /// <returns></returns>
        public static String getLineFeed()
        {
            return " \r\n";
        }

        /// <summary>
        /// 图片：[QQ:pic=网络链接]、[QQ:pic=本地路径]、[QQ:pic=GUID]，GUID从收到的消息里面获得
        /// </summary>
        /// <param name="pic">网络链接，本地路径，GUID</param>
        /// <returns></returns>
        public static String getPic(String pic)
        {
            return "[QQ:pic=" + pic + "]";
        }

        /// <summary>
        /// 语音：[QQ:voice=网络链接]、[QQ:voice=本地路径]、[QQ:voice=GUID]
        /// </summary>
        /// <param name="voice"></param>
        /// <returns></returns>
        public static String getVoice(String voice)
        {
            return "[QQ:voice=" + voice + "]";
        }

        /// <summary>
        /// 表情：[QQ:emoji=xxxxx] xxxx代表emoji ID，如果不知道，可以从日志里面获得
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public static String getEmoji(String con)
        {
            return "[QQ:emoji=" + con + "]";

        }

        /// <summary>
        /// 小黄豆表情：[QQ:face=xxxx] xxxx代表表情ID，如果不知道，可以从日志里面获得
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public static String getFace(String con)
        {
            return "[QQ:face=" + con + "]";
        }

        /// <summary>
        /// @群成员：[QQ:at=xxxx] xxxx代表群成员QQ号
        /// </summary>
        /// <param name="qq"></param>
        /// <returns></returns>
        public static String getAt(String qq)
        {
            return "[QQ:at=" + qq + "]";

        }

        /// <summary>
        /// @全体成员：[QQ:at=all]
        /// </summary>
        /// <returns></returns>
        public static String getAtAll()
        {
            return "[QQ:at=all]";

        }

        /// <summary>
        /// 闪照：[QQ:flash,pic=网络链接]、[QQ:flash,pic=本地路径]、[QQ:flash,pic=GUID]
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public static String getFlashPic(String con)
        {
            return "[QQ:flash,pic=" + con + "]";
        }

        /// <summary>
        /// 秀图：[QQ:show,type=1,pic=网络链接]、[QQ:show,type=1,pic=本地路径]、[QQ:show,type=1,pic=GUID] // type 代表的是秀图类型，分别是 1-6
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public static String getShowTypePic(String con)
        {
            return "[QQ:show,type=1,pic=" + con + "]";
        }

        /// <summary>
        /// 完整的URL：[QQ:url=xxxxxx] xxxx代表的是网络链接，QQLight如果把链接直接输出，有的链接会断开，无法形成完整的链接，使用此代码可保证链接不断。
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public static String getUrl(String con)
        {
            return "[QQ:url=" + con + "]";
        }


    }
}
