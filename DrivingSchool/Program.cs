using Microsoft.EntityFrameworkCore;
using DrivingSchool.Controllers;
using DrivingSchool.Model.DatabaseModels;
using DrivingSchool.Database;

namespace DrivingSchool
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            VehicleController vehicleController = new VehicleController();
            StudyStreamController studyStreamController = new StudyStreamController();
            using (var context = new ApplicationDataBaseContext())
            {
                foreach (var item in vehicleController.Get())
                {
                    Console.WriteLine(item.Name);
                }
                //StudyStream studyStream = new StudyStream { EndDate = DateTime.Now, DrivingCategoryId = 1 };
                //await studyStreamController.CreateAsync(studyStream);
                var p = context.StudyStreams.Include(x => x.DrivingCategory).ToList();
                Console.WriteLine(p[0].DrivingCategory.CategoryName);

                var studystreams = await studyStreamController.GetStreamsByCategory(1);
                foreach (var item in studystreams)
                {
                    Console.WriteLine(item.CategoryName);
                    Console.WriteLine(item.BeginDate);
                }
            }
        }
    }
}