using MedicalAppAPI.Core.Services;
using MedicalAppAPI.DataLayer.Entities;

namespace MedicalAppAPI
{
    public class DbContext
    {
        public static List<Patient> Patients = new List<Patient>
        {
            new Patient
            {  
                Id=1,
                FirstName="Ion",
                LastName="Popescu",
                CNP="1234567891234",
                PhoneNumber="0712121232",
                Email="popescu@gmail.com"

            },
            new Patient
            {
                Id=2,
                FirstName="Oana",
                LastName="Muntean",
                CNP="2344567891234",
                PhoneNumber="0711111111",
                Email="oana.m@gmail.com"

            },
            new Patient
            {
                Id=3,
                FirstName="Maria",
                LastName="Ion",
                CNP="1234567855555",
                PhoneNumber="0700222333",
                Email="maria.ion@gmail.com"

            },
            new Patient
            {
                Id=4,
                FirstName="Andreea",
                LastName="Cristea",
                CNP="9999887766512",
                PhoneNumber="0788999000",
                Email="andre.cristea@gmail.com"

            },
            new Patient
            {
                Id=5,
                FirstName="Alexandra",
                LastName="Carstea",
                CNP="1223435465768",
                PhoneNumber="0722343546",
                Email="alexandra@gmail.com"

            }
        };
    }
}
