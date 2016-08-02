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
            var skills = ReadSkills(JobSeekerID);
            if(skills == null)//user is storing skills for the first time
            {
                skill.Name = Name;
                skill.SkillLevel = SkillLevel;
                skill.JobSeekerID = JobSeekerID;
                database.InformalSkills.InsertOnSubmit(skill);
                database.SubmitChanges();
            }else//user is editing skills
            {
                //Research how to update an existing table in LINQ
                skill.Name = Name;
                skill.SkillLevel = SkillLevel;
                skill.JobSeekerID = JobSeekerID;
                database.SubmitChanges();
            }
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