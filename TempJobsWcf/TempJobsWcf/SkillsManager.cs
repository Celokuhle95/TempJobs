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
            DatabaseClasssesDataContext database = new DatabaseClasssesDataContext();
            //var skills = (from skill in database.InformalSkills
            //             where skill.JobSeekerID.Equals(JobSeekerID)
            //             select skill).ToList();
            //            //{
            //            //    skill.Name,
            //            //    skill.SkillLevel                
            //            //};                   
            //return(List<InformalSkill>)skills;
            List<InformalSkill> ss = new List<InformalSkill>();
            foreach (var s in database.InformalSkills)
            {
                if(s.JobSeekerID.Equals(JobSeekerID))
                {
                    ss.Add(s);
                }
            }
            return ss;
                
        }
    }


}