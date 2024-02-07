using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;

namespace OOP_Project
{
    [Serializable]
    public abstract class Department
    {
        private string _departmentName;
        private BindingList<Patients> Patients = new BindingList<Patients>();
        private BindingList<Doctors> Doctors = new BindingList<Doctors>();
        private string _hospitalName;
        private int _amountOfDoctors;
        private int _amountOfPetients;
        public Department(string depName, string hospitalName)
        {
            this._departmentName = depName;
            this._hospitalName = hospitalName;
        }
        public string HospitalName
        {
            get { return _hospitalName; }
            set { _hospitalName = value; }
        }
        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }
        public int AmountOfDoctors
        {
            get { return _amountOfDoctors; }
            set { _amountOfDoctors = value; }
        }
        public int AmountOfPetients
        {
            get { return _amountOfPetients; }
            set { _amountOfPetients = value; }
        }              
        public string getDepartmentName()
        {
            return this._departmentName;
        }
        public string getHospitalName()
        {
            return this._hospitalName;
        }
        public BindingList<Patients> getPetientsList()
        {
            return this.Patients;
        }
        public BindingList<Doctors> getDoctorsList()
        {
            return this.Doctors;
        }
        public abstract string ShowInfo();
        public void addDoctor(Doctors new_doctor)
        {
            this.Doctors.Add(new_doctor);
        }
        public void addPetient(Patients new_patient)
        {
            this.Patients.Add(new_patient);
        }
        public void RemoveDoctor(Doctors new_doctor)
        {
            this.Doctors.Remove(new_doctor);
        }
        public void RemovePetient(Patients new_patient)
        {
            this.Patients.Remove(new_patient);
        }               
        public void changeDepName(string newName)
        {
            this._departmentName = newName;
        }        
    }
}
