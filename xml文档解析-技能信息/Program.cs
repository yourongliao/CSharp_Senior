using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace xml文档解析_技能信息
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skill> skillList = new List<Skill>();

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("xml技能信息.txt");

            XmlNode skilListNode = xmlDoc.FirstChild.FirstChild;

            XmlNodeList skillListNodeList = skilListNode.ChildNodes;

            foreach (XmlNode skillNode in skillListNodeList)
            {
                Skill skill = new Skill();

                XmlElement ele = skillNode["Name"];

                skill.Name = ele.InnerText;

                XmlAttributeCollection col = skillNode.Attributes;

                XmlAttribute idAttribute = col["SkillID"];

                skill.Id = Int32.Parse(idAttribute.Value);
                skill.EngName = col["SkillEngName"].Value;
                skill.TriggerType = Int32.Parse(col["TriggerType"].Value);
                skill.ImageFile = col["ImageFile"].Value;
                skill.AvailableRace= Int32.Parse(col["AvailableRace"].Value);

                skillList.Add(skill);
            }

            foreach (Skill s in skillList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
