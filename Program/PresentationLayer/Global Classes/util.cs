using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public  static class clsUtil
    {
        public static String GenerateNewGuid()
        {
            return Guid.NewGuid().ToString();
        }
        static bool CreateFolderIfDoesNotExist(string folderPath)
        {
            if (!File.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public static string ReplaceFileNameByGuid(string sourceFile)
        {
            //FileInfo fileInfo = new FileInfo(sourceFile);

            //string extension = fileInfo.Extension;

            return GenerateNewGuid() + Path.GetExtension(sourceFile);
        }
        public static bool CopyImageToImageFolder(ref string sourceFile)
        {
            string destinationFolder = @"C:\DVLD-People-Images\";
            if (!CreateFolderIfDoesNotExist(destinationFolder))
            {
                return false;
            }

            string destinationFile = destinationFolder + ReplaceFileNameByGuid(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                //MessageBox.Show(iox.Message, "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            sourceFile = destinationFile;
            return true;
        }
    }
}

