namespace ClinicManagement.Models
{
    public class IndexStatistic : Statistic
    {
        public IndexStatistic(int index, int total, Statistic parent) : base (parent)
        {
            Index = index;
            _total = total;
        }
        public int Index { get; }
    }
}