// Original MS-PL copyright: Copyright Alistair J. R. Young, Arkane Systems, 2012-2013.
// Modified & copyrighted: Copyright Patrick Mechenbier 2015.

using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MouseJiggle
{
    public partial class MainForm : Form
    {
        private const string REGISTRYLOCATION = @"Software\MouseJiggle";
        private const string REGISTRYKEY = "ZenJiggleEnabled";
        private bool zig = true;
        private bool moved = false;

        public MainForm()
        {
            InitializeComponent();
            MouseEvents.HookManager.MouseMove += HookManager_MouseMove;
        }

        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            moved = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(REGISTRYLOCATION, RegistryKeyPermissionCheck.ReadWriteSubTree);
                var zen = (int)key.GetValue(REGISTRYKEY, 0);

                if (zen == 0)
                {
                    cbZenJiggle.Checked = false;
                }
                else
                {
                    cbZenJiggle.Checked = true;
                }
            }
            catch (Exception)
            {
                // Ignore any problems - non-critical operation.
            }

            if (Program.ZenJiggling)
            {
                cbZenJiggle.Checked = true;
            }
            if (Program.StartJiggling)
            {
                cbEnabled.Checked = true;
            }
            if (Program.StartMinimized)
            {
                btnToTray_Click(this, null);
            }
        }

        private void jiggleTimer_Tick(object sender, EventArgs e)
        {
            // jiggle
            if (cbZenJiggle.Checked)
            {
                Jiggler.Jiggle(0, 0);
            }
            else
            {
                if (moved)
                {
                    moved = false;
                }
                else
                {
                    if (zig)
                    {
                        Jiggler.Jiggle(4, 4);
                    }
                    else // zag
                    {
                        Jiggler.Jiggle(-4, -4);
                    }

                    zig = !zig;
                }
            }
        }

        private void cbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            jiggleTimer.Enabled = cbEnabled.Checked;
        }

        private void cbZenJiggle_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(REGISTRYLOCATION, RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (cbZenJiggle.Checked)
                {
                    key.SetValue(REGISTRYKEY, 1);
                }
                else
                {
                    key.SetValue(REGISTRYKEY, 0);
                }
            }
            catch (Exception)
            {
                // Ignore any problems - non-critical operation.
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (var a = new AboutBox())
            {
                a.ShowDialog();
            }
        }
        
        private void btnToTray_Click(object sender, EventArgs e)
        {
            // minimize to tray
            Visible = false;

            // remove from taskbar
            ShowInTaskbar = false;

            // show tray icon
            nifMin.Visible = true;
        }

        private void nifMin_DoubleClick(object sender, EventArgs e)
        {
            // restore the window
            Visible = true;

            // replace in taskbar
            ShowInTaskbar = true;

            // hide tray icon
            nifMin.Visible = false;
        }
    }
}