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
            bool aleadyExists = false;
            foreach(var sk in database.InformalSkills)
            {
                if(skill.JobSeekerID.Equals(JobSeekerID) && skill.Name.Equals(SkillLevel))
                {
                    aleadyExists = true;
                }
            }
            if(aleadyExists.Equals(false))
            {
                skill.Name = Name;
                skill.SkillLevel = SkillLevel;
                skill.JobSeekerID = JobSeekerID;
                database.InformalSkills.InsertOnSubmit(skill);
                database.SubmitChanges();
            }              
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