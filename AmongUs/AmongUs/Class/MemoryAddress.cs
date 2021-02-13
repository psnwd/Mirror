using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmongUs.Class
{
    public class MemoryAddress
    {
        // Process Window Name
        public const string WINDOW_NAME = "Among Us";

        /// <summary>
        /// Game Main Data
        /// </summary>
        public const string Speed = "GameAssembly.dll+01C4B4B8,5C,24,14";
        public const string ImpostorVision = "GameAssembly.dll+01C57F7C,5C,4,1C";
        public const string CrewmateVision = "GameAssembly.dll+01C57F7C,5C,4,18";
        public const string RemainingEmergency = "GameAssembly.dll+01C57F7C,5C,0,48";
        public const string EmergencyCooldown = "GameAssembly.dll+01C57F7C,5C,4,34";
        public const string KillCooldown = "GameAssembly.dll+01C57F7C,5C,4,20";
        public const string KillDistance = "GameAssembly.dll+01C57F7C,5C,4,40";

        /// <summary>
        /// Impostors details
        /// </summary>
        public const string ImpostorRole = "GameAssembly.dll+01C57F7C,5C,0,34,28";

        /// <summary>
        /// Match Info (For each match)
        /// </summary>
        public const string MapID = "GameAssembly.dll+01C57F7C,5C,4,10"; // 4 Byte
        public const string NumOfImpstors = "GameAssembly.dll+01C57F7C,5C,4,38"; // Byte
        public const string GhostDoTask = "GameAssembly.dll+01C57F7C,5C,4,3C"; // 4 Byte
        public const string MaxPlayers = "GameAssembly.dll+01C57F7C,5C,4,8"; // 4 Byte
        public const string ReportDistance = "GameAssembly.dll+01C57F7C,5C,0,2C"; // Float
        public const string EmergencyCount = "GameAssembly.dll+01C57F7C,5C,4,30"; // 4 Byte
        public const string LongTask = "GameAssembly.dll+01C57F7C,5C,4,28"; // 4 Byte
        public const string ShortTask = "GameAssembly.dll+01C57F7C,5C,4,2C"; // 4 Byte
        public const string CommonTask = "GameAssembly.dll+01C57F7C,5C,4,24"; // 4 Byte
        public const string DiscussionTime = "GameAssembly.dll+01C57F7C,5C,4,44"; // 4 Byte
        public const string VotingTime = "GameAssembly.dll+01C57F7C,5C,4,48"; // 4 Byte

        /// <summary>
        /// Player data [PLAYER ID] (Byte)
        /// </summary>
        public const string player_1 = "GameAssembly.dll+01C57F7C,5C,0,34,8"; // Player 1
        public const string player_2 = "GameAssembly.dll+01C57F7C,5C,8,8,14,34,8"; // Player 2
        public const string player_3 = "GameAssembly.dll+01C57F7C,5C,8,8,18,34,8"; // Player 3
        public const string player_4 = "GameAssembly.dll+01C57F7C,5C,8,8,1C,34,8"; // Player 4
        public const string player_5 = "GameAssembly.dll+01C57F7C,5C,8,8,20,34,8"; // Player 5
        public const string player_6 = "GameAssembly.dll+01C57F7C,5C,8,8,24,34,8"; // Player 6
        public const string player_7 = "GameAssembly.dll+01C57F7C,5C,8,8,28,34,8"; // Player 7
        public const string player_8 = "GameAssembly.dll+01C57F7C,5C,8,8,2C,34,8"; // Player 8
        public const string player_9 = "GameAssembly.dll+01C57F7C,5C,8,8,30,34,8"; // Player 9
        public const string player_10 = "GameAssembly.dll+01C57F7C,5C,8,8,34,34,8"; // Player 10

        /// <summary>
        /// Player Color ID [Player Color] (4 Byte)
        /// </summary>
        public const string color_player_1 = "GameAssembly.dll+01C57F7C,5C,0,34,10"; // Player 1
        public const string color_player_2 = "GameAssembly.dll+01C57F7C,5C,8,8,14,34,10"; // Player 2
        public const string color_player_3 = "GameAssembly.dll+01C57F7C,5C,8,8,18,34,10"; // Player 3
        public const string color_player_4 = "GameAssembly.dll+01C57F7C,5C,8,8,1C,34,10"; // Player 4
        public const string color_player_5 = "GameAssembly.dll+01C57F7C,5C,8,8,20,34,10"; // Player 5
        public const string color_player_6 = "GameAssembly.dll+01C57F7C,5C,8,8,24,34,10"; // Player 6
        public const string color_player_7 = "GameAssembly.dll+01C57F7C,5C,8,8,28,34,10"; // Player 7
        public const string color_player_8 = "GameAssembly.dll+01C57F7C,5C,8,8,2C,34,10"; // Player 8
        public const string color_player_9 = "GameAssembly.dll+01C57F7C,5C,8,8,30,34,10"; // Player 9
        public const string color_player_10 = "GameAssembly.dll+01C57F7C,5C,8,8,34,34,10"; // Player 10

        /// <summary>
        /// Is player Dead [IS PLAYER DEAD] (Byte)
        /// </summary>
        public const string isdead_player_1 = "GameAssembly.dll+01C57F7C,5C,0,34,29"; // Player 1
        public const string isdead_player_2 = "GameAssembly.dll+01C57F7C,5C,8,8,14,34,29"; // Player 2
        public const string isdead_player_3 = "GameAssembly.dll+01C57F7C,5C,8,8,18,34,29"; // Player 3
        public const string isdead_player_4 = "GameAssembly.dll+01C57F7C,5C,8,8,1C,34,29"; // Player 4
        public const string isdead_player_5 = "GameAssembly.dll+01C57F7C,5C,8,8,20,34,29"; // Player 5
        public const string isdead_player_6 = "GameAssembly.dll+01C57F7C,5C,8,8,24,34,29"; // Player 6
        public const string isdead_player_7 = "GameAssembly.dll+01C57F7C,5C,8,8,28,34,29"; // Player 7
        public const string isdead_player_8 = "GameAssembly.dll+01C57F7C,5C,8,8,2C,34,29"; // Player 8
        public const string isdead_player_9 = "GameAssembly.dll+01C57F7C,5C,8,8,30,34,29"; // Player 9
        public const string isdead_player_10 = "GameAssembly.dll+01C57F7C,5C,8,8,34,34,29"; // Player 10

        /// <summary>
        /// Player Names (Unicode String [10])
        /// </summary>
        public const string player_name_1 = "GameAssembly.dll+01C57F7C,5C,0,34,c,c"; // Player 1
        public const string player_name_2 = "GameAssembly.dll+01C57F7C,5C,8,8,14,34,C,C"; // Player 2
        public const string player_name_3 = "GameAssembly.dll+01C57F7C,5C,8,8,18,34,C,C"; // Player 3
        public const string player_name_4 = "GameAssembly.dll+01C57F7C,5C,8,8,1C,34,C,C"; // Player 4
        public const string player_name_5 = "GameAssembly.dll+01C57F7C,5C,8,8,20,34,C,C"; // Player 5
        public const string player_name_6 = "GameAssembly.dll+01C57F7C,5C,8,8,24,34,C,C"; // Player 6
        public const string player_name_7 = "GameAssembly.dll+01C57F7C,5C,8,8,28,34,C,C"; // Player 7
        public const string player_name_8 = "GameAssembly.dll+01C57F7C,5C,8,8,2C,34,C,C"; // Player 8
        public const string player_name_9 = "GameAssembly.dll+01C57F7C,5C,8,8,30,34,C,C"; // Player 9
        public const string player_name_10 = "GameAssembly.dll+01C57F7C,5C,8,8,34,34,C,C"; // Player 10

        /// <summary>
        /// Player is Impostor (Byte)
        /// </summary>
        public const string player_imposor_1 = "GameAssembly.dll+01C57F7C,5C,0,34,28"; // Player 1
        public const string player_imposor_2 = "GameAssembly.dll+01C57F7C,5C,8,8,14,34,28"; // Player 2
        public const string player_imposor_3 = "GameAssembly.dll+01C57F7C,5C,8,8,18,34,28"; // Player 3
        public const string player_imposor_4 = "GameAssembly.dll+01C57F7C,5C,8,8,1C,34,28"; // Player 4
        public const string player_imposor_5 = "GameAssembly.dll+01C57F7C,5C,8,8,20,34,28"; // Player 5
        public const string player_imposor_6 = "GameAssembly.dll+01C57F7C,5C,8,8,24,34,28"; // Player 6
        public const string player_imposor_7 = "GameAssembly.dll+01C57F7C,5C,8,8,28,34,28"; // Player 7
        public const string player_imposor_8 = "GameAssembly.dll+01C57F7C,5C,8,8,2C,34,28"; // Player 8
        public const string player_imposor_9 = "GameAssembly.dll+01C57F7C,5C,8,8,30,34,28"; // Player 9
        public const string player_imposor_10 = "GameAssembly.dll+01C57F7C,5C,8,8,34,34,28"; // Player 10

        /// <summary>
        /// My player data
        /// </summary>
        public const string x = "UnityPlayer.dll+012A86E0,80,5C,2C"; // Player X
        public const string y = "UnityPlayer.dll+012A86E0,80,5C,30"; // Player Y


        /// <summary>
        /// Detect debugers [WINDOW NAMES]
        /// </summary>
        public const string cheatengine = "Cheat Engine 7.2"; // Cheat Engine
        public const string x64dbg = "x64dbg"; // x64dbg


    } // Class

} // Namespace
