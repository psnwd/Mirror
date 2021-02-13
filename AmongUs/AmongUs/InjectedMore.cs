using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmongUs.Class;
using System.Runtime.InteropServices;

namespace AmongUs
{
    public partial class InjectedMore : Form
    {
        public static Memory.Mem m = new Memory.Mem();

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        #region Strings

        public int SelectedPlayer;

        #endregion

        public InjectedMore()
        {
            InitializeComponent();
        }

        private void InjectedMore_Load(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName(MemoryAddress.WINDOW_NAME); // Get Process ID for Workflow
            if (PID > 0)
            {
                m.OpenProcess(PID);
                HotkeysWorker.RunWorkerAsync();
                FollowApp.RunWorkerAsync();
                ActionWorker.RunWorkerAsync();

            }

        }

        // Speed Trak bar value change after process
        private void SpeedTrackbar_ValueChanged(object sender, EventArgs e)
        {
            if (Speed_checkbox.Checked == true)
            {
                m.WriteMemory(MemoryAddress.Speed, "float", SpeedTrackbar.Value.ToString());
                Thread.Sleep(100);
            }

        }

        #region Tabs click after process

        // Game Math details show case
        private void MatchInfo_tab_Click(object sender, EventArgs e)
        {
            // Load Game Info data
            GameInfoLoad();
        }

        private void Main_tab_Selected(object sender, TabControlEventArgs e)
        {
            // Load Game Info data
            GameInfoLoad();
        }

        #endregion

        #region Other Player Tab buttons

        private void Player_2_btn_Click(object sender, EventArgs e)
        {
            OtherPlayerTabButton();
            Player_2_btn.ForeColor = Color.LimeGreen;
            SelectedPlayer = 2;
        }

        private void Player_3_btn_Click(object sender, EventArgs e)
        {
            OtherPlayerTabButton();
            Player_3_btn.ForeColor = Color.LimeGreen;
            SelectedPlayer = 3;
        }

        private void Player_4_btn_Click(object sender, EventArgs e)
        {
            OtherPlayerTabButton();
            Player_4_btn.ForeColor = Color.LimeGreen;
            SelectedPlayer = 4;
        }

        private void Player_5_btn_Click(object sender, EventArgs e)
        {
            OtherPlayerTabButton();
            Player_5_btn.ForeColor = Color.LimeGreen;
            SelectedPlayer = 5;
        }

        private void Player_6_btn_Click(object sender, EventArgs e)
        {
            OtherPlayerTabButton();
            Player_6_btn.ForeColor = Color.LimeGreen;
            SelectedPlayer = 6;
        }

        private void Player_7_btn_Click(object sender, EventArgs e)
        {
            OtherPlayerTabButton();
            Player_7_btn.ForeColor = Color.LimeGreen;
            SelectedPlayer = 7;
        }

        private void Player_8_btn_Click(object sender, EventArgs e)
        {
            OtherPlayerTabButton();
            Player_8_btn.ForeColor = Color.LimeGreen;
            SelectedPlayer = 8;
        }

        private void Player_9_btn_Click(object sender, EventArgs e)
        {
            OtherPlayerTabButton();
            Player_9_btn.ForeColor = Color.LimeGreen;
            SelectedPlayer = 9;
        }

        private void Player_10_btn_Click(object sender, EventArgs e)
        {
            OtherPlayerTabButton();
            Player_10_btn.ForeColor = Color.LimeGreen;
            SelectedPlayer = 10;
        }

        #endregion

        // Custom Classes

        #region Game Info Class

        private void GameInfoLoad()
        {

            #region Map Reading

            int mapid = m.ReadByte(MemoryAddress.MapID);

            if (mapid == 0)
            {
                MapName_lbl.Text = "THE SKELD";
            }
            else if (mapid == 1)
            {
                MapName_lbl.Text = "MIRAHQ";
            }
            else if (mapid == 2)
            {
                MapName_lbl.Text = "POLUS";
            }

            #endregion

            #region Number of Impostor(s)

            int numofimpostors = m.ReadByte(MemoryAddress.NumOfImpstors);
            NumOfImpstors_lbl.Text = numofimpostors.ToString();

            #endregion

            #region GhostDoTask

            int GhostDoTask = m.ReadByte(MemoryAddress.GhostDoTask);
            GhostDoTask_lbl.Text = GhostDoTask.ToString();

            #endregion

            #region MaxPlayers

            int MaxPlayers = m.ReadByte(MemoryAddress.MaxPlayers);
            MaxPlayers_lbl.Text = MaxPlayers.ToString();

            #endregion

            #region ReportDistance

            float ReportDistance = m.ReadByte(MemoryAddress.ReportDistance);
            ReportDistance_lbl.Text = ReportDistance.ToString();

            #endregion

            #region EmergencyCount

            int EmergencyCount = m.ReadByte(MemoryAddress.EmergencyCount);
            EmergencyCount_lbl.Text = EmergencyCount.ToString();

            #endregion

            #region LongTask

            int LongTask = m.ReadByte(MemoryAddress.LongTask);
            LongTask_lbl.Text = LongTask.ToString();

            #endregion

            #region ShortTask

            int ShortTask = m.ReadByte(MemoryAddress.ShortTask);
            ShortTask_lbl.Text = ShortTask.ToString();

            #endregion

            #region CommonTask

            int CommonTask = m.ReadByte(MemoryAddress.CommonTask);
            CommonTask_lbl.Text = CommonTask.ToString();

            #endregion

            #region DiscussionTime

            int DiscussionTime = m.ReadByte(MemoryAddress.DiscussionTime);
            DiscussionTime_lbl.Text = DiscussionTime.ToString();

            #endregion

            #region VotingTime

            int VotingTime = m.ReadByte(MemoryAddress.VotingTime);
            VotingTime_lbl.Text = VotingTime.ToString();

            #endregion

        }

        #endregion

        #region Other Player Tab button color change

        private void OtherPlayerTabButton()
        {
            Player_1_btn.ForeColor = Color.Black;
            Player_2_btn.ForeColor = Color.Black;
            Player_3_btn.ForeColor = Color.Black;
            Player_4_btn.ForeColor = Color.Black;
            Player_5_btn.ForeColor = Color.Black;
            Player_6_btn.ForeColor = Color.Black;
            Player_7_btn.ForeColor = Color.Black;
            Player_8_btn.ForeColor = Color.Black;
            Player_9_btn.ForeColor = Color.Black;
            Player_10_btn.ForeColor = Color.Black;
        }

        #endregion

        #region Player Names

        private void PlayerNames()
        {
            //var Name = AmongUs.Class.Utils.ReadString(data.PlayerInfo.Value.PlayerName);
        }

        #endregion

        // Background Worker

        #region Hot Keys

        private void HotkeysWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Keys (functions) already activation check
            bool F1_Key = false;
            bool F2_Key = false;
            bool F3_Key = false;
            bool F4_Key = false;
            bool F5_Key = false;
            bool F6_Key = false;
            bool F7_Key = false;
            bool F12_Key = false;

            while (true)
            {
                // ESP key
                if (GetAsyncKeyState(Keys.F1) < 0)
                {
                    if (F1_Key == false)
                    {
                        ESP_checkbox.Checked = true;

                        F1_Key = true;

                    }
                    else if (F1_Key == true)
                    {
                        ESP_checkbox.Checked = false;

                        F1_Key = false;

                    }

                }

                // Speed key
                if (GetAsyncKeyState(Keys.F3) < 0)
                {
                    if (F3_Key == false)
                    {
                        Speed_checkbox.Checked = true;

                        F3_Key = true;

                    }
                    else if (F3_Key == true)
                    {
                        Speed_checkbox.Checked = false;

                        F3_Key = false;

                    }

                }


            }

        }

        #endregion

        #region Follow application works

        private void FollowApp_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                int PID = m.GetProcIdFromName(MemoryAddress.WINDOW_NAME);

                if (PID > 0)
                {

                }
                else
                {
                    Application.Exit();

                }
                Thread.Sleep(300);
            }
        }

        private void Player_1_btn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Action Background Worker

        private void ActionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            #region Impostor Power

            // SABOTAGE PERMS
            if (Sabotage_checkbox.Checked == true)
            {
                m.WriteMemory(MemoryAddress.ImpostorRole, "byte", "1");
                Thread.Sleep(100);
            }
            else if (Sabotage_checkbox.Checked == false)
            {
                m.WriteMemory(MemoryAddress.ImpostorRole, "byte", "1");
                Thread.Sleep(100);
            }

            // KILL PERMS
            if (Kill_checkbox.Checked == true)
            {

            }
            else if (Kill_checkbox.Checked == true)
            {

            }

            // VENT PERMS
            if (Vent_checkbox.Checked == true)
            {

            }
            else if (Vent_checkbox.Checked == true)
            {

            }

            #endregion

            #region Speed

            // SPEED
            if (Speed_checkbox.Checked == true)
            {
                m.WriteMemory(MemoryAddress.Speed, "float", SpeedTrackbar.Value.ToString());
                Thread.Sleep(100);
            }
            else if (Speed_checkbox.Checked == false)
            {
                m.WriteMemory(MemoryAddress.Speed, "float", "1");
                Thread.Sleep(100);
            }

            #endregion

            #region Animations

            // Fake Medbay Scan
            if (Speed_checkbox.Checked == true)
            {

            }
            else if (Speed_checkbox.Checked == false)
            {

            }

            #endregion

            #region Players

            #region Player Name



            #endregion

            #endregion

            // Load Game Info data
            GameInfoLoad();

        }

        #endregion

    } // partial class

} // namespace
