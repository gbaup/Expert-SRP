using System;
using System.Text;

namespace Library
{
    /*
        Falta el "information holder" por fuera al servicio, quien va a ser el responsable de contener la informacion
        de la cita. Por ejemplo, una clase Appointment, que contenga toda la informacion de la cita, y que el servicio
        solo se encargue de crearla, y no de contenerla.
    */

    public class User
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class Doctor
    {
        public string Name { get; set; }

    }
    public class Appointment
    {
        public User user;
        public DateTime Date { get; set; }
        public string AppoinmentPlace { get; set; }
        public Doctor doctor;
    }

    public class AppointmentService
    {
        public static string CreateAppointment(User paciente, Doctor doctor, DateTime fecha, string lugar)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(paciente.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(paciente.Id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(paciente.PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(lugar))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctor.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                var newAppointment = new Appointment() { user = paciente, doctor = doctor, Date = fecha, AppoinmentPlace = lugar };

                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
