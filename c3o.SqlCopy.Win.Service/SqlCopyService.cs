﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using c3o.SqlCopy.Data;

namespace c3o.SqlCopy.Win.Service
{
    public partial class SqlCopyService : ServiceBase
    {
        public SqlCopyService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CopyManager.RunCopyJobs();
        }
    }
}
