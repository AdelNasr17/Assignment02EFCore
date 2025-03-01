using Assignment02EFCore.DbContexts;
using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Assignment02EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            using ITIDbContext db = new ITIDbContext();

            Student student01 = new Student()
            {

                FName="Adel",
                LName= "Nasr",
                Address= "Cairo",
                Age=22,
                Dep_Id=2
            };

            Student student02 = new Student()
            {

                FName = "Ziad",
                LName = "Amr",
                Address = "Cairo",
                Age = 22,
                Dep_Id = 2
            };


            #region Insert


            //Console.WriteLine(db.Entry<Student>(student01).State);//Detached
            //Console.WriteLine(db.Entry<Student>(student02).State);//Detached
            //db.Add(student01);
            //db.Add(student02);
            //Console.WriteLine("==========After Add =============");
            //Console.WriteLine(db.Entry<Student>(student01).State);//Added
            //Console.WriteLine(db.Entry<Student>(student02).State);//Added
            //db.SaveChanges();
            //Console.WriteLine("==============After SaveChanges============= ");
            //Console.WriteLine(db.Entry<Student>(student01).State);//Unchanged
            //Console.WriteLine(db.Entry<Student>(student02).State);//Unchanged

            #endregion

            #region Select

            //var Result = db.Students.AsNoTracking().FirstOrDefault(S => S.Id == 1);

            //if(Result != null)
            //{
            //    Console.WriteLine(db.Entry<Student>(Result).State);//Unchanged
            //    Console.WriteLine($"STDID={Result.Id} , Name={Result.FName + Result.LName}");
            //}

            #endregion

            #region Update

            //var Result = db.Students.FirstOrDefault(S => S.Id == 2);
            //Result.LName = "Ahmad";

            //Console.WriteLine("============After Alter LName  ============= ");
            //Console.WriteLine(db.Entry<Student>(Result).State);//Modified
            //db.SaveChanges();
            //Console.WriteLine("============After SaveChanges ============= ");
            //Console.WriteLine(db.Entry<Student>(Result).State);//Unchanged




            #endregion

            #region Delete

            //var Result = db.Students.FirstOrDefault(S => S.Id == 2);
            //db.Remove(Result);

            //Console.WriteLine("============After Remove   ============= ");
            //Console.WriteLine(db.Entry<Student>(Result).State);//Deleted
            //db.SaveChanges();
            //Console.WriteLine("============After SaveChanges ============= ");
            //Console.WriteLine(db.Entry<Student>(Result).State);//Detached
            #endregion


        }
    }
}
