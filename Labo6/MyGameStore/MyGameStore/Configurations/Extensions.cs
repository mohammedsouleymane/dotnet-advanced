using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OfficeOpenXml;

namespace MyGameStore.Configurations
{
    public static class Extensions
    {
        public static void PushData(this EntityTypeBuilder<Store> builder )
        {
            builder.HasData(LoadStores().Result);
        }
        public static void PushData(this EntityTypeBuilder<Person> builder)
        {
            builder.HasData(LoadPeople().Result);
        }

        #region Read Excel
        private static async Task<List<Store>> LoadStores()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var file = new FileInfo(@"D:\Downloads\MyGameStore seed data.xlsx");
            using var package = new ExcelPackage(file);
            await package.LoadAsync(file);
            var ws = package.Workbook.Worksheets[0];
            List<Store> stores = new List<Store>();
            for (int i = 2; i <= ws.Dimension.End.Row; i++)
            {               
                stores.Add(new Store {Id=i-1, Name=ws.Cells[i,1].Value.ToString() ,Street= ws.Cells[i, 2].Value.ToString(),Number=int.Parse(ws.Cells[i, 3].Value.ToString()),Addition= ws.Cells[i, 4].Value?.ToString(),ZipCode= ws.Cells[i, 5].Value.ToString(),City= ws.Cells[i, 6].Value.ToString(),IsFranchiseStore=Boolean.Parse(ws.Cells[i, 7].Value.ToString()) });
            }
            return stores;
        }

        private static async Task<List<Person>> LoadPeople()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var file = new FileInfo(@"D:\Downloads\MyGameStore seed data.xlsx");
            using var package = new ExcelPackage(file);
            await package.LoadAsync(file);
            var ws = package.Workbook.Worksheets[1];
            List<Person> people = new List<Person>();
            for (int i = 2; i < ws.Dimension.End.Row; i++)
            {
                people.Add(new Person {LastName=ws.Cells[i,1].Value.ToString(),FirstName=ws.Cells[i,2].Value.ToString(),Email=ws.Cells[i,3].Value?.ToString(), StoreId=null});
            }
            return people.GroupBy(n => n.Email).Select(g => g.First()).ToList();
        }
        #endregion
       
    }
}
