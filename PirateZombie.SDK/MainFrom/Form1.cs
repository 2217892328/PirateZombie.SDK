using System;

namespace PirateZombie.SDK.MainFrom
{
    public partial class Form1 : DMSkin.DMSkinForm
    {
        String qq = "";
        int ac = 0;
        String cookies = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ac = QLMain.ac;
            qq = QLAPI.Api_GetLoginQQ(ac);
            cookies = QLAPI.Api_GetCookies(ac);

            //MessageBox.Show(NewApi.Api_GetGroupList(false, QLMain.ac));
            label1.Text = QLAPI.Api_GetNick(qq, ac);

            label2.Text = "ID:" + qq;
            pictureBox1.LoadAsync("http://q3.qlogo.cn/g?b=qq&nk=" + qq + "&s=0&t=1499541493");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SendPraise(qqb.Text, ac);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SendShake(qqb.Text, ac);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_Getbkn(cookies, ac));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_Getbkn_Long(cookies, ac));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QLAPI.Api_AddFriend(qqb.Text, "插件功能测试", ac);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QLAPI.Api_DeleteFriend(qqb.Text, ac);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SetSignature("机器人插件测试", ac);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(cookies);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetQzoneCookies(ac));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetQzoneToken(ac));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SendTaotao("欢迎使用QLSDK for c#", ac);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SendMsg(1, "", qqb.Text, "私发测试信息", ac);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SetFriendName(qqb.Text, "QL", ac);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetPraiseNum(qqb.Text, ac).ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetQQLevel(qqb.Text, ac).ToString());

        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetQQAge(qqb.Text, ac).ToString());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetQQSex(qqb.Text, ac).ToString());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetFriendList(true, ac));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetQQInfo(qqb.Text, ac).ToString());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            String msid = QLAPI.Api_SendMsg(1, "", qqb.Text, "测试信息", ac);
            System.Windows.Forms.MessageBox.Show("开始撤回");
            QLAPI.Api_DeleteMsg(1, "", qqb.Text, msid, ac);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            QLAPI.Api_QuitGroup(qb.Text, ac);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            QLAPI.Api_QuitDiscussGroup(qb.Text, ac);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SetGroupName(qb.Text, "Fanx繁星", ac);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SetDiscussName(qb.Text, "Fanx繁星", ac);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            QLAPI.Api_BanGroup(qb.Text, true, ac);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            QLAPI.Api_BanGroup(qb.Text, false, ac);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SetManager(qb.Text, q.Text, true, ac);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            QLAPI.Api_Ban(qb.Text, q.Text, 60000, ac);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SetAnony(qb.Text, true, ac);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            QLAPI.Api_RemoveMember(qb.Text, q.Text, true, ac);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            QLAPI.Api_RemoveGroup(qb.Text, ac);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            QLAPI.Api_AddGroup(qb.Text, "你好，我是c#sdk", ac);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetGroupCard(qb.Text, q.Text, ac).ToString());
        }

        private void button34_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetGroupName(qb.Text, ac).ToString());
        }

        private void button35_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetGroupIntroduce(qb.Text, ac).ToString());
        }

        private void button36_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetGroupOwner(qb.Text, ac).ToString());
        }

        private void button40_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetGroupInfo(qb.Text, ac));
        }

        private void button37_Click(object sender, EventArgs e)
        {
            QLAPI.Api_SetGroupCard(qb.Text, q.Text, "C#UP", ac);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetGroupList(true, ac).ToString());
        }

        private void button39_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(QLAPI.Api_GetGroupMemberList(qb.Text, true, ac).ToString());
        }

        private void button41_Click(object sender, EventArgs e)
        {
            QLAPI.Api_InviteFriend(qb.Text, q.Text, ac);
        }



        private void button41_Click_1(object sender, EventArgs e)
        {
            QLAPI.Api_InviteFriend(qb.Text, q.Text, ac);
        }

        private void button61_Click(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
