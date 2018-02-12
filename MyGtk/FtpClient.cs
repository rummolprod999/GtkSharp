using System;
using System.Collections;
using System.Collections.Generic;
using Tamir.SharpSsh;
using Tamir.Streams;
namespace MyGtk
{
    public class SFtpLibrary
    {
        void OSftp_OnTransferProgress(string src, string dst, int transferredBytes, int totalBytes, string message)
        {

        }

        private string urlSFtp;
        private string userSFtp;
        private string passSFtp;
        private string dirFiles = "/mnt/hdd00/backup";
        private string dirBd = "/mnt/hdd00/backup/sql";
        public SFtpLibrary()
        {
            try
            {
                SettingsClass.GetSettings();
            }
            catch
            {

            }
            passSFtp = SettingsClass.password;
            userSFtp = SettingsClass.user;
            urlSFtp = SettingsClass.server;

        }

        public List<string> ClientSFtpBel()
        {
            Sftp oSftp = new Sftp(urlSFtp, userSFtp, passSFtp);
            oSftp.Connect(22);
            ArrayList FileList = oSftp.GetFileList(dirFiles);
            List<string> ls = new List<string>();
            foreach (var i in FileList)
            {
                if (i is string f && f.Contains("www"))
                {
                    ls.Add(f);
                }

            }
            oSftp.Close();
            return ls;
        }

        public List<string> ClientSFtpBelBd()
        {
            Sftp oSftp = new Sftp(urlSFtp, userSFtp, passSFtp);
            oSftp.Connect(22);
            ArrayList FileList = oSftp.GetFileList(dirBd);
            List<string> ls = new List<string>();
            foreach (var i in FileList)
            {
                if (i is string f && f.Contains("mysql"))
                {
                    ls.Add(f);
                }

            }
            oSftp.Close();
            return ls;
        }

        public void GetFileFromBel(string f, FileTransferEvent a, FileTransferEvent b, FileTransferEvent c)
        {
            var e = f;
            Sftp oSftp = new Sftp(urlSFtp, userSFtp, passSFtp);
            oSftp.Connect(22);
            try
            {
                oSftp.OnTransferProgress += a;
                //oSftp.OnTransferProgress += b;
                oSftp.OnTransferEnd += c;

                oSftp.Get($"{dirFiles}/{f}");
            }
            catch
            {


            }
            oSftp.Close();
        }

        public void GetFileBdFromBel(string f, FileTransferEvent a, FileTransferEvent b, FileTransferEvent c)
        {
            var e = f;
            Sftp oSftp = new Sftp(urlSFtp, userSFtp, passSFtp);
            oSftp.Connect(22);
            try
            {
                oSftp.OnTransferProgress += a;
                //oSftp.OnTransferProgress += b;
                oSftp.OnTransferEnd += c;

                oSftp.Get($"{dirBd}/{f}");
            }
            catch
            {


            }
            oSftp.Close();
        }
    }
}
