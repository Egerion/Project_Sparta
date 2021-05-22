using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sparta_Project
{
    public partial class Form_Interface : Form
    {
        public bool ShowProcName = true;
        public bool ShowFullPath = false;
        public static string UninstallKey       = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        string ListBox_LastOpenedAppsFormat     = "{0, -35}{1, -55}";
        string ListBox_BackgroundProcsFormat    = "{0, -35}{1, -55}";

        public Form_Interface()
        {
            InitializeComponent();
            FindBackgroundPorcesses();
            FindInstalledApplications();
        }

        private void ListBox_LastOpenedApps_DrawItem(object sender, DrawItemEventArgs e)
        {
            string output = ListBox_LastOpenedApps.Items[e.Index].ToString();
            float olength = e.Graphics.MeasureString(output, e.Font).Width;
            float pos = ListBox_LastOpenedApps.Width - olength;

            SolidBrush brushBack = new SolidBrush(e.BackColor);
            e.Graphics.FillRectangle(brushBack, e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);


            SolidBrush brush = new SolidBrush(e.ForeColor);
            e.Graphics.DrawString(output, e.Font, brush, pos, e.Bounds.Top);
        }

        public void FindBackgroundPorcesses()
        {
            ListBox_BackgroundProcs.Items.Add(String.Format(ListBox_BackgroundProcsFormat, "Process Name", "Id"));
            ListBox_LastOpenedApps.Items.Add(string.Format(ListBox_LastOpenedAppsFormat, "Process Name", "Date"));

            System.Diagnostics.Process[] ProcessCollection = System.Diagnostics.Process.GetProcesses();
            for (int i = 0; i < ProcessCollection.Length; i++)
            {
                try
                {
                    //if (ShowProcName)s
                    //{
                        ListBox_BackgroundProcs.Items.Add(String.Format(ListBox_LastOpenedAppsFormat, 
                            ProcessCollection[i].ProcessName.ToString(), ProcessCollection[i].Id.ToString()));
                    //}
                    //else
                    //    ListBox_BackgroundProcs.Items.Add(ProcessCollection[i].MainModule.FileName);

                    if(i >= ProcessCollection.Length - 5)
                    {
                        ListBox_LastOpenedApps.Items.Add(string.Format(ListBox_LastOpenedAppsFormat,
                           ProcessCollection[i].ProcessName.ToString(), ProcessCollection[i].StartTime.ToString()));

                       
                    }
                }
                catch
                {
                    //MessageBox.Show("Application cannot find any background task(s).", "Error");
                    //Environment.Exit(0);
                }
            }
        }

        public void FindInstalledApplications()
        {
            using (RegistryKey RegistryKey = Registry.LocalMachine.OpenSubKey(UninstallKey))
            {
                foreach (string SubKeyName in RegistryKey.GetSubKeyNames())
                {
                    using (RegistryKey SubKey = RegistryKey.OpenSubKey(SubKeyName))
                    {
                        try
                        {
                            ListBox_InstalledApps.Items.Add(SubKey.GetValue("DisplayName"));
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        private void ResetProcessList()
        {
            ListBox_BackgroundProcs.SelectedIndex = -1;
            ListBox_BackgroundProcs.Items.Clear();
            ListBox_BackgroundProcs.ResetText();

            ListBox_LastOpenedApps.SelectedIndex = -1;
            ListBox_LastOpenedApps.Items.Clear();
            ListBox_LastOpenedApps.ResetText();

            FindBackgroundPorcesses();
        }

        private void ListBox_BackgroundProcs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox_BackgroundProcs_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void Button_ProcRefresh_Click(object sender, EventArgs e)
        {
            ResetProcessList();
        }

        private void LinkLabel_Contact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Site = new System.Diagnostics.ProcessStartInfo();
            Site.UseShellExecute = true;
            Site.FileName = "https://sparta.com.tr/iletisim/";
            System.Diagnostics.Process.Start(Site);
        }

        private void Button_ProcName_Click(object sender, EventArgs e)
        {
            ShowProcName = true; 
            ResetProcessList();
        }

        private void Button_ProFullPath_Click(object sender, EventArgs e)
        {
            ShowProcName = false; 
            ResetProcessList();
        }

        private void TextBox_ProcessFilter_TextChanged(object sender, EventArgs e)
        {
            int Index = ListBox_BackgroundProcs.FindString(TextBox_ProcessFilter.Text);
            if (Index != -1)
            {
                ListBox_BackgroundProcs.SelectedIndex = Index;
            }
        }

        private void TextBox_FilterInstalledApps_TextChanged(object sender, EventArgs e)
        {
            int Index = ListBox_InstalledApps.FindString(TextBox_FilterInstalledApps.Text);
            if (Index != -1)
            {
                ListBox_InstalledApps.SelectedIndex = Index;
            }
        }
    }
}
