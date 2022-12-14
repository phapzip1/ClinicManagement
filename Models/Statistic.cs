namespace ClinicManagement.Models
{
    public class Statistic
    {
        public Statistic(uint day, uint patientCount, uint revenue)
        {
            Day = day;
            PatientCount = patientCount;
            Revenue = revenue;
        }

        public uint Day { get; }
        public uint PatientCount { get; }
        public uint Revenue { get; }
        public float Ratio
        {
            get
            {
                return Revenue / (float)PatientCount;
            }
        }
    }
}
