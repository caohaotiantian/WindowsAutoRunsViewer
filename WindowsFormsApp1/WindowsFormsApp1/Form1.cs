using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public const string HKLM_Logon = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        public const string HKCU_Logon = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        public const string HKLM_IE_BHO = "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Browser Helper Objects";
        public const string HKLM_CLSID = "Software\\Classes\\CLSID";
        public const string HKLM_Services = "System\\CurrentControlSet\\Services";
        public const string ScheduledTask_Path = "C:\\Windows\\System32\\Tasks";
        public const string HKLM_KnownDLLs = "System\\CurrentControlSet\\Control\\Session Manager\\KnownDlls";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            string item, name;
            int start, dot;

            #region Logon

            LogonResult.Items.Clear();
            LogonResult.Groups.Clear();

            #region LocalMachine->Run

            ListViewGroup LogonGroup1 = new ListViewGroup();
            LogonGroup1.Header = "HKLM\\" + HKCU_Logon;
            LogonResult.Groups.Add(LogonGroup1);
            RegistryKey hklm_logon = Registry.LocalMachine.OpenSubKey(HKLM_Logon);
            for (int i = 0; i < hklm_logon.GetValueNames().Length; i++)
            {
                item = hklm_logon.GetValueNames().ElementAt(i);
                name = hklm_logon.GetValue(item).ToString();
                if (name == "") continue;
                start = name.IndexOf(":") - 1;
                if (start == -2) start = 0;
                dot = name.IndexOf(".");
                string file = name.Substring(start, dot - start + 4);
                if (file.IndexOf(":") == -1) file = "C:\\Windows\\system32\\" + file;
                listViewItem = new ListViewItem(item);
                try
                {
                    FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(file);
                    listViewItem.SubItems.Add(fileVersion.FileDescription);
                    listViewItem.SubItems.Add(fileVersion.ProductName);
                }
                catch
                {
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                }
                listViewItem.SubItems.Add(file);
                LogonGroup1.Items.Add(listViewItem);
                LogonResult.Items.Add(listViewItem);
            }

            #endregion LocalMachine->Run

            #region CurrentUser->Run

            ListViewGroup LogonGroup2 = new ListViewGroup();
            LogonGroup2.Header = "HKCU\\" + HKCU_Logon;
            LogonResult.Groups.Add(LogonGroup2);
            RegistryKey hkcu_logon = Registry.CurrentUser.OpenSubKey(HKCU_Logon);
            for (int i = 0; i < hkcu_logon.GetValueNames().Length; i++)
            {
                item = hkcu_logon.GetValueNames().ElementAt(i);
                name = hkcu_logon.GetValue(item).ToString();
                if (name == "") continue;
                start = name.IndexOf(":") - 1;
                if (start == -2) start = 0;
                dot = name.IndexOf(".");
                string file = name.Substring(start, dot - start + 4);
                if (file.IndexOf(":") == -1) file = "C:\\Windows\\system32\\" + file;
                listViewItem = new ListViewItem(item);
                try
                {
                    FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(file);
                    listViewItem.SubItems.Add(fileVersion.FileDescription);
                    listViewItem.SubItems.Add(fileVersion.ProductName);
                }
                catch
                {
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                }
                listViewItem.SubItems.Add(file);
                LogonGroup2.Items.Add(listViewItem);
                LogonResult.Items.Add(listViewItem);
            }

            #endregion CurrentUser->Run

            #endregion Logon

            #region Services

            ServicesResult.Items.Clear();
            ServicesResult.Groups.Clear();

            #region LocalMachine->Services

            ListViewGroup ServicesGroup1 = new ListViewGroup();
            ServicesGroup1.Header = "HKLM\\" + HKLM_Services;
            ServicesResult.Groups.Add(ServicesGroup1);
            RegistryKey hklm_services = Registry.LocalMachine.OpenSubKey(HKLM_Services);
            int type;
            string path, image_path;
            foreach (string ServiceName in hklm_services.GetSubKeyNames())
            {
                RegistryKey key = hklm_services.OpenSubKey(ServiceName);
                if (key.GetValue("Type") != null)
                {
                    type = (int)key.GetValue("Type");
                }
                else
                {
                    type = 0;
                }
                if (key.GetValue("ImagePath") != null)
                {
                    path = key.GetValue("ImagePath").ToString();
                }
                else
                {
                    path = "";
                }
                /*Type:
                 * 1 2 4 8: drivers
                 * 16 win32服务，以其自身进程运行，不与其他服务共享可执行文件（即宿主进程）
                 * 32 win32服务，作为共享进程运行，与其他服务共享可执行文件（即宿主进程）
                 * 272 win32服务，以其自身进程运行，同时服务可与桌面交互，接受用户输入，交互服务必须以localsystem本地系统帐户运行
                 * 288	win32服务，以共享进程运行，同时服务可与桌面交互，接受用户输入，交互服务必须以localsystem本地系统帐户运行
                 */
                if ((type == 16) || (type == 32) || (type == 272) || (type == 288))
                {
                    string tmp_path = path.ToLower();
                    // find svchost
                    if (path.ToLower().IndexOf("svchost") != -1)
                    {
                        RegistryKey parameter = key.OpenSubKey("Parameters");
                        if (parameter != null)
                        {
                            image_path = parameter.GetValue("ServiceDLL").ToString();
                        }
                        else
                        {
                            if (path.IndexOf(":") == -1)
                            {
                                image_path = "C:\\Windows\\system32\\" + path;
                            }
                            else
                            {
                                start = path.IndexOf(":") - 1;
                                image_path = path.Substring(start, path.IndexOf(".") - start + 4);
                            }
                        }
                    }
                    else
                    {
                        if (path.IndexOf(":") == -1)
                        {
                            image_path = "C:\\Windows\\system32\\" + path;
                        }
                        else
                        {
                            start = path.IndexOf(":") - 1;
                            image_path = path.Substring(start, path.IndexOf(".") - start + 4);
                        }
                    }
                    try
                    {
                        FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(image_path);
                        listViewItem = new ListViewItem(ServiceName);
                        listViewItem.SubItems.Add(fileVersionInfo.FileDescription);
                        listViewItem.SubItems.Add(fileVersionInfo.ProductName);
                        listViewItem.SubItems.Add(image_path);
                    }
                    catch
                    {
                        listViewItem = new ListViewItem(ServiceName);
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add(image_path);
                    }
                    ServicesGroup1.Items.Add(listViewItem);
                    ServicesResult.Items.Add(listViewItem);
                }
            }

            #endregion LocalMachine->Services

            #endregion Services

            #region Drivers

            DriversResult.Items.Clear();
            DriversResult.Groups.Clear();

            #region LocalMachine->Drivers

            ListViewGroup DriversGroup1 = new ListViewGroup();
            DriversGroup1.Header = "HKLM\\" + HKLM_Services;
            DriversResult.Groups.Add(DriversGroup1);
            foreach (string DriversName in hklm_services.GetSubKeyNames())
            {
                RegistryKey key = hklm_services.OpenSubKey(DriversName);
                if (key.GetValue("ImagePath") != null)
                {
                    path = key.GetValue("ImagePath").ToString();
                }
                else
                {
                    path = "";
                }
                if (key.GetValue("Type") != null)
                {
                    type = (int)key.GetValue("Type");
                }
                else
                {
                    type = 0;
                }
                /*Type:
                 * 1 2 4 8: drivers
                 * 16 win32服务，以其自身进程运行，不与其他服务共享可执行文件（即宿主进程）
                 * 32 win32服务，作为共享进程运行，与其他服务共享可执行文件（即宿主进程）
                 * 272 win32服务，以其自身进程运行，同时服务可与桌面交互，接受用户输入，交互服务必须以localsystem本地系统帐户运行
                 * 288	win32服务，以共享进程运行，同时服务可与桌面交互，接受用户输入，交互服务必须以localsystem本地系统帐户运行
                 */
                if ((type == 1) || (type == 2) || (type == 4) || (type == 8))
                {
                    if (path.IndexOf(".sys") == -1) continue;
                    if (path.IndexOf("\\SystemRoot") != -1)
                    {
                        image_path = "C:\\Windows" + path.Substring(path.IndexOf("\\SystemRoot") + 10, path.Length - 10);
                    }
                    else
                    {
                        if (path.IndexOf(":") != -1)
                        {
                            start = path.IndexOf(":") - 1;
                            dot = path.IndexOf(".");
                            image_path = path.Substring(start, dot - start + 4);
                        }
                        else
                        {
                            image_path = "C:\\Windows\\" + path;
                        }
                    }
                    listViewItem = new ListViewItem(DriversName);
                    try
                    {
                        FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(image_path);
                        listViewItem.SubItems.Add(fileVersion.FileDescription);
                        listViewItem.SubItems.Add(fileVersion.ProductName);
                    }
                    catch
                    {
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add("");
                    }
                    listViewItem.SubItems.Add(image_path);
                    DriversGroup1.Items.Add(listViewItem);
                    DriversResult.Items.Add(listViewItem);
                }
            }

            #endregion LocalMachine->Drivers

            #endregion Drivers

            #region ScheduledTasks

            ScheduledTasksResult.Items.Clear();
            ScheduledTasksResult.Groups.Clear();

            #region C:\Windows\System32\Tasks

            ListViewGroup ScheduledTasksGroup1 = new ListViewGroup();
            ScheduledTasksGroup1.Header = ScheduledTask_Path;
            ScheduledTasksResult.Groups.Add(ScheduledTasksGroup1);
            FileInfo fileInfo;
            DirectoryInfo directoryInfo = new DirectoryInfo(ScheduledTask_Path);
            for (int i = 0; i < Directory.GetFiles(ScheduledTask_Path).Length; i++)
            {
                fileInfo = directoryInfo.GetFiles().ElementAt(i);
                FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(fileInfo.FullName);
                FileStream fileStream = fileInfo.OpenRead();
                long filename_length = fileStream.Length;
                byte[] buffer = new byte[256];
                int j = 0;
                path = "";
                do
                {
                    fileStream.Read(buffer, 0, 256);
                    foreach (byte s in buffer)
                    {
                        if (s != 0)
                        {
                            path += (char)s;
                        }
                        j = j + 1;
                    }
                } while (j < filename_length);
                path = path.Substring(path.IndexOf("<Command>") + 9, path.IndexOf("</Command>") - path.IndexOf("<Command>") - 9);
                while (!char.IsLetter(path, 0))
                {
                    path = path.Remove(0, 1);
                }
                while (!char.IsLetter(path, path.Length - 1))
                {
                    path = path.Remove(path.Length - 1, 1);
                }
                if (fileInfo.Name[0] == '{') continue;
                try
                {
                    listViewItem = new ListViewItem(path);
                    listViewItem.SubItems.Add(fileVersionInfo.FileDescription);
                    listViewItem.SubItems.Add(fileVersionInfo.ProductName);
                }
                catch
                {
                    listViewItem = new ListViewItem(path);
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                }
                listViewItem.SubItems.Add(path);
                ScheduledTasksGroup1.Items.Add(listViewItem);
                ScheduledTasksResult.Items.Add(listViewItem);
            }

            #endregion C:\Windows\System32\Tasks

            #endregion ScheduledTasks

            #region InternetExplorer

            InternetExplorerResult.Items.Clear();
            InternetExplorerResult.Groups.Clear();

            #region LocalMachine->IE BHO

            ListViewGroup IEGroup1 = new ListViewGroup();
            IEGroup1.Header = "HKLM\\" + HKLM_IE_BHO;
            InternetExplorerResult.Groups.Add(IEGroup1);
            RegistryKey hklm_ie_bho = Registry.LocalMachine.OpenSubKey(HKLM_IE_BHO);
            RegistryKey hklm_clsid = Registry.LocalMachine.OpenSubKey(HKLM_CLSID);
            foreach (string InternetName in hklm_ie_bho.GetSubKeyNames())
            {
                if (InternetName == null) continue;
                foreach (string key in hklm_clsid.GetSubKeyNames())
                {
                    if (key == null) continue;
                    if (key.Equals(InternetName))
                    {
                        RegistryKey subkey = hklm_clsid.OpenSubKey(key).OpenSubKey("InprocServer32");
                        FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(subkey.GetValue("").ToString());
                        ListViewItem ie = new ListViewItem();
                        ie.SubItems[0].Text = fileVersionInfo.InternalName;
                        ie.SubItems.Add(fileVersionInfo.FileDescription);
                        ie.SubItems.Add(fileVersionInfo.ProductName);
                        ie.SubItems.Add(fileVersionInfo.FileName);
                        if (!fileVersionInfo.InternalName.Equals(""))
                        {
                            IEGroup1.Items.Add(ie);
                            InternetExplorerResult.Items.Add(ie);
                        }
                    }
                }
            }

            #endregion LocalMachine->IE BHO

            #endregion InternetExplorer

            #region KnownDLLs

            KnownDLLResult.Items.Clear();
            KnownDLLResult.Groups.Clear();

            #region LocalMachine->Known DLLs

            ListViewGroup KnownDLLsGroup = new ListViewGroup();
            KnownDLLsGroup.Header = "HKLM\\" + HKLM_KnownDLLs;
            KnownDLLResult.Groups.Add(KnownDLLsGroup);
            string dlldir = "";
            RegistryKey hklm_dll = Registry.LocalMachine.OpenSubKey(HKLM_KnownDLLs);
            foreach (string dll in hklm_dll.GetValueNames())
            {
                if (hklm_dll.Equals("DllDirectory"))
                {
                    dlldir = hklm_dll.GetValue(dll).ToString();
                    break;
                }
            }
            foreach (string valuename in hklm_dll.GetValueNames())
            {
                string dllname = hklm_dll.GetValue(valuename).ToString();
                if (dllname.IndexOf(".dll") == -1) continue;
                listViewItem = new ListViewItem(valuename);
                path = dlldir + "\\" + dllname;
                try
                {
                    FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(path);
                    listViewItem.SubItems.Add(fileVersion.FileDescription);
                    listViewItem.SubItems.Add(fileVersion.ProductName);
                    listViewItem.SubItems.Add(path);
                }
                catch
                {
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add(path);
                }
                KnownDLLsGroup.Items.Add(listViewItem);
                KnownDLLResult.Items.Add(listViewItem);
            }

            #endregion LocalMachine->Known DLLs

            #endregion KnownDLLs
        }
    }
}