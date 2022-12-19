namespace ClinicManagement.Models
{
    public class IndexStatistic : Statistic
    {
        public IndexStatistic(int index, Statistic parent) : base (parent)
        {
            Index = index;
        }
        public int Index { get; }
    }
}