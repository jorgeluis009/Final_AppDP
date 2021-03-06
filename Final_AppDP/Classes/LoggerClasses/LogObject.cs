﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AppDP.Classes
{
    public class LogObject
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }

        public LogObject(DateTime date, string message)
        {
            Date = date;
            Message = message;
        }

        public override string ToString()
        {
            return Date.ToShortTimeString() + " - " + Message + "\n";
        }
    }
}
