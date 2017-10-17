using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.UWP;
using Xamarin.Forms;
using App2;
using System.IO;
using Windows.Storage;

[assembly: Dependency(typeof(UWP_SQLite))]
namespace App2.UWP
{
  public class UWP_SQLite : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
