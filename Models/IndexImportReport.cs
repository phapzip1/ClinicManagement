﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class IndexImportReport : ImportReport 
    {
        public IndexImportReport(int index, ImportReport parent) : base(parent) 
        {
            Index = index;
        }
        public int Index { get; }

    }
}
