using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    [Serializable]
    public class NeuroSurgery : SurgeryDep
    {
        public int MriMachinesCount;

        public NeuroSurgery(string hospitalName) : base(hospitalName)
        {
            this.changeDepName("Neuro Surgery");
            this.MriMachinesCount = 0;
        }
        public void buyMriMachine()
        {
            this.MriMachinesCount++;
        }
        public void setMriMachinesAmount(int Amount)
        {
            this.MriMachinesCount = Amount;
        }
        public override string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hospital: {this.getHospitalName()}");
            sb.AppendLine("Surgery Subdivision NeuroSurgery information: ");
            sb.AppendLine($"Availble m.r.i machines amount: {this.MriMachinesCount}");
            sb.AppendLine($"Availble  surgery rooms: {this.getSurgeryRoomsCount()}");
            sb.AppendLine($"Availble surgents: {this.getDoctorsList().Count()}");
            sb.AppendLine($"Petient amount: {this.getPetientsList().Count()}");
            return sb.ToString();
        }
    }
}
