using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class SkillsManager
    {
        public void StoreSkills(string Name, int SkillLevel, int JobSeekerID)
        {
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            InformalSkill skill = new InformalSkill();
            
                skill.Name = Name;
                skill.SkillLevel = SkillLevel;
                skill.JobSeekerID = JobSeekerID;
                database.InformalSkills.InsertOnSubmit(skill);
                database.SubmitChanges();
        }

        public List<InformalSkill> ReadSkills(int JobSeekerID)
        {
            List<InformalSkill> skills = new List<InformalSkill>();
            try
            {
                DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
                skills = (from skill in database.InformalSkills where skill.JobSeekerID.Equals(JobSeekerID) select skill).ToList();              
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return skills;
        }
    }


}