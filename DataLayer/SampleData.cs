using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public static class SampleData
    {
        public static void InitData(EFDBContext context)
        {
            if(!context.Directory.Any())
            {
                context.Directory.Add(new Entityes.Directory() { Title="Добавить Участника", Html="<b>Directory Content</b>"});
                context.Directory.Add(new Entityes.Directory() { Title = "Посмотреть Участников", Html = "<b>Directory Content</b>" });

                context.SaveChanges();

                context.Material.Add(new Entityes.Material() { Title="Первый Материал", Html="<i>Material Content</i>", DirectoryId = context.Directory.First().Id });
                context.SaveChanges();
            }
        }
    }
}
