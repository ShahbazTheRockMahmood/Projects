﻿using PatientDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient myPatient = new Patient();
            myPatient.Surname = "Smith";
            myPatient.Forename = "John";
            Console.WriteLine("Name: " + myPatient.Forename + " " + myPatient.Surname);
            Console.ReadKey();
        }
    }
}
