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
            bool alreadyExist = false;
            foreach (var tool in db.Tools_Equipments)//loop to ensure it does not ealready exists in the database
            {
                if(tool.JobSeekerID.Equals(JobSeekerID) && tool.Name.Equals(Name))
                {
                    alreadyExist = true;
                }
            }
            if(alreadyExist.Equals(false))//if it does not exist
            {
                te.Name = Name;
                te.Image = Image;
                te.JobSeekerID = JobSeekerID;
                db.Tools_Equipments.InsertOnSubmit(te);
                db.SubmitChanges();
            }           
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
            List<Tools_Equipment> tools = new List<Tools_Equipment>();
            foreach (var tool in database.Tools_Equipments)
            {
                if (tool.JobSeekerID.Equals(JobSeekerID))
                {
                    var te = new Tools_Equipment();
                    te.Tool_EquipmentID = tool.Tool_EquipmentID;
                    te.Name = tool.Name;
                    te.Image = tool.Image;
                    tools.Add(te);
                }
            }
            return tools ;
        }
    }
}