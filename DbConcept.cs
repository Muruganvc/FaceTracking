﻿
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Common;

namespace FaceTracking
{
    public class DbConcept
    {
        private readonly string _connectionString;
        public DbConcept()
        {
            _connectionString = ConfigurationManager.AppSettings["connectionString"];
        }
        public int NewUser(string userName, string firstName, string lastName, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string pwd = Core.Encrypt(password);
                string sql = "insert into [user] (FirstName,LastName,UserName,password) " +
                    "values('" + firstName + "','" + lastName + "','" + userName + "','" + pwd + "');";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    int iResult = command.ExecuteNonQuery();
                    connection.Close();
                    return iResult;
                }
            }
        }

        public UserDto Login(string userName, string password)
        {
            UserDto userDto = new UserDto();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string sqlQuery = "\r\nSelect userId,UserName,firstName,lastName from [user]" +
                    " where userName ='" + userName + "' and password='" + password + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    userDto.UserId = Convert.ToInt32(rdr["userId"]);
                    userDto.FirstName = rdr["FirstName"].ToString();
                    userDto.LastName = rdr["LastName"].ToString();
                    userDto.UserName = rdr["UserName"].ToString();
                }
                return userDto;
            }
        }

        public StudetnDto FindStudent(string StudetnRollNumber)
        {
            StudetnDto student = new StudetnDto();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string sqlQuery = "Select * From Entrollment Where RollNo ='"+ StudetnRollNumber + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    student.Entrollmentid = int.Parse( rdr["Entrollmentid"].ToString());
                    student.FirstName = rdr["FirstName"].ToString();
                    student.LastName = rdr["LastName"].ToString();
                    student.Address = rdr["Address"].ToString();
                    student.Contact = rdr["Contact"].ToString();
                    student.Age = int.Parse( rdr["age"].ToString());
                    student.Gender = rdr["Gender"].ToString();
                    student.Photo = (byte[]) rdr["StudentPhoto"];
                    student.Dob = DateTime.Parse(rdr["DOB"].ToString());
                }
                return student;
            }
        }

        public string ForgetPassword(string userName)
        {
            string Password = string.Empty;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string sqlQuery = "\r\nSelect password from [user]" +
                    " where userName ='" + userName + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Password = Core.Decrypt(rdr["password"].ToString());
                }
            }
            return Password;
        }

        public int NewEntrollment(string Rollno, string FirstName, string Lastname, int age, string Contact, string Address,
            string Gender, DateTime DOB, byte[] StudentPhoto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Entrollment(Rollno,FirstName,Lastname,Age,Contact,Address,Gender,DOB,StudentPhoto) " +
                     "VALUES(@Rollno,@FirstName,@Lastname,@Age,@Contact,@Address,@Gender,@DOB,@StudentPhoto)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Rollno", Rollno);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@Lastname", Lastname);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Contact", Contact);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@DOB", DOB);
                    command.Parameters.AddWithValue("@StudentPhoto", StudentPhoto);
                    int iResult = command.ExecuteNonQuery();
                    connection.Close();
                    return iResult;
                }
            }
        }

        public int NewAttendance(string rollNumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Attendance(Rollno) " +
                     "VALUES(@Rollno)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Rollno", rollNumber);
                    int iResult = command.ExecuteNonQuery();
                    connection.Close();
                    return iResult;
                }
            }
        }

        public bool CheckAttendance(string rollNumber)
        {
            int iResult = 0;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string sqlQuery = "Select count(1) as Cnt from Attendance Where RollNo =@RollNo  and EntryDate = CAST(@Entrydate as DATE)";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                cmd.Parameters.AddWithValue("@RollNo", rollNumber);
                cmd.Parameters.AddWithValue("@EntryDate", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    iResult = (int) rdr["Cnt"];
                }
            }
            return iResult > 0;
        }

        public int UpdateEntrollment(int enrollmentId,string Rollno, string FirstName, string Lastname, int age, string Contact, string Address,
            string Gender, DateTime DOB, byte[] StudentPhoto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Update Entrollment Set Rollno=@Rollno,FirstName=@FirstName,Lastname=@Lastname,Age=@Age,Contact=@Contact," +
                    "Address=@Address,Gender=@Gender,DOB=@DOB,StudentPhoto=@StudentPhoto Where Entrollmentid =@Entrollmentid ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Entrollmentid", enrollmentId);
                    command.Parameters.AddWithValue("@Rollno", Rollno);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@Lastname", Lastname);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Contact", Contact);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@DOB", DOB);
                    command.Parameters.AddWithValue("@StudentPhoto", StudentPhoto);
                    int iResult = command.ExecuteNonQuery();
                    connection.Close();
                    return iResult;
                }
            }
        }

        public int DeleteEntrollment(int enrollmentId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = " Delete from Entrollment Where Entrollmentid =@Entrollmentid ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Entrollmentid", enrollmentId);
                    int iResult = command.ExecuteNonQuery();
                    connection.Close();
                    return iResult;
                }
            }
        }

        public DataTable GetAllEnrollment()
        {
            string query = "SELECT * FROM ENTROLLMENT";
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}