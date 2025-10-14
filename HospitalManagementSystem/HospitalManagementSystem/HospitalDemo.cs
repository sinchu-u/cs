using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");
            Hospital hospital = new Hospital();
            // Додавання лікарів
            Doctor doctor1 = new Doctor(1, "Рома", "Лор");
            Doctor doctor2 = new Doctor(2, "Оля", "Дерматолог");
            Doctor doctor3 = new Doctor(3, "Віка", "Хірург");
            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);
            hospital.AddDoctor(doctor3);

            // Реєстрація пацієнтів
            Patient patient1 = new Patient(1, "Діма", 20);
            Patient patient2 = new Patient(2, "Іра", 23);
            Patient patient3 = new Patient(3, "Настя", 19);
            hospital.RegisterPatient(patient1);
            hospital.RegisterPatient(patient2);
            hospital.RegisterPatient(patient3);

            // Створення палат
            HospitalRoom room1 = new HospitalRoom(101, 2);
            HospitalRoom room2 = new HospitalRoom(203, 4);
            HospitalRoom room3 = new HospitalRoom(204, 4);
            hospital.CreateRoom(room1);
            hospital.CreateRoom(room2);
            hospital.CreateRoom(room3);

            // Госпіталізація
            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);

            // Медичні записи
            MedicalRecord record1 = new MedicalRecord(patient1, doctor1, DateTime.Now, "Опис 1");
            MedicalRecord record2 = new MedicalRecord(patient1, doctor2, DateTime.Now, "Опис 2");
            MedicalRecord record3 = new MedicalRecord(patient2, doctor3, DateTime.Now, "Опис 3");
            hospital.AddMedicalRecord(record1);
            hospital.AddMedicalRecord(record2);
            hospital.AddMedicalRecord(record3);

            // Історія пацієнта
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            // Статистика
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}