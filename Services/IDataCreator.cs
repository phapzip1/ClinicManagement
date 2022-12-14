using ClinicManagement.Models;

namespace ClinicManagement.Services
{
    public interface IDataCreator
    {
        Task CreatePatient(Patient patient);
    }
}
