using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace FFInternal
{
    class clEncryptDes
    {
        private byte[] key = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        private byte[] iv = { 65, 110, 68, 26, 69, 178, 200, 219 };

        internal Dictionary<string,string> decryptedFields;

        public string ConnectionString
        {
            get
            {
                string rtn = string.Empty;
                if (decryptedFields != null)
                {
                    return  (decryptedFields.TryGetValue("Conn", out rtn)) ? rtn : string.Empty;
                }
                else
                {
                    if (File.Exists("Fastfetch.Lic"))
                    {
                        try
                        {
                            byte[] bEnc = File.ReadAllBytes("Fastfetch.Lic");
                            if (bEnc != null && bEnc.Length > 10)
                            {
                                Decrypt(bEnc);
                                return  (decryptedFields.TryGetValue("Conn", out rtn)) ? rtn : string.Empty;
                            }
                            else
                            {
                                return string.Empty;
                            }
                        }
                        catch (Exception)
                        {
                            return string.Empty;
                        }
                    }
                    else
                    {
                        return string.Empty;
                    } // if license exists
                }
            }
        }

        public int NumLicensedCarts
        {
            get
            {
                string rtn = string.Empty;
                if (decryptedFields != null)
                {
                    int iNum = 0;
                    if (decryptedFields.TryGetValue("Carts", out rtn))
                    {
                        if (int.TryParse(rtn, out iNum))
                        {
                            return iNum;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (File.Exists("Fastfetch.Lic"))
                    {
                        try
                        {
                            byte[] bEnc = File.ReadAllBytes("Fastfetch.Lic");
                            if (bEnc != null && bEnc.Length > 10)
                            {
                                Decrypt(bEnc);
                                int iNum = 0;
                                if (decryptedFields.TryGetValue("Carts", out rtn))
                                {
                                    if (int.TryParse(rtn, out iNum))
                                    {
                                        return iNum;
                                    }
                                    else
                                    {
                                        return 0;
                                    }
                                }
                                else
                                {
                                    return 0;
                                }
                            }
                            else
                            {
                                return 0;
                            }
                        }
                        catch (Exception)
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    } // if license exists
                }
            }
        }

        public string ConnectionString2
        {
            get
            {
                string rtn = string.Empty;
                if (decryptedFields != null)
                {
                    return  (decryptedFields.TryGetValue("Conn2", out rtn)) ? rtn : string.Empty;
                }
                else
                {
                    if (File.Exists("Fastfetch.Lic"))
                    {
                        try
                        {
                            byte[] bEnc = File.ReadAllBytes("Fastfetch.Lic");
                            if (bEnc != null && bEnc.Length > 10)
                            {
                                Decrypt(bEnc);
                                return  (decryptedFields.TryGetValue("Conn2", out rtn)) ? rtn : string.Empty;
                            }
                            else
                            {
                                return string.Empty;
                            }
                        }
                        catch (Exception)
                        {
                            return string.Empty;
                        }
                    }
                    else
                    {
                        return string.Empty;
                    } // if license exists
                }
            }
        }
        public string GNCKey
        {
            get
            {
                string rtn = string.Empty;
                if (decryptedFields != null)
                {
                    return (decryptedFields.TryGetValue("GNC", out rtn)) ? rtn : string.Empty;
                }
                else
                {
                    if (File.Exists("Fastfetch.Lic"))
                    {
                        try
                        {
                            byte[] bEnc = File.ReadAllBytes("Fastfetch.Lic");
                            if (bEnc != null && bEnc.Length > 10)
                            {
                                Decrypt(bEnc);
                                return (decryptedFields.TryGetValue("GNC", out rtn)) ? rtn : string.Empty;
                            }
                            else
                            {
                                return string.Empty;
                            }
                        }
                        catch (Exception)
                        {
                            return string.Empty;
                        }
                    }
                    else
                    {
                        return string.Empty;
                    } // if license exists
                }
            }
        }

		public string GetAdditionalField(string sKey)
		{
            string rtn = string.Empty;
            if (decryptedFields != null)
            {
                return (decryptedFields.TryGetValue(sKey, out rtn)) ? rtn : string.Empty;
            }
            else
            {
                if (File.Exists("Fastfetch.Lic"))
                {
                    try
                    {
                        byte[] bEnc = File.ReadAllBytes("Fastfetch.Lic");
                        if (bEnc != null && bEnc.Length > 10)
                        {
                            Decrypt(bEnc);
                            return (decryptedFields.TryGetValue(sKey, out rtn)) ? rtn : string.Empty;
                        }
                        else
                        {
                            return string.Empty;
                        }
                    }
                    catch (Exception)
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                } // if license exists
            }
		
		}
        public clEncryptDes(string cpy)
        {
            UTF8Encoding utfEnc = new UTF8Encoding();
            byte[] aBytes = utfEnc.GetBytes("bAte594F@stFetchF0rP1ck1ng");
            byte[] bBytes = utfEnc.GetBytes("Bate@w@t");
            byte[] cBytes = utfEnc.GetBytes(cpy);
            for (int i = 0; i < key.Length; i++)
            {
                if ((i % 2 == 0) && i < cBytes.Length)
                {
                    key[i] = cBytes[i];
                }
                else
                {
                    key[i] = aBytes[aBytes.Length - i - 1];
                }
            }
            for (int i = 0; i < iv.Length; i++)
            {
                iv[i] = cBytes[i];
            }
        }

        public byte[] Encrypt(string plainText)
        {
            UTF8Encoding utfEnc = new UTF8Encoding();
            byte[] inBytes = utfEnc.GetBytes(plainText);
            TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();
            ICryptoTransform cTran = tdesProvider.CreateEncryptor(key, iv);
            MemoryStream memEncrypted = new MemoryStream();
            CryptoStream cStrm = new CryptoStream(memEncrypted, cTran, CryptoStreamMode.Write);
            cStrm.Write(inBytes, 0, inBytes.Length);
            cStrm.FlushFinalBlock();
            memEncrypted.Position = 0;
            byte[] rslt = new byte[memEncrypted.Length];
            memEncrypted.Read(rslt, 0, (int)memEncrypted.Length);
            cStrm.Close();
            cStrm.Dispose();
            return rslt;
        }
        private void Decrypt(byte[] inBytes)
        {
            decryptedFields = new Dictionary<string, string>();
            UTF8Encoding utfEnc = new UTF8Encoding();
            TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();
            ICryptoTransform cTran = tdesProvider.CreateDecryptor(key, iv);
            MemoryStream memPlainText = new MemoryStream();
            CryptoStream cStrm = new CryptoStream(memPlainText, cTran, CryptoStreamMode.Write);
            cStrm.Write(inBytes, 0, inBytes.Length);
            cStrm.FlushFinalBlock();
            memPlainText.Position = 0;
            byte[] plainBytes = new byte[memPlainText.Length];
            memPlainText.Read(plainBytes, 0, (int)memPlainText.Length);
            string rslt = utfEnc.GetString(plainBytes);
            while (rslt.Length > 0)
            {
                int i = rslt.IndexOf('<');
                if (i >= 0)
                {
                    int j = rslt.Substring(i).IndexOf('>');
                    if (j > 0)
                    {
                        string sKey = rslt.Substring(i+1, j-1);
                        int k = rslt.Substring(i + j).IndexOf('<');
                        k = (k > 0) ? k - 1 : rslt.Substring(i + j).Length-1;
                        string sVal = rslt.Substring(i + j + 1, k);
                        decryptedFields.Add(sKey, sVal);
                        rslt = rslt.Substring(i + j + k + 1);
                    }
                    else
                    {
                        rslt = rslt.Substring(i);
                    }
                }
                else
                {
                    rslt = string.Empty;
                }
            }
            cStrm.Close();
            cStrm.Dispose();
        }
    }
}
