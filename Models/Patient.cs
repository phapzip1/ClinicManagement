
namespace ClinicManagement.Models
{
    public class Patient
    {
        //public Patient
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


        //Biến static cho dtgv trong PatientForm (Để ké)
        private static int _id;
        private static string _name;
        private static int _gender;
        private static DateTime _dob;
        private static string _address;

        public static int NextPatient = 0;

        //get set cho các biến static để xử lý dtgv trong PatientForm
        public static int Id1 { get => _id; set => _id = value; }
        public static string Name { get => _name; set => _name = value; }
        public static int Gender1 { get => _gender; set => _gender = value; }
        public static DateTime Dob1 { get => _dob; set => _dob = value; }
        public static string Address1 { get => _address; set => _address=value; }


    }
}
