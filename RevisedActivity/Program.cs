using RevisedActivityBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RevisedActivityBL.ProjectXBL;

namespace RevisedActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectXBL facBLObj, graBLObj, courseObj ;
            try
            {
                facBLObj = new ProjectXBL();
                var result = facBLObj.FetchAllFaculties();
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Psnumber + item.EmailId + item.Name);
                    }
                }

            }

            catch (Exception ex)
            {
                //throw (ex);
                Console.WriteLine("Something went wrong");
            }

            finally
            {

            }



            Console.WriteLine("\nEnter Psno");
            var Psnumber = Console.ReadLine();
            Console.WriteLine("\nEnter FacultyName");
            var Name = Console.ReadLine();
            Console.WriteLine("\nEnter email");
            var EmailId = Console.ReadLine();

            int result = graBLObj.AddFaculty(Psnumber, EmailId, Name);
            if (result != -1)
            {
                Console.WriteLine($"Returned Value =" + result);
            }
            else
            {
                Console.WriteLine("Sorry ! Pls try again later");
            }




            try
            {
                graBLObj = new ProjectXBL();
                var result = graBLObj.FetchAllGrader();
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.NewBatchID + item.CourseId + item.Result);
                    }
                }

            }

            catch (Exception ex)
            {
                //throw (ex);
                Console.WriteLine("Something went wrong");
            }

            finally
            {

            }



            Console.WriteLine("\nEnter id of new batch");
            var NewBatchID = Console.ReadLine();
            Console.WriteLine("\nEnter CourseId");
            var CourseId = Console.ReadLine();
            Console.WriteLine("\nEnter the result");
            var Result = Console.ReadLine();

            int result = courseBLObj.AddFaculty(Psnumber, EmailId, Name);
            if (result != -1)
            {
                Console.WriteLine($"Returned Value =" + result);
            }
            else
            {
                Console.WriteLine("Sorry ! Pls try again later");
            }



        }
    }
}
