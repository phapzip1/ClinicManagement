
namespace ClinicManagement.Models
{
    public class Patient
    {
        private string id1;
        private string fullname1;
        private string gender1;
        private DateTime dob1;
        private string address1;

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

        //Xử lý get set
        public string Id2 { get => id1; set => id1 = value; }
        public string Fullname2 { get => fullname1; set => fullname1 = value; }
        public string Gender2 { get => gender1; set => gender1 = value; }
        public DateTime Dob2 { get => dob1; set => dob1 = value; }
        public string Address2 { get => address1; set => address1=value; }


        //Biến static cho PatientForm (Để ké)
        private static int _id;
        private static string _name;
        private static int _gender;
        private static DateTime _dob;
        private static string _address;

        //get set cho các biến static để xử lý bảng trong PatientForm
        public static int Id1 { get => _id; set => _id = value; }
        public static string Name { get => _name; set => _name = value; }
        public static int Gender1 { get => _gender; set => _gender = value; }
        public static DateTime Dob1 { get => _dob; set => _dob = value; }
        public static string Address1 { get => _address; set => _address=value; }


    }
}
