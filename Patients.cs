using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    [Serializable]
    public class Patients
    {
        private string _name;
        private double _age;
        private int _patient_number;
        private string _diagnosis;
        private static int _patient_number_gen = 2887563;
        public Patients(string name, double age, string diagnosis)
        {
            this._name = name;
            this._age = age;
            this._patient_number = _patient_number_gen++;
            this._diagnosis = diagnosis;
        }
        static int get_patient_number_gen()
        {
            return _patient_number_gen;
        }
        public string name
        {
            get {return this._name; }
            set { this._name = value; }
        }
        public double age
        {
            get { return this._age; }
            set { this._age = value; }
        }
        public int patient_number
        {
            get { return this._patient_number; }
        }
        public string  GetDiagnosis()
        {
            return this._diagnosis;
        }
        public void set_diagnosis(string new_diagnosis)
        {
            this._diagnosis = new_diagnosis;
        }
    }
}
