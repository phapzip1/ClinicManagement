using ClinicManagement.DbContexts;
using ClinicManagement.DTOs;
using ClinicManagement.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicManagement.Services
{
    public class DBCreator : IDataCreator
    {
        private readonly ClinicDbContextFactory _dbContextFactory;

        public DBCreator(ClinicDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }


        public async Task CreatePatient(Patient patient)
        {
            using (ClinicDbContext context = _dbContextFactory.CreateDbContext())
            {
                PatientDTO patientDTO = ToPatientDIO(patient);
                context.Patients.Add(patientDTO);
                
                await context.SaveChangesAsync();
            }
        }

        public async Task CreateMedicalNote(MedicalNote medicalNote)
        {
            using (ClinicDbContext context = _dbContextFactory.CreateDbContext())
            {
                MedicalNoteDTO medicalNoteDTO = ToMedicalNoteDTO(medicalNote);
                context.MedicalNotes.Add(medicalNoteDTO);
                context.MedicalNoteDetail.AddRange(medicalNote.Details.Select(e => ToMedicalNoteDetailDTO(e)));
                await context.SaveChangesAsync();
            }
        }

        public async Task CreateImport(Import import)
        {
            using (ClinicDbContext context = _dbContextFactory.CreateDbContext())
            {

                ImportDTO detailDTO = new ImportDTO()
                {
                    Id = import.Id,
                    CreateIn = import.CreateIn,
                    Price = import.Price,
                };
                context.Imports.Add(detailDTO);
                context.ImportDetail.AddRange(ToImportDetailDTOArray(import.Details, import.Id)); 
                await context.SaveChangesAsync().ContinueWith(res =>
                {
                    Console.WriteLine(res.Result);
                });
            }
        }


        public async Task CreateIllness(Illness illness)
        {
            using (ClinicDbContext context = _dbContextFactory.CreateDbContext())
            {
                IllnessDTO illnessDTO = new IllnessDTO()
                {
                    Id = illness.Id,
                    Name = illness.Name,
                    Symptom = illness.Symptom,
                };
                context.Illness.Add(illnessDTO);
                await context.SaveChangesAsync();
            }
        }

        public async Task CreateUnit(Unit unit)
        {
            using (ClinicDbContext context = _dbContextFactory.CreateDbContext())
            {
                UnitDTO unitDTO = new UnitDTO() { 
                    Id = unit.Id, 
                    Name = unit.Name,
                };
                context.Units.Add(unitDTO);
                await context.SaveChangesAsync();
            }
        }

        public async Task CreateMedicine(Medicine medicine)
        {
            using (ClinicDbContext context = _dbContextFactory.CreateDbContext())
            {
                MedicineDTO mediicineDTO = new MedicineDTO()
                {
                    Id = medicine.Id,
                    Name=medicine.Name,
                    UnitId = medicine.UnitId,
                    Stock = 0,
                    Price = medicine.Price
                };
                context.Medicines.Add(mediicineDTO);
                await context.SaveChangesAsync();
            }
        }


        public async Task CreateBill(Bill bill)
        {
            using (ClinicDbContext context = _dbContextFactory.CreateDbContext())
            {
                BillDTO billDTO = new BillDTO()
                {
                    Id = bill.Id,
                    MedicalNoteId = bill.MedicalNoteId,
                    MedicalCost = 0,
                    MedicineCost = 0,
                };
                context.Bills.Add(billDTO);
                await context.SaveChangesAsync();
            }
        }

        private ImportDetailDTO[] ToImportDetailDTOArray(IEnumerable<ImportDetail> details, Guid id)
        {
            return details.Select(e => new ImportDetailDTO() { ImportId = id, MedicineId = e.MedicineId, Quantity = e.Quantity, Price = e.Price }).ToArray();
        }

        private MedicalNoteDetailDTO ToMedicalNoteDetailDTO(MedicalNoteDetail detail)
        {
            return new MedicalNoteDetailDTO()
            {
                MedicalNoteId = detail.MedicalNoteId,
                MedicineId = detail.MedicineId,
                Quantity = detail.Quantity,
                MethodId = detail.MethodId,
            };
        }

        private MedicalNoteDTO ToMedicalNoteDTO(MedicalNote medicalNote)
        {
            return new MedicalNoteDTO()
            {
                Id = medicalNote.Id,
                PatientId = medicalNote.PatientId,
                IllnessId = medicalNote.IllnessId,
                Symtoms = medicalNote.Symtoms,
                CreateIn = medicalNote.CreateIn,
            };
        }

        private PatientDTO ToPatientDIO(Patient patient)
        {
            return new PatientDTO()
            {
                Id = patient.Id,
                Fullname = patient.Fullname,
                Gender = patient.Gender,
                Dob = patient.Dob,
                Address = patient.Address
            };
        }

    }
}
