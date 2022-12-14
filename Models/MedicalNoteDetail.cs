namespace ClinicManagement.Models
{
    public class MedicalNoteDetail
    {
        public MedicalNoteDetail(Guid medicineId, int quantity, Guid methodId, string medicineName, string method)
        {
            MedicineId=medicineId;
            Quantity=quantity;
            MethodId=methodId;
            MedicineName =medicineName;
            Method=method;
        }

        public MedicalNoteDetail(Guid medicalNoteId, Guid medicineId, string medicineName, Guid unitId, string unitName, int quantity, Guid methodId, string method)
        {
            MedicalNoteId = medicalNoteId;
            MedicineId = medicineId;
            MedicineName = medicineName;
            UnitId = unitId;
            UnitName = unitName;
            Quantity = quantity;
            MethodId = methodId;
            Method = method;
        }

        public Guid MedicalNoteId { get;} 
        public string MedicineName { get; }
        public Guid UnitId { get; }
        public string UnitName { get; }
        public Guid MedicineId { get; }
        public int Quantity { get; }
        public Guid MethodId { get; }
        public string Method { get; }
    }
}
