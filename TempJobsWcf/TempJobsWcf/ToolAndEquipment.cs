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
            Tool_Equipment te = new Tool_Equipment();
            te.Name = Name;
            te.Image = Image;
            te.JobSeekerID = JobSeekerID;
            db.Tool_Equipments.InsertOnSubmit(te);
            db.SubmitChanges();
        }
        public void RemoveToolOrEquipment(int tool_equipementID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            Tool_Equipment te = (from tool in database.Tool_Equipments
                                 where tool.Tool_EquipmentID == tool_equipementID
                                     select tool).Single();
            database.Tool_Equipments.DeleteOnSubmit(te);
        }
        public List<Tool_Equipment> GetToolsAndEquipments(int JobSeekerID)
        {
            List<Tool_Equipment> toolsAndEquipments = new List<Tool_Equipment>();
            try
            {
                DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
                toolsAndEquipments = (from te in database.Tool_Equipments where te.JobSeekerID.Equals(JobSeekerID) select te).ToList();
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return toolsAndEquipments;
        }
    }
}