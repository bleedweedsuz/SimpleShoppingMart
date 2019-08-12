using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


namespace MartSolution
{
    class UtilityClass
    {
        #region "Inventory Utils"
        /// <summary>
        /// <para>Deleted or Cancel = 0</para> 
        /// <para>Damage = 1</para>
        /// <para>Expired = 2</para>
        /// <para>Initial Stock =3 </para>
        /// <para>Lost = 4</para>
        /// <para>Purchase = 5</para>
        /// <para>Sales = 6</para>
        /// <para>Sales Return = 7</para>
        /// <para>Opening Stock = 8</para>
        /// </summary>
        /// <param name="StatusStr"></param>
        /// <returns>Inventory Status Code</returns>
        public static int getInventoryStatusCode(String StatusStr)
        {
            int SCode = 0;
            if (StatusStr.Equals("Damage"))
            {
                SCode = 1;
            }
            else if (StatusStr.Equals("Expired"))
            {
                SCode = 2;
            }
            else if (StatusStr.Equals("Initial Stock"))
            {
                SCode = 3;
            }
            else if (StatusStr.Equals("Lost"))
            {
                SCode = 4;
            }
            else if (StatusStr.Equals("Purchase"))
            {
                SCode = 5;
            }
            else if (StatusStr.Equals("Sales"))
            {
                SCode = 6;
            }
            else if (StatusStr.Equals("Sales Return"))
            {
                SCode = 7;
            }
            else if (StatusStr.Equals("Opening Stock"))
            {
                SCode = 7;
            }
            return SCode;
        }
        /// <summary>
        /// <para>Deleted or Cancel = 0</para> 
        /// <para>Damage = 1</para>
        /// <para>Expired = 2</para>
        /// <para>Initial Stock =3 </para>
        /// <para>Lost = 4</para>
        /// <para>Purchase = 5</para>
        /// <para>Sales = 6</para>
        /// <para>Sales Return = 7</para>
        /// <para>Opening Stock = 8</para>
        /// </summary>
        /// <param name="StatusStr"></param>
        /// <returns>Inventory Status String</returns>
        public static String getInventoryStatusString(int StatusCode)
        {
            String StatusString = "";
            if (StatusCode == 0)
            {
                StatusString = "Nothing";
            }
            else if (StatusCode == 1)
            {
                StatusString = "Damage";
            }
            else if (StatusCode == 2)
            {
                StatusString = "Expired";
            }
            else if (StatusCode == 3)
            {
                StatusString = "Initial Stock";
            }
            else if (StatusCode == 4)
            {
                StatusString = "Lost";
            }
            else if (StatusCode == 5)
            {
                StatusString = "Purchase";
            }
            else if (StatusCode == 6)
            {
                StatusString = "Sales";
            }
            else if (StatusCode == 7)
            {
                StatusString = "Sales Return";
            }
            else if (StatusCode == 8)
            {
                StatusString = "Opening Stock";
            }
            return StatusString;
        }
        #endregion
        /// <summary>
        /// Get Token using yyyy-M-d-HH-mm format
        /// </summary>
        /// <returns>New Token String</returns>
        public static string GetNewToken()
        {
            int randData = new Random().Next(111111, 9999999);
            return DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff_") + randData.ToString();
        }
        /// <summary>
        /// <para>Cancel = 0</para>
        /// <para>Saved = 1</para>
        /// <para>Draft-Cancel = 2</para>
        /// </summary>
        /// <param name="StatusStr"></param>
        /// <returns>Purchase Status String</returns>
        public static String getPurchaseStatusString(int StatusCode)
        {
            String StatusString = "";
            if (StatusCode == 0)
            {
                StatusString = "Cancel";
            }
            else if (StatusCode == 1)
            {
                StatusString = "Saved";
            }
            else if (StatusCode == 2)
            {
                StatusString = "Draft-Cancel";
            }
            return StatusString;
        }
        //Encryption
        public static string EncryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }
        public static string DecryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }
        private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }
        private static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }
    }
}
