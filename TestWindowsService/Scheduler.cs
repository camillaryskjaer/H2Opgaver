﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using 

namespace TestWindowsService
{
    public partial class Scheduler : ServiceBase
    {
        private Timer timer1 = null;
        public Scheduler()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer1 = new Timer();
            this.timer1.Interval = 30000; // every 30 secs
            this.timer1.Elapsed += Timer1_Elapsed;
            timer1.Enabled = true;
            Library.WriteErrorLog("Test window service started");
        }

        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Write code here to do some job depends on your requirement
            Library.WriteErrorLog("timer ticked and some job has done successfully");
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            Library.WriteErrorLog("Test window service stopped");
        }

    }
}
