using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    internal class InforForm
    {
        private static string connects_String = "server=clinic-do-user-13077884-0.b.db.ondigitalocean.com;port=25060;database=clinic;user=doadmin;password=AVNS_9tiZWj1IIbWbJFEFmxw;";
        private static string next_Patient = "0";
        private static int patient_Count = 0;
        private static bool isExam = false;
        private static string patientNow_id = "0";
        private static Queue queue = new Queue();
        public static string Connects_String { get => connects_String; set => connects_String=value; }
        public static string Next_Patient { get => next_Patient; set => next_Patient=value; }
        public static int Patient_Count { get => patient_Count; set => patient_Count=value; }
        public static bool IsExam { get => isExam; set => isExam=value; }
        public static string PatientNow_id { get => patientNow_id; set => patientNow_id=value; }
        public static Queue Queue { get => queue; set => queue=value; }
    }
}
