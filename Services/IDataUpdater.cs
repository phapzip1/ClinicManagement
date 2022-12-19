using ClinicManagement.Models;

namespace ClinicManagement.Services
{
    public interface IDataUpdater
    {
        public Task UpdateParameters(int medicalCost, int maxPatients);
        public Task UpdatePassword(string password);
        public Task UpdatePatient(Patient patient);
        public Task UpdateMedicine(Medicine medicine);
        public Task UpdateUnit(Unit unit);
        public Task UpdateIllness(Illness illness);
        public Task UpdateMethod(Method method);
        public Task RemovePatient(string patientId);
        public Task RemoveMedicine(Guid medicineId);
        public Task RemoveUnit(Guid unitId);
        public Task RemoveMethod(Guid methodId);
        public Task RemoveIllness(Guid illnessId);
    }
}
