using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //初始化武林高手
            var masterList = new List<MartialArtsMaster>(){
    new MartialArtsMaster(){ Id = 1, Name = "黄蓉",    Age = 18, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 9  },
    new MartialArtsMaster(){ Id = 2, Name = "洪七公",  Age = 70, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 10 },
    new MartialArtsMaster(){ Id = 3, Name = "郭靖",    Age = 22, Menpai = "丐帮", Kongfu = "降龙十八掌",Level = 10 },
    new MartialArtsMaster(){ Id = 4, Name = "任我行",  Age = 50, Menpai = "明教", Kongfu = "葵花宝典",  Level = 1  },
    new MartialArtsMaster(){ Id = 5, Name = "东方不败",Age = 35, Menpai = "明教", Kongfu = "葵花宝典",  Level = 10 },
    new MartialArtsMaster(){ Id = 6, Name = "林平之",  Age = 23, Menpai = "华山", Kongfu = "葵花宝典",  Level = 7  },
    new MartialArtsMaster(){ Id = 7, Name = "岳不群",  Age = 50, Menpai = "华山", Kongfu = "葵花宝典",  Level = 8  },
    new MartialArtsMaster() { Id = 8, Name = "令狐冲", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 },
    new MartialArtsMaster() { Id = 9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kongfu = "九阴真经", Level = 8 },
    new MartialArtsMaster() { Id =10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kongfu = "弹指神通", Level = 10 },
    new MartialArtsMaster() { Id = 11, Name = "风清扬", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 }
};
            //初始化武学
            var kongfuList = new List<Kongfu>(){
    new Kongfu(){Id=1, Name="打狗棒法", Power=90},
    new Kongfu(){Id=2, Name="降龙十八掌", Power=95},
    new Kongfu(){Id=3, Name="葵花宝典", Power=100},
    new Kongfu() { Id=  4, Name = "独孤九剑", Power = 100 },
    new Kongfu() { Id = 5, Name = "九阴真经", Power = 100 },
    new Kongfu() { Id = 6, Name = "弹指神通", Power = 100 }
};

            //var res = new List<MartialArtsMaster>();

            //foreach (var temp in masterList)
            //{
            //    if (temp.Level > 8)
            //    {
            //        res.Add(temp);
            //    }
            //}

            //var res = from m in masterList
            //          where m.Level > 8
            //          //select m;
            //          select m.Name;

            //var res = masterList.Where(Test1);

            //var res = from m in masterList
            //          where m.Level > 8 && m.Menpai == "丐帮"
            //          //select m;
            //          select m;

            //var res = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮");

            //var res = from m in masterList
            //          from k in kongfuList
            //          where m.Kongfu == k.Name && k.Power > 90
            //          //select new { master = m, Kongfu = k };
            //          select m;
            //var res = masterList.SelectMany(m => kongfuList, (m, k) => new { master = m, kongfu = k })
            //    .Where(x => x.master.Kongfu == x.kongfu.Name && x.kongfu.Power > 90);

            //var res = from m in masterList
            //          where m.Level > 8 && m.Menpai == "丐帮"
            //          //orderby m.Age
            //          //orderby m.Age descending
            //          orderby m.Level,m.Age
            //          select m;5

            //var res = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮").OrderBy(m => m.Age);

            //var res = from m in masterList
            //          join k in kongfuList on m.Kongfu equals k.Name
            //          where k.Power>90
            //          select new { master = m, kongfu = k };

            //var res = from k in kongfuList
            //          join m in masterList on k.Name equals m.Kongfu
            //          select new { kongfu = k, master = m };

            //var res = from k in kongfuList
            //          join m in masterList on k.Name equals m.Kongfu
            //          into groups
            //          orderby groups.Count()
            //          select new { kongfu = k, count = groups.Count() };

            //var res = from m in masterList
            //          group m by m.Menpai
            //          into g
            //          select new { count = g.Count(), key = g.Key };

            //var res = from m in masterList
            //          group m by m.Kongfu
            //         into g
            //          select new { count = g.Count(), key = g.Key };

            bool res1 = masterList.Any(m => m.Menpai == "长久");
            bool res2 = masterList.All(m => m.Menpai == "丐帮");
            Console.WriteLine(res1);
            Console.WriteLine(res2);


            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}

            Console.ReadKey();

        }

        static bool Test1(MartialArtsMaster master)
        {
            if (master.Level > 8) return true;

            return false;
        }
    }
}
