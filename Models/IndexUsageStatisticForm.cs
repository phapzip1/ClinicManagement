using ClinicManagement.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class IndexUsageStatisticForm : UsageReport
    {
       public IndexUsageStatisticForm (int index, UsageReport parent) : base (parent)
       {
            Index = index;
       }
       public int Index { get; }
    }
}
