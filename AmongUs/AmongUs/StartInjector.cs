using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using AmongUs.Class;
using System.Diagnostics;

namespace AmongUs
{
    public partial class StartInjector : Form
    {
        Memory.Mem m = new Memory.Mem();

        public StartInjector()
        {
            InitializeComponent();
        }


        private void StartInjector_Load(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName(MemoryAddress.WINDOW_NAME);

            foreach (Process pro in Process.GetProcesses())
            {
                if (pro.ProcessName.ToLower().Contains("cheat") && pro.ProcessName.ToLower().Contains("engine"))
                {
                    MessageBox.Show(Messages.CEMessage);
                    Application.Exit();
                }
            }

            if (PID > 0)
            {
                
            }
            else
            {
                MessageBox.Show(Messages.DTEK);

            }
        }

        private void inject_btn_Click(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName(MemoryAddress.WINDOW_NAME); // Want to inject

            int PIDCheatEngine = m.GetProcIdFromName(MemoryAddress.cheatengine);
            int PIDx64dbg = m.GetProcIdFromName(MemoryAddress.x64dbg);

            if (PIDCheatEngine > 0)
            {
                MessageBox.Show(Messages.CEMessage);

            }
            else if (PIDx64dbg > 0)
            {
                MessageBox.Show(Messages.xMessage);

            }
            foreach (Process pro in Process.GetProcesses())
            {
                if (pro.ProcessName.ToLower().Contains("cheat") && pro.ProcessName.ToLower().Contains("engine"))
                {
                    MessageBox.Show(Messages.CEMessage);
                }
            }

            if (PID > 0)
            {
                Injected injected = new Injected();
                InjectedMore injectedMore = new InjectedMore();
                injected.Show();
                injectedMore.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(Messages.DTEK);

            }


        }

    }
}
