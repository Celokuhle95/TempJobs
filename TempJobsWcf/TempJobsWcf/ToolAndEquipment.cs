using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class ToolAndEquipment
    {
        public void AddNewToolOrEquipment(string Name, string Image, int JobSeekerID)
        {
            DatabaseClasssesDataContext db = new DatabaseClasssesDataContext();
            Tools_Equipment te = new Tools_Equipment();
            te.Name = Name;
            te.Image = Image;
            te.JobSeekerID = JobSeekerID;
            db.Tools_Equipments.InsertOnSubmit(te);
            db.SubmitChanges();
        }
        public void RemoveToolOrEquipment(int tool_equipementID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            Tools_Equipment te = (from tool in database.Tools_Equipments
                                 where tool.Tool_EquipmentID == tool_equipementID
                                     select tool).Single();
            database.Tools_Equipments.DeleteOnSubmit(te);
        }
        public List<Tools_Equipment> GetToolsAndEquipments(int JobSeekerID)
        {                     
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            var toolsAndEquipments = from te in database.Tools_Equipments
                                     where te.JobSeekerID.Equals(JobSeekerID)
                                     select te;
                                     //select new
                                     //{
                                     //    te.Name,
                                     //    te.Image
                                     //};
                                 
            return (List<Tools_Equipment>)toolsAndEquipments;
        }
    }
}