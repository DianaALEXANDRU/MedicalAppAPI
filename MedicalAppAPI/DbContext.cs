using MedicalAppAPI.Core.Services;
using MedicalAppAPI.Entities;

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
                Email="popescu@gmail.com",
                MedicalRecords = new List<MedicalRecord>
                {
                   new MedicalRecord
                   {
                       Id=1,
                       Date="10/03/2019",
                       Problem="Appendicitis",
                       PatientId=1
                   },
                   new MedicalRecord
                   {
                       Id=2,
                       Date="20/01/2020",
                       Problem="Covid-19",
                       PatientId=1
                   },
                   new MedicalRecord
                   {
                       Id=3,
                       Date="26/11/2022",
                       Problem="Influenza A",
                       PatientId=1
                   }

                }

            },
            new Patient
            {
                Id=2,
                FirstName="Oana",
                LastName="Muntean",
                CNP="2344567891234",
                PhoneNumber="0711111111",
                Email="oana.m@gmail.com",
                MedicalRecords = new List<MedicalRecord>
                {
                   new MedicalRecord
                   {
                       Id=1,
                       Date="10/03/2019",
                       Problem="Appendicitis",
                       PatientId=2
                   },
                   new MedicalRecord
                   {
                       Id=2,
                       Date="20/01/2020",
                       Problem="Covid-19",
                       PatientId=2

                   },
                   new MedicalRecord
                   {
                       Id=3,
                       Date="26/11/2022",
                       Problem="Influenza A",
                       PatientId=2

                   }

                }

            },
            new Patient
            {
                Id=3,
                FirstName="Maria",
                LastName="Ion",
                CNP="1234567855555",
                PhoneNumber="0700222333",
                Email="maria.ion@gmail.com",
                MedicalRecords = new List<MedicalRecord>
                {
                   new MedicalRecord
                   {
                       Id=1,
                       Date="10/03/2019",
                       Problem="Appendicitis",
                       PatientId=3
                   },
                   new MedicalRecord
                   {
                       Id=2,
                       Date="20/01/2020",
                       Problem="Covid-19",
                       PatientId=3
                   },
                   new MedicalRecord
                   {
                       Id=3,
                       Date="26/11/2022",
                       Problem="Influenza A",
                       PatientId=3
                   }

                }

            },
            new Patient
            {
                Id=4,
                FirstName="Andreea",
                LastName="Cristea",
                CNP="9999887766512",
                PhoneNumber="0788999000",
                Email="andre.cristea@gmail.com",
                MedicalRecords = new List<MedicalRecord>
                {
                   new MedicalRecord
                   {
                       Id=1,
                       Date="10/03/2019",
                       Problem="Appendicitis",
                       PatientId=4
                   },
                   new MedicalRecord
                   {
                       Id=2,
                       Date="20/01/2020",
                       Problem="Covid-19",
                       PatientId=4
                   },
                   new MedicalRecord
                   {
                       Id=3,
                       Date="26/11/2022",
                       Problem="Influenza A",
                       PatientId=4
                   }

                }

            },
            new Patient
            {
                Id=5,
                FirstName="Alexandra",
                LastName="Carstea",
                CNP="1223435465768",
                PhoneNumber="0722343546",
                Email="alexandra@gmail.com",
                MedicalRecords = new List<MedicalRecord>
                {
                   new MedicalRecord
                   {
                       Id=1,
                       Date="10/03/2019",
                       Problem="Appendicitis",
                       PatientId=5
                   },
                   new MedicalRecord
                   {
                       Id=2,
                       Date="20/01/2020",
                       Problem="Covid-19",
                       PatientId=5
                   },
                   new MedicalRecord
                   {
                       Id=3,
                       Date="26/11/2022",
                       Problem="Influenza A",
                       PatientId=5,
                   }

                }

            }
        };
    }
}
