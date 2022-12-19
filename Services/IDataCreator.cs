using ClinicManagement.Models;

namespace ClinicManagement.Services
{
    public interface IDataCreator
    {
        Task CreatePatient(Patient patient);
        Task CreateIllness(Illness illness);
        Task CreateUnit(Unit unit);
        Task CreateMedicine(Medicine medicine);
        Task CreateMethod(Method method);
        Task CreateMedicalNote(MedicalNote medicicalNote);
        Task CreateBill(Bill bill);
        Task CreateImport(Import import);
    }
}
