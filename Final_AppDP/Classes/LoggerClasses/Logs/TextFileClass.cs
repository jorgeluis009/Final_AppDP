using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes.LoggerClasses.Logs
{
    class TextFileClass
    {
        private static TextFileClass file_singleton = null;
        private Stream LogFile;
        private StreamWriter sw;
        private static int fileInstances { get; set; }

        private TextFileClass(){}

        public static TextFileClass GetReference()
        {
            if (file_singleton == null)
            {
                file_singleton = new TextFileClass();
            }

            fileInstances++;
            return file_singleton;
        }

        public void AddLog(LogObject Log)
        {
            string path = GetPath();
            LogFile = File.Open(path, FileMode.Append);
            sw = new StreamWriter(LogFile);
            sw.WriteLine(Log.ToString());
            sw.Close();
        }

        public void Close()
        {
            fileInstances--;
            if (fileInstances == 0)
                sw.Close();
            
        }

        private static string GetPath()
        {
            string x = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Directory.CreateDirectory(x + "\\LogFiles");
            x += "\\LogFiles\\TextLog.txt";
            return x;
        }
    }
}
