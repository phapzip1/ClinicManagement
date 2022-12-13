
namespace ClinicManagement.Models
{
    public class Patient
    {
        public Patient(string id, string fullname, string gender, DateTime dob, string address)
        {
            Id = id;
            Fullname = fullname;
            Gender = gender;
            Dob = dob;
            Address = address;
        }

        public string Id { get; }
        public string Fullname { get; }
        public string Gender { get; }
        public DateTime Dob { get; }
        public string Address { get; }

    }
}
