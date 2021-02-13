using AmongUs.OverlaySupporter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUs
{
    public partial class Injected : Form
    {
        Memory.Mem memory = new Memory.Mem();
        overlay overlay = new overlay();

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        public Injected()
        {
            InitializeComponent();
        }

        private void Injected_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            overlay.SetInvi(this, OverlayPanel);
            overlay.StartLoop(10, "Among Us", this);
            Thread tb = new Thread(THEPART) { IsBackground = true };
            tb.Start();
            
        }

        private void THEPART()
        {
            // int PID = memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);

            // Keys (functions) already activation check
            bool F1_Key = false;
            bool F2_Key = false;
            bool F3_Key = false;
            bool F4_Key = false;
            bool F5_Key = false;
            bool F6_Key = false;
            bool F7_Key = false;
            bool F12_Key = false;

            // Infinite loop for get inputs
            while (true)
            {
                // Panel Show and Hide
                if (GetAsyncKeyState(Keys.F12) < 0)
                {
                    if (F12_Key == false)
                    {
                        if(OverlayPanel.Visible == true)
                        {
                            OverlayPanel.Visible = false;
                        }

                        F12_Key = true;

                    }
                    else if (F12_Key == true)
                    {
                        if (OverlayPanel.Visible == false)
                        {
                            OverlayPanel.Visible = true;
                        }

                        F12_Key = false;
                    }

                }

                // ESP key
                if (GetAsyncKeyState(Keys.F1) < 0)
                {
                    if (F1_Key == false)
                    {
                        ESP_lbl.ForeColor = Color.Green;

                        F1_Key = true;

                    }
                    else if (F1_Key == true)
                    {
                        ESP_lbl.ForeColor = Color.Red;

                        F1_Key = false;
                    }

                }

                // Radar Key
                if (GetAsyncKeyState(Keys.F2) < 0)
                {
                    if (F2_Key == false)
                    {
                        RadarMap_lbl.ForeColor = Color.Green;

                        F2_Key = true;
                    }
                    else if (F2_Key == true)
                    {
                        RadarMap_lbl.ForeColor = Color.Red;

                        F2_Key = false;
                    }

                }

                // Speed key
                if (GetAsyncKeyState(Keys.F3) < 0)
                {
                    if (F3_Key == false)
                    {
                        Speed_lbl.ForeColor = Color.Green;

                        memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
                        memory.WriteMemory("GameAssembly.dll+01C4B4B8,5C,24,14", "float", "5");
                        // memory.WriteMemory("GameAssembly.dll+01C4B4B8,5C,24,14", "float", Speed_trackBar.Value.ToString());

                        F3_Key = true;

                    }
                    else if (F3_Key == true)
                    {
                        Speed_lbl.ForeColor = Color.Red;

                        // If user off speed then automaticaly back to defalt (1) speed
                        memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
                        memory.WriteMemory("GameAssembly.dll+01C4B4B8,5C,24,14", "float", "1");

                        F3_Key = false;

                    }

                }

                // No Kill Cooldown key
                if (GetAsyncKeyState(Keys.F4) < 0)
                {
                    if (F4_Key == false)
                    {
                        NoKillCooldown_lbl.ForeColor = Color.Green;

                        F4_Key = true;

                    }
                    else if (F4_Key == true)
                    {
                        NoKillCooldown_lbl.ForeColor = Color.Red;

                        F4_Key = false;
                    }

                }
                
                // No Vote Time key
                if (GetAsyncKeyState(Keys.F5) < 0)
                {
                    if (F5_Key == false)
                    {
                        NoVoteTime_lbl.ForeColor = Color.Green;

                        memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
                        memory.WriteMemory("GameAssembly.dll+01C56548,5C,0,0,28,5C,34,48", "int", "0");

                        F5_Key = true;

                    }
                    else if (F5_Key == true)
                    {
                        NoVoteTime_lbl.ForeColor = Color.Red;

                        F5_Key = false;
                    }

                }

                // No Discussion Time key
                if (GetAsyncKeyState(Keys.F6) < 0)
                {
                    if (F6_Key == false)
                    {
                        NoDiscussionTime_lbl.ForeColor = Color.Green;

                        F6_Key = true;

                    }
                    else if (F6_Key == true)
                    {
                        NoDiscussionTime_lbl.ForeColor = Color.Red;

                        F6_Key = false;
                    }

                }

                // Get Impostor Power
                if (GetAsyncKeyState(Keys.F7) < 0)
                {
                    if (F7_Key == false)
                    {
                        GetImpostorPower_lbl.ForeColor = Color.Green;

                        F7_Key = true;

                    }
                    else if (F7_Key == true)
                    {
                        GetImpostorPower_lbl.ForeColor = Color.Red;

                        F7_Key = false;
                    }

                }

                // CPU interval time
                Thread.Sleep(5);

            }

        }
    }
}
