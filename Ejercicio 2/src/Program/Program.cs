using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var paciente = new User() { Name = "Steven Jhonson", Id = "986782342", PhoneNumber = "5555-555-555" };

            var doctor = new Doctor() { Name = "Armand" };

            string appointmentResult = AppointmentService.CreateAppointment(paciente, doctor, DateTime.Now, "Queen Street");
            Console.WriteLine(appointmentResult);

            // string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            // Console.WriteLine(appointmentResult2);
        }
    }
}
