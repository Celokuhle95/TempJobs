using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class SkillsManager
    {
        public void StoreSkills(string Name, int UserID)
        {
            userDataClassesDataContext database = new userDataClassesDataContext();
            InformalSkill skill = new InformalSkill();
            skill.Name = Name;
            skill.UserData_ID = UserID;
            database.InformalSkills.InsertOnSubmit(skill);
            database.SubmitChanges();
        }

        public List<InformalSkill> ReadSkills()
        {
            List<InformalSkill> AllSkills = new List<InformalSkill>();
            try
            {
                userDataClassesDataContext database = new userDataClassesDataContext();
                foreach (var skill in database.InformalSkills)
                {
                    InformalSkill currentSkill = new InformalSkill(); //store information of a single skill

                    currentSkill.Skill_ID = skill.Skill_ID;
                    currentSkill.Name = skill.Name;
                    currentSkill.UserData_ID = skill.UserData_ID;

                    AllSkills.Add(currentSkill);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return AllSkills;
        }
    }


}