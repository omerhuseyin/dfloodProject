using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFlood.Forms
{
    internal class Variables
    {
        public byte topMostCounter;
        public byte startStopCounter;
        public short messageCounter;
        public short nextWord;
        public short keyWordsCount;
        public int topTimeFloods;
        public byte messageSendInterval = 1;
        public byte min = 2;
        public byte max = 6;
        public short floodCount = 30;
        public byte securityPoint;
        public byte bootDeleteAfter = 0;
        public byte bootScr = 0;
        public byte bootTp = 0;
        public byte bootUnlmtd = 0;
        public byte bootDeleteInt = 0;
        public int topTime;
        public int topTimeDelete;
    }
}