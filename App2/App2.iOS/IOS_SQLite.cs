using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using App2.iOS;
using System.IO;
using Xamarin.Forms;
using SQLite;
using App2;


[assembly: Dependency(typeof(IOS_SQLite))]
namespace App2.iOS
{
    public class IOS_SQLite : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libfolder = Path.Combine(docFolder, "..", "Library", "DataBase");
            if (!Directory.Exists(libfolder))
            {
                Directory.CreateDirectory(libfolder);
            }
            return Path.Combine(libfolder, filename);

        }
    }
}