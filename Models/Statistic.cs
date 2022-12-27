using System.Windows.Forms;

namespace ClinicManagement.Models
{
    public class Statistic
    {

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
        protected int _total;
        public string Ratio
        {
            get
            {
                return (Revenue * 100 / (float)_total).ToString("0.00");
            }
        }
    }
}
