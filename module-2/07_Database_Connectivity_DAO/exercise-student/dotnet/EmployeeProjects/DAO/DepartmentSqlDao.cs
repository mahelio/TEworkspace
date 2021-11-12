using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class DepartmentSqlDao : IDepartmentDao
    {
        private readonly string connectionString;

        public DepartmentSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Department GetDepartment(int departmentId)
        {
            Department department = null;


            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string sql = "SELECT department_id, name FROM department WHERE department_id = @department_id;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department_id", departmentId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    department = CreateDepartmentFromReader(reader);
                }

                return department;
            }

            // return new Department(0, "Not implemented Yet");
        }

        public IList<Department> GetAllDepartments()
        {

             IList<Department> departments = new List<Department>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "Select * FROM department";
                SqlCommand cmd = new SqlCommand(sql, conn);
            

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Department d = CreateDepartmentFromReader(reader);
                    departments.Add(d);
                }
            }

            return departments;

        }

        public void UpdateDepartment(Department updatedDepartment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE department SET name = @name WHERE department_id = @department_id; ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", updatedDepartment.Name);
                cmd.Parameters.AddWithValue("@department_id", updatedDepartment.DepartmentId);

                cmd.ExecuteNonQuery();
            }
            return;
        }
        


        private Department CreateDepartmentFromReader(SqlDataReader reader)
        {
            // park_name, date_established, area, has_camping 

            Department department = new Department();
            department.Name = Convert.ToString(reader["name"]);
            department.DepartmentId = Convert.ToInt32(reader["department_id"]);
           

            return department;
        }

    }
}
