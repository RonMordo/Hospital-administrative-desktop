using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    [Serializable]
    public class CardiologyDep : Department
    {
        public int _akgMachineAmount;
        public CardiologyDep(string hospitalName) : base("Cardiology", hospitalName)
        {
            this._akgMachineAmount = 0;
        }     
        public void buyAkgMachine(int amount)
        {
            this._akgMachineAmount += amount;
        }
        public void setAkgMachineAmount(int amount)
        {
            this._akgMachineAmount = amount;
        }
        public override string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hospital: {this.getHospitalName()}");
            sb.AppendLine("Cardiology department information: ");
            sb.AppendLine($"Availble a.k.g machines: {this._akgMachineAmount}");
            sb.AppendLine($"Availble cardiology doctors: {this.getDoctorsList().Count()}");
            sb.AppendLine($"Petient amount: {this.getPetientsList().Count()}");
            return sb.ToString();
        }
    }
}
