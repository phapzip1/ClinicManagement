using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    internal class QueueInfor
    {
        private static string stt;
        private static string patient_name;

        public QueueInfor(string a_stt, string a_patient_name)
        {
            stt = a_stt;
            patient_name = a_patient_name;
        }
        public static string Stt { get => stt; set => stt=value; }
        public static string Patient_name { get => patient_name; set => patient_name=value; }
    }
}
