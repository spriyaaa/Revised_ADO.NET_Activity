using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisedActivityDTO; 

namespace RevisedActivityDAL
{
    public class ProjectXDAL
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;
        public ProjectXDAL()
        {
            sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString());
        }

        public List<Faculty> FetchAllFaculties()
        {
            try
            {
                List<Faculty> lstFaculty = new List<Faculty>();
                sqlCmdObj = new SqlCommand(@"SELECT Psnumber, EmailId, Name FROM Mini-Project.Faculty", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drFaculty = sqlCmdObj.ExecuteReader();
                while (drFaculty.Read())
                {
                    //lstEmployee.Add(String.Concat(drEmployee["LoginID"], drEmployee["JobTitle"]));
                    lstFaculty.Add(new Faculty()
                    {
                        Psnumber= drFaculty["Psnumber"].ToString(),
                        EmailId= drFaculty["EmailId"].ToString(),
                        Name = drFaculty["Name"].ToString()

                    });
                }
                return lstFaculty;
            }



            catch (Exception ex)
            {
                throw (ex);
            }

            finally
            {
                sqlConObj.Close();
            }

        }

        public int AddFaculty(string Psnumber, string EmailId, string Name)
        {

            sqlCmdObj = new SqlCommand("usp_faculty", sqlConObj);
            sqlCmdObj.CommandType = CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@Psnumber", Psnumber);
            sqlCmdObj.Parameters.AddWithValue("@EmailId", EmailId);
            sqlCmdObj.Parameters.AddWithValue("@Name", Name);

            try
            {
                sqlConObj.Open();
                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                int rowAff = sqlCmdObj.ExecuteNonQuery(); //Number of rows Affected.
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong");
                return 0;

            }
            finally
            {
                sqlConObj.Close();
            }
        }

        public List<Grader> FetchAllGrader()
        {
            try
            {
                List<Grader> lstGrader = new List<Grader>();
                sqlCmdObj = new SqlCommand(@"SELECT NewBatchID,CourseId, Result FROM Mini-Project.Grader", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drGrader = sqlCmdObj.ExecuteReader();
                while (drGrader.Read())
                {
                    //lstEmployee.Add(String.Concat(drEmployee["LoginID"], drEmployee["JobTitle"]));
                    lstGrader.Add(new Faculty()
                    {
                        Psnumber = drGrader["NewBatchID"].ToString(),
                        CourseId = drGrader["CourseId"].ToString(),
                        Result = drGrader["Result"].ToString()

                    });
                }
                return lstGrader;
            }



            catch (Exception ex)
            {
                throw (ex);
            }

            finally
            {
                sqlConObj.Close();
            }

        }

        public int AddGrader(string NewBatchID, string CourseId, string Result)
        {

            sqlCmdObj = new SqlCommand("usp_faculty", sqlConObj);
            sqlCmdObj.CommandType = CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@NewBatchID", NewBatchID);
            sqlCmdObj.Parameters.AddWithValue("@CourseId", CourseId);
            sqlCmdObj.Parameters.AddWithValue("@Result", Result);

            try
            {
                sqlConObj.Open();
                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                int rowAff = sqlCmdObj.ExecuteNonQuery(); //Number of rows Affected.
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong");
                return 0;

            }
            finally
            {
                sqlConObj.Close();
            }

        }



        public List<Course> FetchAllCourses()
        {
            try
            {
                List<Course> lstCourse= new List<Course>();
                sqlCmdObj = new SqlCommand(@"SELECT CourseID, CourseOwner,CourseTitle,AssessmentMode, HoursAssigned , CourseSyllabus FROM Mini-Project.Course", sqlConObj);
                sqlConObj.Open();
                SqlDataReader drCourse = sqlCmdObj.ExecuteReader();
                while (drCourse.Read())
                {
                    //lstEmployee.Add(String.Concat(drEmployee["LoginID"], drEmployee["JobTitle"]));
                    lstCourse.Add(new Course()
                    {
                        CourseID= drCourse["Psnumber"].ToString(),
                        CourseOwner = drCourse[" CourseOwner"].ToString(),
                        CourseTitle= drCourse["CourseTitle"].ToString(),
                        AssessmentMode= Convert.ToInt32(drCourse["AssessmentMode"]),
                        HoursAssigned= Convert.ToInt32(drCourse["HoursAssigned"]),
                        CourseSyllabus = drCourse["CourseSyllabus"].ToString()

                    });
                }
                return lstCourse;
            }



            catch (Exception ex)
            {
                throw (ex);
            }

            finally
            {
                sqlConObj.Close();
            }

        }

        public int AddCourse(string CourseID, string CourseOwner, string CourseTitle, int  AssessmentMode, int HoursAssigned , string CourseSyllabus)
        {

            sqlCmdObj = new SqlCommand("usp_faculty", sqlConObj);
            sqlCmdObj.CommandType = CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@CourseID", CourseID);
            sqlCmdObj.Parameters.AddWithValue("@CourseOwner", CourseOwner);
            sqlCmdObj.Parameters.AddWithValue("@CourseTitle", CourseTitle);
            sqlCmdObj.Parameters.AddWithValue("@AssessmentMode", AssessmentMode);
            sqlCmdObj.Parameters.AddWithValue("@HoursAssigned", HoursAssigned);
            sqlCmdObj.Parameters.AddWithValue("@CourseSyllabus", CourseSyllabus);

            try
            {
                sqlConObj.Open();
                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                int rowAff = sqlCmdObj.ExecuteNonQuery(); //Number of rows Affected.
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong");
                return 0;

            }
            finally
            {
                sqlConObj.Close();
            }
        }
    }
}
