using LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace json操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Skill> skillList = new List<Skill>();

            //JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("json技能信息.txt"));

            //foreach (JsonData temp in jsonData)
            //{
            //    Skill skill = new Skill();

            //    JsonData idValue = temp["id"];

            //    JsonData nameValue = temp["name"];

            //    JsonData damageValue = temp["damage"];

            //    int id = Int32.Parse(idValue.ToString());

            //    int damage = Int32.Parse(damageValue.ToString());

            //    // Console.WriteLine(id + ":" + nameValue.ToString() + ":" + damage);

            //    skill.id = id;

            //    skill.damage = damage;

            //    skill.name = nameValue.ToString();

            //    skillList.Add(skill);
            //}

            //foreach (var temp in skillList)
            //{
            //    Console.WriteLine(temp);
            //}

            //Console.ReadKey();



            //Skill[] skillArray = JsonMapper.ToObject<Skill[]>(File.ReadAllText("json技能信息.txt"));

            //foreach (var temp in skillArray)
            //{
            //    Console.WriteLine(temp);
            //}

            //Console.ReadKey();


            //List<Skill> skillList = JsonMapper.ToObject<List<Skill>>(File.ReadAllText("json技能信息.txt"));

            //foreach (var temp in skillList)
            //{
            //    Console.WriteLine(temp);
            //}

            //Console.ReadKey();



            Player p = JsonMapper.ToObject<Player>(File.ReadAllText("主角信息.txt"));

            Console.WriteLine(p);

            foreach (var temp in p.SkillList)
            {
                Console.WriteLine(temp);
            }

            //Console.ReadKey();

            //Player p = new Player();

            //p.Name = "老师来了";

            //p.Level = 100;

            //p.Age = 52;

            //string json = JsonMapper.ToJson(p);

            //Console.WriteLine(json);

            Console.ReadKey();
            
        }
    }
}
