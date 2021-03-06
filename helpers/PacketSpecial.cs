﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacketViewerLogViewer.Packets;

namespace PacketViewerLogViewer.PacketSpecial
{
    public static class CompileSpecialized
    {
        /// <summary>
        /// Client Connect
        /// </summary>
        /// <param name="pd"></param>
        /// <param name="pl"></param>
        public static void In0x00a(PacketData pd, PacketList pl)
        {
            pl.currentParsePlayerID = pd.GetUInt32AtPos(0x04);
            pl.currentParseZone = pd.GetUInt16AtPos(0x30);
            pl.currentParsePlayerName = pd.GetStringAtPos(0x84,16);

            if (GameViewForm.GV != null)
            {
                var GV = GameViewForm.GV;
                GV.gbPlayer.Text = "Player 0x" + pl.currentParsePlayerID.ToString("X8");
                GV.lPlayerName.Text = pl.currentParsePlayerName;
            }
        }

    }
}
