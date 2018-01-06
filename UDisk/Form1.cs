using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;//注册表接口
using System.IO;//IO设备接口
using System.Diagnostics;//进程资源接口

namespace UDisk
{   
    public partial class Form1 : Form
    {
        welcome wel;

        public const int WM_DEVICECHANGE = 0x219;             //U盘插入后，OS的底层会自动检测到，然后向应用程序发送“硬件设备状态改变“的消息
        public const int DBT_DEVICEARRIVAL = 0x8000;          //表示U盘可用的。一个设备或媒体已被插入一块，现在可用。
        public const int DBT_CONFIGCHANGECANCELED = 0x0019;   //要求更改当前的配置（或取消停靠码头）已被取消。
        public const int DBT_CONFIGCHANGED = 0x0018;          //当前的配置发生了变化，由于码头或取消固定。
        public const int DBT_CUSTOMEVENT = 0x8006;            //自定义的事件发生。
        public const int DBT_DEVICEQUERYREMOVE = 0x8001;      //删除一个设备或媒体作品。任何应用程序也不能否认这一要求，并取消删除。
        public const int DBT_DEVICEQUERYREMOVEFAILED = 0x8002;//请求删除一个设备或媒体片已被取消。
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;   //一个设备或媒体片已被删除。
        public const int DBT_DEVICEREMOVEPENDING = 0x8003;    //一个设备或媒体一块即将被删除。
        public const int DBT_DEVICETYPESPECIFIC = 0x8005;     //一个设备特定事件发生。
        public const int DBT_DEVNODES_CHANGED = 0x0007;       //一种设备已被添加到或从系统中删除。
        public const int DBT_QUERYCHANGECONFIG = 0x0017;      //许可是要求改变目前的配置（码头或取消固定）。
        public const int DBT_USERDEFINED = 0xFFFF;            //消息的含义是用户定义的

        public Form1()
        {
            InitializeComponent();
            //runUSB();
            //GetDrives()返回结果为System.IO.DriveInfo类型的数组，计算机上的逻辑驱动器 uin[]接收这个数组
            DriveInfo[] uin = DriveInfo.GetDrives();
            foreach (DriveInfo drive in uin)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    listBoxMessage.Items.Insert(0, "检测到U盘，盘符为:" + drive.Name.ToString() + "。");
                    number_U.num_U++;
                }
            }
            if (number_U.num_U != 0)
            {
                listBoxMessage.Items.Insert(0, "查看U盘请点击\"查看\"；启用U盘请点击\"开启\"；禁用U盘请点击\"禁用\"。");
            }
            else
            {
                listBoxMessage.Items.Insert(0, "目前助手并没有检测到U盘！");
            }
            showUDisk();
        }

        //显示U盘信息
        private void showUDisk()
        {
            int j = new int();
            j = 0;
            string number_total = "";//总空间
            string number_free = ""; //剩余空间
            if (j == 0)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                buttonopen1.Visible = false;
                buttonable1.Visible = false;
                buttondisable1.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                buttonopen2.Visible = false;
                buttonable2.Visible = false;
                buttondisable2.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                buttonopen3.Visible = false;
                buttonable3.Visible = false;
                buttondisable3.Visible = false;
            }
            DriveInfo[] uin = DriveInfo.GetDrives();
            foreach (DriveInfo drive in uin)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    j++;
                    number_total = GetTotalSize(drive.Name.ToString());
                    number_free = GetAvailableSize(drive.Name.ToString());
                    if (j == 1)
                    {
                        label1.Text = drive.Name.ToString();
                        label2.Text = "总空间大小为:" + number_total;
                        label3.Text = "剩余空间大小为:" + number_free;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        buttonopen1.Visible = true;
                        buttonable1.Visible = true;
                        buttondisable1.Visible = true;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        buttonopen2.Visible = false;
                        buttonable2.Visible = false;
                        buttondisable2.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        buttonopen3.Visible = false;
                        buttonable3.Visible = false;
                        buttondisable3.Visible = false;
                    }
                    if (j == 2)
                    {
                        label4.Text = drive.Name.ToString();
                        label5.Text = "总空间大小为:" + number_total;
                        label6.Text = "剩余空间大小为:" + number_free;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        buttonopen1.Visible = true;
                        buttonable1.Visible = true;
                        buttondisable1.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        buttonopen2.Visible = true;
                        buttonable2.Visible = true;
                        buttondisable2.Visible = true;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        buttonopen3.Visible = false;
                        buttonable3.Visible = false;
                        buttondisable3.Visible = false;
                    }
                    if (j == 3)
                    {
                        label7.Text = drive.Name.ToString();
                        label8.Text = "总空间大小为:" + number_total;
                        label9.Text = "剩余空间大小为:" + number_free;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        buttonopen1.Visible = true;
                        buttonable1.Visible = true;
                        buttondisable1.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        buttonopen2.Visible = true;
                        buttonable2.Visible = true;
                        buttondisable2.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        buttonopen3.Visible = true;
                        buttonable3.Visible = true;
                        buttondisable3.Visible = true;
                    }
                }
                groupBox1.Text = "已插入U盘 " + j + " 个（最多显示3个U盘）";
            }
        }

        //获取U盘剩余空间大小及单位，转换为合适的单位，保留两位小数
        private static string GetAvailableSize(string driveDirectoryName)
        {
            string str = "byte";
            int count = 0;
            ulong availableSize = 0;
            double availableConvert = 0.0; //记录U盘剩余空间
            DriveInfo drive = new DriveInfo(driveDirectoryName);//DriveInfo类提供有关驱动器的信息
            availableSize = (ulong)drive.AvailableFreeSpace;//drive.AvailableFreeSpace属性，驱动器上的空闲空间
            availableConvert = (double)availableSize;
            while (availableConvert >= 1024 && count < 3)
            {
                availableConvert = (double)availableConvert / 1024;
                count++;
            }
            availableConvert = (int)(availableConvert * 100);
            availableConvert = (double)availableConvert / 100;
            switch (count)
            {
                case 0:
                    break;
                case 1:
                    str = "KB";
                    break;
                case 2:
                    str = "MB";
                    break;
                case 3:
                    str = "GB";
                    break;
            }
            return availableConvert + str;
        }

        //获取U盘剩余空间大小，单位为字节
        private static ulong GetFreeSizeBytes(string driveDirectoryName)
        {
            ulong availableSize = 0;
            DriveInfo drive = new DriveInfo(driveDirectoryName);
            availableSize = (ulong)drive.AvailableFreeSpace;
            return availableSize;
        }

        //获取U盘总空间大小及单位，转换为合适的单位，保留两位小数
        private static string GetTotalSize(string driveDirectoryName)
        {
            string str = "byte";
            int count = 0;
            ulong totalSize = 0;
            double totalConvert = 0.0; //记录U盘总空间
            DriveInfo drive = new DriveInfo(driveDirectoryName);
            totalSize = (ulong)drive.TotalSize;  //drive.TotalSize属性，驱动器上的总空间
            totalConvert = (double)totalSize;
            while (totalConvert >= 1024 && count < 3)
            {
                totalConvert = (double)totalConvert / 1024;
                count++;
            }
            totalConvert = (int)(totalConvert * 100);
            totalConvert = (double)totalConvert / 100;
            switch (count)
            {
                case 0:
                    break;
                case 1:
                    str = "KB";
                    break;
                case 2:
                    str = "MB";
                    break;
                case 3:
                    str = "GB";
                    break;
            }
            return totalConvert + str;
        }

        //通过注册表启用USB
        public bool runUSB()
        {
            try
            {
                RegistryKey regKey = Registry.LocalMachine; //读取注册列表HKEY_LOCAL_MACHINE  
                string keyPath = @"SYSTEM\CurrentControlSet\Services\USBSTOR"; //USB 大容量存储驱动程序  
                RegistryKey openKey = regKey.OpenSubKey(keyPath, true);
                openKey.SetValue("Start", 3); //设置键值对（3）为开启USB 
                openKey.Close(); //关闭注册列表读写流  
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //通过注册表禁用USB
        public bool stopUSB()
        {
            try
            {
                RegistryKey regKey = Registry.LocalMachine;
                string keyPath = @"SYSTEM\CurrentControlSet\Services\USBSTOR";
                RegistryKey openKey = regKey.OpenSubKey(keyPath, true);
                openKey.SetValue("Start", 4);
                openKey.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == WM_DEVICECHANGE) //设备发生改变
                {
                    string number_total = ""; //返回总容量大小
                    string number_free = ""; //返回剩余容量大小
                    switch (m.WParam.ToInt32()) //通过附加信息WParam分辨具体是什么消息
                    {
                        case DBT_DEVICEARRIVAL://U盘插入
                            DriveInfo[] uin = DriveInfo.GetDrives();
                            number_U.num_U++;  //U盘个数加1
                            foreach (DriveInfo drive in uin)//遍历所有的驱动器
                            {
                                if (drive.DriveType == DriveType.Removable)//驱动器为可移动存储设备
                                {
                                    listBoxMessage.Items.Insert(0, "U盘已插入，盘符为:" + drive.Name.ToString());
                                    number_total = GetTotalSize(drive.Name.ToString());
                                    listBoxMessage.Items.Insert(0, drive.Name.ToString() + "盘总空间大小为：" + number_total);
                                    number_free = GetAvailableSize(drive.Name.ToString());
                                    listBoxMessage.Items.Insert(0, drive.Name.ToString() + "盘剩余空间大小为：" + number_free);
                                }
                            }
                            showUDisk();
                            break;
                        case DBT_DEVICEREMOVECOMPLETE: //U盘卸载
                            listBoxMessage.Items.Insert(0, "U盘被拔出！");
                            number_U.num_U--;
                            DriveInfo[] uin2 = DriveInfo.GetDrives();
                            foreach (DriveInfo drive in uin2)
                            {
                                if (drive.DriveType == DriveType.Removable)
                                {
                                    listBoxMessage.Items.Insert(0, "目前仍然存在U盘，盘符为：" + drive.Name.ToString());
                                }
                            }
                            if (number_U.num_U == 0)
                            {
                                listBoxMessage.Items.Insert(0, "目前不存在U盘！");
                            }
                            showUDisk();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            base.WndProc(ref m);
        }

        //刷新U盘
        private void CheckUClick(object sender, EventArgs e)
        {
            showUDisk();
            listBoxMessage.Items.Insert(0, "刷新完毕");
            if (number_U.num_U == 0)
            {
                MessageBox.Show("目前助手未检测到U盘");
                listBoxMessage.Items.Insert(0, "如果已插入U盘，请点击刷新");
            }
        }

        //打开U盘
        private void buttonopen1Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", label1.Text.ToString());
        }

        private void buttonopen2Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", label4.Text.ToString());
        }

        private void buttonopen3Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", label7.Text.ToString());
        }

        //开启U盘
        private void buttonable1Click(object sender, EventArgs e)
        {
            buttonable1.Cursor = Cursors.No;
            buttonable1.Enabled = false;
            buttonable1.Text = "已开启";
            buttondisable1.Cursor = Cursors.Hand;
            buttondisable1.Enabled = true;
            buttondisable1.Text = "禁用";
            runUSB();
            listBoxMessage.Items.Insert(0, "已开启U盘：" + label1.Text.ToString());
        }

        private void buttonable2Click(object sender, EventArgs e)
        {
            buttonable2.Cursor = Cursors.No;
            buttonable2.Enabled = false;
            buttonable2.Text = "已开启";
            buttondisable2.Cursor = Cursors.Hand;
            buttondisable2.Enabled = true;
            buttondisable2.Text = "禁用";
            runUSB();
            listBoxMessage.Items.Insert(0, "已开启U盘：" + label4.Text.ToString());
        }

        private void buttonable3Click(object sender, EventArgs e)
        {
            buttonable3.Cursor = Cursors.No;
            buttonable3.Enabled = false;
            buttonable3.Text = "已开启";
            buttondisable3.Cursor = Cursors.Hand;
            buttondisable3.Enabled = true;
            buttondisable3.Text = "禁用";
            runUSB();
            listBoxMessage.Items.Insert(0, "已开启U盘：" + label7.Text.ToString());
        }

        //禁用U盘
        private void buttondisable1Click(object sender, EventArgs e)
        {
            buttonable1.Cursor = Cursors.Hand;
            buttonable1.Enabled = true;
            buttonable1.Text = "开启";
            buttondisable1.Cursor = Cursors.No;
            buttondisable1.Enabled = false;
            buttondisable1.Text = "已禁用";
            stopUSB();
            listBoxMessage.Items.Insert(0, "已禁用U盘：" + label1.Text.ToString());
        }

        private void buttondisable2Click(object sender, EventArgs e)
        {
            buttonable2.Cursor = Cursors.Hand;
            buttonable2.Enabled = true;
            buttonable2.Text = "开启";
            buttondisable2.Cursor = Cursors.No;
            buttondisable2.Enabled = false;
            buttondisable2.Text = "已禁用";
            stopUSB();
            listBoxMessage.Items.Insert(0, "已禁用U盘：" + label4.Text.ToString());
        }

        private void buttondisable3Click(object sender, EventArgs e)
        {
            buttonable3.Cursor = Cursors.Hand;
            buttonable3.Enabled = true;
            buttonable3.Text = "开启";
            buttondisable3.Cursor = Cursors.No;
            buttondisable3.Enabled = false;
            buttondisable3.Text = "已禁用";
            stopUSB();
            listBoxMessage.Items.Insert(0, "已禁用U盘：" + label7.Text.ToString());
        }

        //返回
        private void buttonbackClick(object sender, EventArgs e)
        {
            this.Hide();
            wel = new welcome();
            wel.Show();
        }

        //清空
        private void buttonclearClick(object sender, EventArgs e)
        {
            listBoxMessage.Items.Clear();
        }

        //复制文件
        private void buttoncopyClick(object sender, EventArgs e)
        {
            string file_name;//文件名称
            string fromPath;//原路径
            string targetPath;//目标路径

            Stream myStream;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "c:\\";//对话框的初始目录
            openFile.Filter = "All files (*.*)|*.*";// 要在对话框中显示的文件筛选器
            openFile.FilterIndex = 2;// 在对话框中选择的文件筛选器的索引
            openFile.RestoreDirectory = true;//控制对话框在关闭之前是否恢复当前目录
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFile.OpenFile()) != null)
                {
                    myStream.Close();
                }
                file_name = System.IO.Path.GetFileName(openFile.FileName);//所选择文件
                fromPath = System.IO.Path.GetDirectoryName(openFile.FileName);//所选择的目录
                fromPath = fromPath + "\\" + file_name;
                listBoxMessage.Items.Insert(0, "要复制的文件路径为：" + fromPath);

                FileInfo file_size = new FileInfo(fromPath);
                long size = file_size.Length;//获取文件大小

                FolderBrowserDialog dilog = new FolderBrowserDialog();
                dilog.Description = "请选择目标文件夹：";
                if (number_U.num_U > 0)
                {
                    dilog.SelectedPath = label1.Text.ToString();
                }
                if (dilog.ShowDialog() == DialogResult.OK)
                {
                    targetPath = dilog.SelectedPath;
                    targetPath = targetPath + "\\" + file_name;//获取目标路径

                    string str = targetPath.Substring(0, 2);
                    ulong nub = GetFreeSizeBytes(str);
                    if ((long)nub > size)
                    {
                        if (targetPath != null)
                        {
                            if (fromPath == targetPath)//如果路径相同，禁止复制
                            {
                                MessageBox.Show("请不要在自身文件夹内复制！");
                                listBoxMessage.Items.Insert(0, "请不要在自身文件夹内复制！");
                            }
                            else
                            {
                                if (!(File.Exists(targetPath)))//如果目标文件不存在，允许复制
                                {
                                    File.Copy(fromPath, targetPath);
                                    listBoxMessage.Items.Insert(0, "文件已成功复制到路径 " + targetPath + " 之下，请点击查看按钮查看U盘！");
                                }
                                else
                                {
                                    MessageBox.Show("文件已存在");
                                    listBoxMessage.Items.Insert(0, "文件已存在！");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(str + "盘空间不足，请删除部分文件再试！");
                        listBoxMessage.Items.Insert(0, str + "盘空间不足，请删除部分文件再试！");
                    }
                }
                else
                {
                    listBoxMessage.Items.Insert(0, "取消复制！");
                }
            }
            else
            {
                listBoxMessage.Items.Insert(0, "取消复制！");
            }
        }

        //复制目录定义函数
        private void copydir(string fromdir, string targetdir)
        {
            //取得要拷贝的文件夹名
            string strFolderName = fromdir.Substring(fromdir.LastIndexOf("\\") + 1, fromdir.Length - fromdir.LastIndexOf("\\") - 1);
            //如果目标文件夹中没有源文件夹则在目标文件夹中创建源文件夹
            if (!Directory.Exists(targetdir + "\\" + strFolderName))
            {
                Directory.CreateDirectory(targetdir + "\\" + strFolderName);
            }
            //创建数组保存源文件夹下的文件名和其路径
            string[] fromFiles = Directory.GetFiles(fromdir);
            //循环拷贝文件
            for (int i = 0; i < fromFiles.Length; i++)
            {
                //取得拷贝的文件名,不包括路径
                string fileName = fromFiles[i].Substring(fromFiles[i].LastIndexOf("\\") + 1, fromFiles[i].Length - fromFiles[i].LastIndexOf("\\") - 1);
                File.Copy(fromFiles[i], targetdir + "\\" + strFolderName + "\\" + fileName, true);
            }

            DirectoryInfo dirInfo = new DirectoryInfo(fromdir);
            //取得源文件夹下的所有子文件夹名称
            DirectoryInfo[] childdir = dirInfo.GetDirectories();
            for (int j = 0; j < childdir.Length; j++)
            {
                //获取所有子文件夹名
                string childdirname = fromdir + "\\" + childdir[j].ToString();
                //把得到的子文件夹当成新的源文件夹，递归进行下一轮拷贝
                copydir(childdirname, targetdir + "\\" + strFolderName);
            }
        }

        //复制目录
        private void buttoncopydirClick(object sender, EventArgs e)
        {
            string fromdir;
            string targetdir;
            FolderBrowserDialog fromdilog = new FolderBrowserDialog();
            fromdilog.Description = "请选择源目录：";
            if (fromdilog.ShowDialog() == DialogResult.OK)
            {
                fromdir = fromdilog.SelectedPath;
                listBoxMessage.Items.Insert(0, "要复制的目录路径为：" + fromdir);
                FolderBrowserDialog targetdilog = new FolderBrowserDialog();
                targetdilog.Description = "请选择目标目录：";
                if (number_U.num_U > 0)
                {
                    targetdilog.SelectedPath = label1.Text.ToString();
                }
                if (targetdilog.ShowDialog() == DialogResult.OK)
                {
                    targetdir = targetdilog.SelectedPath;
                    copydir(fromdir, targetdir);
                    listBoxMessage.Items.Insert(0, "已成功复制到目录 " + targetdir + " 之下！");
                }
                else
                {
                    listBoxMessage.Items.Insert(0, "取消复制！");
                }
            }
            else
            {
                listBoxMessage.Items.Insert(0, "取消复制！");
            }
        }

        //删除文件
        private void buttondeleteClick(object sender, EventArgs e)
        {
            string file_name;
            string file_path;

            Stream myStream;
            OpenFileDialog openFile = new OpenFileDialog();
            string deletepath = "c:\\";
            if(number_U.num_U > 0){
                deletepath = label1.Text.ToString();
            }
            openFile.InitialDirectory = deletepath;//对话框的初始目录
            openFile.Filter = "All files (*.*)|*.*";// 要在对话框中显示的文件筛选器
            openFile.FilterIndex = 2;// 在对话框中选择的文件筛选器的索引
            openFile.RestoreDirectory = true;//控制对话框在关闭之前是否恢复当前目录
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFile.OpenFile()) != null)
                {
                    myStream.Close();
                }
                file_name = System.IO.Path.GetFileName(openFile.FileName);//所选择文件
                file_path = System.IO.Path.GetDirectoryName(openFile.FileName);//所选择的目录
                file_path = file_path + "\\" + file_name;
                listBoxMessage.Items.Insert(0, "要删除的文件路径为：" + file_path);

                DialogResult result = MessageBox.Show("您确定要删除文件 "+file_name+" 吗？", "助手提示", MessageBoxButtons.YesNo);
                if ((result == System.Windows.Forms.DialogResult.No))
                {
                    listBoxMessage.Items.Insert(0, "取消删除！");
                }
                if ((result == System.Windows.Forms.DialogResult.Yes))
                {
                    File.Delete(file_path);
                    listBoxMessage.Items.Insert(0, "删除成功！，请点击查看按钮查看U盘！");
                }
            }
            else
            {
                listBoxMessage.Items.Insert(0, "取消删除！");
            }
        }

        //删除目录
        private void buttondeletedirClick(object sender, EventArgs e)
        {
            string targetdir;
            FolderBrowserDialog targetdilog = new FolderBrowserDialog();
            targetdilog.Description = "请选择目标目录：";
            if (number_U.num_U > 0)
            {
                targetdilog.SelectedPath = label1.Text.ToString();
            }
            if (targetdilog.ShowDialog() == DialogResult.OK)
            {
                targetdir = targetdilog.SelectedPath;
                listBoxMessage.Items.Insert(0, "要删除的目录路径为：" + targetdir);
                //取得目录名字
                string strFolderName = targetdir.Substring(targetdir.LastIndexOf("\\") + 1, targetdir.Length - targetdir.LastIndexOf("\\") - 1);

                DialogResult result = MessageBox.Show("您确定要删除目录 " + strFolderName + " 及其中的所有子文件和目录吗？", "助手提示", MessageBoxButtons.YesNo);
                if ((result == System.Windows.Forms.DialogResult.No))
                {
                    listBoxMessage.Items.Insert(0, "取消删除！");
                }
                if ((result == System.Windows.Forms.DialogResult.Yes))
                {
                    Directory.Delete(targetdir, true);
                    listBoxMessage.Items.Insert(0, "删除成功！，请点击查看按钮查看U盘！");
                }
            }
            else
            {
                listBoxMessage.Items.Insert(0, "取消删除！");
            }
        }

        //关闭窗口
        private void formclose(object sender, FormClosedEventArgs e)
        {
            Process close = Process.GetProcessById(Process.GetCurrentProcess().Id);
        }

    }
}
