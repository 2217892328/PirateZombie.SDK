using System;
using System.IO;
using System.Windows.Forms;

namespace Fanxs.cn.QQLight.MainFrom
{
    public partial class repair : Form
    {
        public repair()
        {
            InitializeComponent();
        }

        private void repair_Load(object sender, EventArgs e)
        {
            byte[] byDll = global::Fanxs.cn.QQLight.Properties.Resources.DMSkin;//获取嵌入dll文件的字节数组  
            string strPath = Application.StartupPath + @"\DMSkin.dll";//设置释放路径   导出路径
            using (FileStream fs = new FileStream(strPath, FileMode.Create))
            {
                fs.Write(byDll, 0, byDll.Length);
            }
            MessageBox.Show("请手动重启QQLight，进入正常的设置窗口", "修复完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);//重启应用
            //Application.Exit();
            this.Close();
        }
    }
}
