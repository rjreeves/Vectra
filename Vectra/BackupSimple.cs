using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//using System.Configuration;

namespace Vectra
{
    static class BackupSimple
    {

        private static string getDataPath()
        {            
            string connstr = myConfig.connstr;
            string[] strElements = connstr.Split('=');
            string[] strElement = strElements[1].Split('"');
            return strElement[1];
        }

        private static string getBackupPath()
        {
            return Properties.Settings.Default.BackupFolder.ToString();
        }

        public static void Copy2Drive(string toDrive)
        {
            string sourceDirectory = getBackupPath();
            CopyDir.Copy(sourceDirectory, toDrive);
        }


        public static void doBackup(int repository)
        {
            string nowTimeStamp = DateTime.Now.ToString("yyyyMMddhhmmss");
            
            string progFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                        
            string backupFolder = getBackupPath().Replace(@"\", @"/");
            switch (repository)
            {
                case 0: backupFolder = backupFolder + @"/Daily/"; break;
                case 1: backupFolder = backupFolder + @"/Daily/"; break;
                case 2: backupFolder = backupFolder + @"/Weekly/"; break;
                case 3: backupFolder = backupFolder + @"/Monthly/"; break;
                case 4: backupFolder = backupFolder + @"/Yearly/"; break;
            }

            string appDatabase = getDataPath();
            
            if (!File.Exists(appDatabase)) { MessageBox.Show("unable to find database at " + appDatabase.ToString()); }
            // string backupFile = @"'" + backupFolder + @"PROD" + nowTimeStamp.ToString() + @".db3'";
            string backupFile = @"'" + backupFolder + @"PROD" + @".db3'";
            backupFile = backupFile.Replace(@"\", @"/");
            
            //Create a new process info structure.
            ProcessStartInfo pInfo = new ProcessStartInfo();

            //Set the file name member of the process info structure.            
            pInfo.WorkingDirectory = getBackupPath().ToString();
            pInfo.FileName = progFolder.ToString() + @"\Vectra\Bin\sqlite3.exe";

            if (!File.Exists(pInfo.FileName.ToString()))
            {
                MessageBox.Show(String.Format("File not found. {0}", pInfo.FileName.ToString()), "Backup Failure");
            }
            else
            {
                pInfo.Arguments = @"""" + appDatabase.ToString() + @"""" + @" " + @"""" + ".backup main " + backupFile.ToString() + @"""";
                pInfo.WindowStyle = ProcessWindowStyle.Hidden;

                //Start the process.
                Process p = Process.Start(pInfo);
                //Wait for the window to finish loading.
                //p.WaitForInputIdle();
                //Wait for the process to end.
                p.WaitForExit();
            }
        }

        /* NO LONGER VALID. REPLACED WITH ABOVE WHICH IS more portable!!
        public static void doBackup1(int repository)
        {
            string nowTimeStamp = DateTime.Now.ToString("yyyyMMddhhmmss");
            //Get the path to the system folder.
            string progFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            appDataFolder = appDataFolder.Replace(@"\", @"/");
            string backupFolder = "";
            switch (repository)
            {
                case 0: backupFolder = appDataFolder + @"/vectra/Backup/Daily/"; break;
                case 1: backupFolder = appDataFolder + @"/vectra/Backup/Daily/"; break;
                case 2: backupFolder = appDataFolder + @"/vectra/Backup/Weekly/"; break;
                case 3: backupFolder = appDataFolder + @"/vectra/Backup/Monthly/"; break;
                case 4: backupFolder = appDataFolder + @"/vectra/Backup/Yearly/"; break;
            }

            string appDatabase = appDataFolder + @"\vectra\Data\PROD.db3";
            if (!File.Exists(appDatabase)) { MessageBox.Show("unable to find database at " + appDatabase.ToString()); }
           // string backupFile = @"'" + backupFolder + @"PROD" + nowTimeStamp.ToString() + @".db3'";
            string backupFile = @"'" + backupFolder + @"PROD" + @".db3'";
            backupFile = backupFile.Replace(@"\", @"/");

            //Create a new process info structure.
            ProcessStartInfo pInfo = new ProcessStartInfo();

            //Set the file name member of the process info structure.            
            pInfo.WorkingDirectory = appDataFolder.ToString();
            pInfo.FileName = progFolder.ToString() + @"\Vectra\Bin\sqlite3.exe";

             if (!File.Exists(pInfo.FileName.ToString()))
             {
                 MessageBox.Show(String.Format("File not found. {0}", pInfo.FileName.ToString()),"Backup Failure");
             }
             else
             {
                pInfo.Arguments = @"""" + appDatabase.ToString() + @"""" + @" " + @"""" + ".backup main " + backupFile.ToString() + @"""";
                pInfo.WindowStyle = ProcessWindowStyle.Hidden;

                //Start the process.
                Process p = Process.Start(pInfo);
                //Wait for the window to finish loading.
                //p.WaitForInputIdle();
                //Wait for the process to end.
                p.WaitForExit();            
             }
        }
         */
    }
}
