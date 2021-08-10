using RevisedActivityDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisedActivityBL
{
    public class ProjectXBL
    {
        ProjectXDAL facDALObj, graDALObj, courseDALObj;
        public ProjectXBL()
        {
            facDALObj = new ProjectXDAL();
            graDALObj = new ProjectXDAL();
        }

        public List<Faculty> FetchAllFaculties()
        {
            try
            {
                var lstFaculties = facDALObj.FetchAllFaculties();
                return lstFaculties;

            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {

            }
        }

        public int AddFaculty(string Psnumber, string Email, string Name)
        {
            try
            {
                return facDALObj.AddFaculty(Psnumber, Email, Name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }
        }


        public List<Grader> FetchAllGrader()
        {
            try
            {
                var lstGrader = facDALObj.FetchAllGrader();
                return lstGrader;

            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {

            }
        }

        public int AddGrader(string NewBatchID, string CourseId, string Result)
        {
            try
            {
                return graDALObj.AddFaculty(NewBatchID, CourseId, Result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }
        }



        public List<Course> FetchAllCourses()
        {
            try
            {
                var lstCourse = courseDALObj.FetchAllCourses();
                return lstCourse;

            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {

            }
        }

        public int AddCourse(string CourseID, string CourseOwner, string CourseTitle, int AssessmentMode, int HoursAssigned, string CourseSyllabus)
        {
            try
            {
                return courseDALObj.AddFaculty(CourseID, CourseOwner, CourseTitle,AssessmentMode,HoursAssigned, string CourseSyllabus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }
        }

    }

}
