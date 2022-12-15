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
