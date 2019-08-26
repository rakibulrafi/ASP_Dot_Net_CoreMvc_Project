using StudentManagementWithADO.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementWithADO.Models
{
    public class TeacherDataAccessLayer
    {
        string connectionString = ConnectionString.CName;

        public IEnumerable<Teacher> GetAllTeacher()
        {
            List<Teacher> lstTeacher = new List<Teacher>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Teacher teacher= new Teacher();
                    teacher.Id = Convert.ToInt32(rdr["Id"]);
                    teacher.Name = rdr["Name"].ToString();
                    teacher.Skills = rdr["Skills"].ToString();
                    teacher.Salary = Convert.ToInt32(rdr["Salary"]);
                    teacher.AddedOn = Convert.ToDateTime(rdr["AddedOn"]);
                    lstTeacher.Add(teacher);
                }
                con.Close();
            }
            return lstTeacher;
        }


        public void AddTeacher(Teacher teacher)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", teacher.Name);
                cmd.Parameters.AddWithValue("@Skills", teacher.Skills);
                cmd.Parameters.AddWithValue("@Salary", teacher.Salary);
                cmd.Parameters.AddWithValue("@TotalStudents", teacher.TotalStudents);
                cmd.Parameters.AddWithValue("@AddedOn",teacher.AddedOn );
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateStudent(Teacher teacher)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", teacher.Name);
                cmd.Parameters.AddWithValue("@Skills", teacher.Skills);
                cmd.Parameters.AddWithValue("@Salary", teacher.Salary);
                cmd.Parameters.AddWithValue("@TotalStudents", teacher.TotalStudents);
                cmd.Parameters.AddWithValue("@AddedOn", teacher.AddedOn);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Teacher GetTeacherData(int? id)
        {
            Teacher teacher = new Teacher();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Teacher WHERE Id= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmd.Parameters.AddWithValue("@Name", teacher.Name);
                    cmd.Parameters.AddWithValue("@Skills", teacher.Skills);
                    cmd.Parameters.AddWithValue("@Salary", teacher.Salary);
                    cmd.Parameters.AddWithValue("@TotalStudents", teacher.TotalStudents);
                    cmd.Parameters.AddWithValue("@AddedOn", teacher.AddedOn);

                }
            }
            return teacher;
        }

        public void DeleteTeacher(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }




        }   }
}
