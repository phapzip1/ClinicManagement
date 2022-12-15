namespace ClinicManagement.Services
{
    public interface IDataUpdater
    {
        public Task UpdateParameters(int medicalCost, int maxPatients);
        public Task UpdatePassword(string password);
    }
}
