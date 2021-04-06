using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WeChat_More
{
    public partial class MainForm : Form
    {
        private bool     _debugMode;
        private int      _debugClick;
        private DateTime _debugLastTime = DateTime.MinValue;

        private const int DebugClickCount = 5;

        public MainForm()
        {
            InitializeComponent();

            btnSelect.Click += BtnSelect_Click;
            btnStart.Click  += BtnStart_Click;
            linkStop.Click  += LinkStop_Click;
            label3.Click    += Label3_Click;
            linkAbout.Click += LinkLabel1_Click;

            lbPath.Text = GetWeChatInstallPath();
        }

        /// <summary>
        ///     关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/viacooky/wechat_more");
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            // debug模式
            if ((DateTime.Now - _debugLastTime).TotalMilliseconds < 1000)
            {
                _debugClick++;
                if (_debugClick >= DebugClickCount)
                {
                    _debugClick = 0;
                    _debugMode  = true;
                    MessageBox.Show(@"Debug模式开启");
                }
            }
            else
            {
                _debugClick = 1;
            }

            _debugLastTime = DateTime.Now;
        }

        /// <summary>
        ///     强制停止所有微信进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkStop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"是否停止所有微信进程", @"警告", MessageBoxButtons.OKCancel) != DialogResult.OK) return;

            const string weChatName = "WeChat";
            foreach (var process in Process.GetProcesses())
            {
                if (process.ProcessName.Equals(weChatName)) process.Kill();
            }
        }

        /// <summary>
        ///     启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbPath.Text))
            {
                MessageBox.Show(@"请选择PC版微信执行程序");
                return;
            }

            var startQty = Convert.ToInt32(numQty.Value);
            var sb       = new StringBuilder();
            sb.AppendLine("@echo off");
            for (var i = 0; i < startQty; i++) sb.AppendLine($"start \"\" \"{lbPath.Text}\"");
            var strCmd = sb + "exit";

            if (_debugMode) MessageBox.Show(strCmd);

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName               = "cmd.exe",
                    UseShellExecute        = false,
                    RedirectStandardInput  = true,
                    RedirectStandardError  = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow         = true
                }
            };
            process.Start();
            process.StandardInput.Write(strCmd);
            process.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var initDir = string.IsNullOrEmpty(lbPath.Text)
                ? Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
                : Directory.GetParent(lbPath.Text).FullName;

            var ofd = new OpenFileDialog
            {
                Title            = @"请选择PC版微信执行程序",
                Filter           = @"微信执行程序|WeChat.exe",
                InitialDirectory = initDir
            };

            if (ofd.ShowDialog() == DialogResult.OK) lbPath.Text = ofd.FileName;
        }

        /// <summary>
        ///     获取微信安装目录
        /// </summary>
        /// <returns></returns>
        private string GetWeChatInstallPath()
        {
            const string regPath = "Software\\Tencent\\WeChat";

            var key  = Registry.CurrentUser.OpenSubKey(regPath, true);
            var path = key?.GetValue("InstallPath")?.ToString() ?? string.Empty;

            if (!string.IsNullOrEmpty(path)) path += "\\WeChat.exe";

            return File.Exists(path) ? path : string.Empty;
        }
    }
}