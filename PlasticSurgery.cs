using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    [Serializable]
    public class PlasticSurgery : SurgeryDep
    {
        public int _siliconeAmount;
        public PlasticSurgery(string hospitalName) : base(hospitalName)
        {
            this.changeDepName("Surgery Subdivision Plastic");
            this._siliconeAmount = 0;
        }
        public override string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hospital: {this.getHospitalName()}");
            sb.AppendLine("Surgery Subdivision Plastic information: ");
            sb.AppendLine($"Silicone amount: {this._siliconeAmount}");
            sb.AppendLine($"Availble  surgery rooms: {this.getSurgeryRoomsCount()}");
            sb.AppendLine($"Availble surgents: {this.getDoctorsList().Count()}");
            sb.AppendLine($"Petient amount: {this.getPetientsList().Count()}");
            return sb.ToString();
        }
        public void setSiliconeAmount(int Amount)
        {
            this._siliconeAmount = Amount;
        }
    }
}
