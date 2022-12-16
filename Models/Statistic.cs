using System.Windows.Forms;

namespace ClinicManagement.Models
{
    public class Statistic
    {
        public Statistic(int day, int patientCount, int revenue)
        {
            Day = day;
            PatientCount = patientCount;
            Revenue = revenue;
        }

        public Statistic(DateTime date, int patientCount, int revenue)
        {
            Day = date.Day;
            PatientCount = patientCount;
            Revenue = revenue;
        }

        public Statistic (Statistic statistic)
        {
            this.Day = statistic.Day;
            this.PatientCount = statistic.PatientCount;
            this.Revenue = statistic.Revenue;
        }

        public int Day { get; }
        public int PatientCount { get; }
        public int Revenue { get; }
        public float Ratio
        {
            get
            {
                return Revenue / (float)PatientCount;
            }
        }
    }
}
