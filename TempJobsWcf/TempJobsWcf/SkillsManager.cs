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
            DatabaseClasssesDataContext db = new DatabaseClasssesDataContext();    
            List<InformalSkill> skill = new List<InformalSkill>();
            foreach (var s in db.InformalSkills)
            {
                if(s.JobSeekerID.Equals(JobSeekerID))
                {
                    InformalSkill sk = new InformalSkill();
                    sk.Name = s.Name;
                    sk.SkillLevel = s.SkillLevel;
                    skill.Add(sk);
                }
            }
            return skill;                
        }
    }
}