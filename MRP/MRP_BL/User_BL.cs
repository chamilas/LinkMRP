using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using DL;
using System.Configuration;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace SESD.MRP.BL
{
    public class User_BL
    {
        SqlConnection Connection;
        public User_BL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            string key = (string)"LNP";
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public string Decrypt(string cipherString, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            string key = (string)"LNP";

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public int Add(User objUser)
        {
            User_DL objUserDL = new User_DL(Connection);
            try
            {
                objUser.UserPassword = Encrypt(objUser.UserPassword, true);
                return objUserDL.Add(objUser);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            finally
            {
                objUserDL = null;
            }
        }

        public User Login(String UserName, String Password)
        {
            User objUser = new User();
            User_DL objUserDL = new User_DL(Connection);
            try
            {
                String EncryptPass = Encrypt(Password,true);
                objUser = objUserDL.Login(UserName, EncryptPass);
                return objUser;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message, ex);
            }        
        }

        public int Delete(long UserID)
        {
            User_DL objUserDL = new User_DL(Connection);
            try
            {
               return objUserDL.Delete(UserID);
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(User objUser)
        {
            User_DL objUserDL = new User_DL(Connection);
            try
            {
                return objUserDL.Update(objUser);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Clear_Password(User objUser)
        {
            objUser.UserPassword = Encrypt(objUser.UserName, true);
            User_DL objUserDL = new User_DL(Connection);
            try
            {
                return objUserDL.Update(objUser);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_Status(User objUser)
        {
            User_DL objUserDL = new User_DL(Connection);
            try
            {
                return objUserDL.Update_Status(objUser);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
