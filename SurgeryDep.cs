using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    [Serializable]
    public class SurgeryDep : Department
    {
        private int _surgeryRoomsCount { get; set; }

        public SurgeryDep(string hospitalName) : base("Surgery", hospitalName)
        {
            _surgeryRoomsCount = 0;
        }
        public void addSurgeryRoom()
        {
            _surgeryRoomsCount++;
        }
        public override string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hospital: {this.getHospitalName()}");
            sb.AppendLine("Surgery department information: ");
            sb.AppendLine($"Availble  surgery rooms: {this._surgeryRoomsCount}");
            sb.AppendLine($"Availble surgents: {this.getDoctorsList().Count()}");
            sb.AppendLine($"Petient amount: {this.getPetientsList().Count()}");
            return sb.ToString();
        }
        public int getSurgeryRoomsCount()
        {
            return this._surgeryRoomsCount;
        }
        public void setSurgeryRoomsCount(int amount)
        {
            this._surgeryRoomsCount = amount;
        }
    }
}
