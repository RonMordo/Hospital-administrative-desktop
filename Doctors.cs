using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    [Serializable]
    public class Doctors
    {
        private string _name;
        private double _age;
        private int _doctor_number;
        private string _proffesion;
        private static int _doctor_number_gen = 2887563;
        public Doctors(string name, double age, string proffesion)
        {
            this._name = name;
            this._age = age;
            this._doctor_number = _doctor_number_gen++;
            this._proffesion = proffesion;
        }
        public string doctor_name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string GetProffesion
        {
            get { return this._proffesion; }
            set { this._proffesion = value; }
        }
        public int doctor_number
        {
            get { return this._doctor_number; }
        }
        public double doctor_age
        {
            get { return this._age; }
        }

    }
}
