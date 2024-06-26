using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;


namespace FFInternal
{
    internal class clUserPswd
    {
        internal string sUser { get; set; }
        internal byte[] vPW { get; set; }

        private byte[] k = { 0x17, 0x93, 0x41, 0x06, 0xAE, 0x71, 0xF3, 0x88, 0xC1, 0x42, 0x61, 0x74, 0x65, 0x21, 0x37, 0xED };
        private byte[] v = { 0x4E, 0xB1, 0x80, 0x7F, 0x33, 0xCC, 0x0F, 0x5F, 0x29, 0x50, 0x65, 0x63, 0x6B, 0x12, 0x73, 0xDE };

        internal enum enumAuthLevel
        {
            None,
            Lead,
            Supervisor,
            Admin,
            Sa
        }
        
        internal clUserPswd(string UserID, byte[] dbPW)
        {
            sUser = UserID;
            vPW = dbPW;
        }

        public bool PasswordEquals(string inputPswd)
        {
            UTF8Encoding utfEnc = new UTF8Encoding();
            TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();
            ICryptoTransform cTran = tdesProvider.CreateDecryptor(k, v);
            using (MemoryStream memPlainText = new MemoryStream())
            {
                using (CryptoStream cStrm = new CryptoStream(memPlainText, cTran, CryptoStreamMode.Write))
                {
                    cStrm.Write(vPW, 0, vPW.Length);
                    cStrm.FlushFinalBlock();
                    memPlainText.Position = 0;
                    byte[] plainBytes = new byte[memPlainText.Length];
                    memPlainText.Read(plainBytes, 0, (int)memPlainText.Length);
                    return inputPswd.Equals(utfEnc.GetString(plainBytes));
                }
            }
        }

        internal void EncrpytPW(string inputPswd)
        {
            UTF8Encoding utfEnc = new UTF8Encoding();
            byte[] inBytes = utfEnc.GetBytes(inputPswd);
            TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();
            ICryptoTransform cTran = tdesProvider.CreateEncryptor(k, v);
            using (MemoryStream memEncrypted = new MemoryStream())
            {
                using (CryptoStream cStrm = new CryptoStream(memEncrypted, cTran, CryptoStreamMode.Write))
                {
                    cStrm.Write(inBytes, 0, inBytes.Length);
                    cStrm.FlushFinalBlock();
                    memEncrypted.Position = 0;
                    vPW = new byte[memEncrypted.Length];
                    memEncrypted.Read(vPW, 0, (int)memEncrypted.Length);
                }
            }

        }
        internal static bool CheckAuthLevel(string sLvl, enumAuthLevel reqLvl)
        {
            bool bRtn = false;
            string chkLvl = sLvl.ToUpper();
            switch(reqLvl) 
            {
                case enumAuthLevel.Sa:
                    bRtn = (chkLvl == "SA");
                    break;
                case enumAuthLevel.Admin:
                    bRtn = (chkLvl == "ADMIN" || chkLvl == "SA" );
                    break;
                case enumAuthLevel.Supervisor:
                    bRtn = (chkLvl == "ADMIN" 
                        || chkLvl == "SA" 
                        || chkLvl == "SUPERVISOR");
                    break;
                case enumAuthLevel.Lead:
                    bRtn = (chkLvl == "ADMIN"
                        || chkLvl == "SA"
                        || chkLvl == "SUPERVISOR"
                        || chkLvl == "LEAD");
                    break;
            }
            return bRtn;
        }
    }
}
