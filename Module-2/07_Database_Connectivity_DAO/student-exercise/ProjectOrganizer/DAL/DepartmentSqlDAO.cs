using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class DepartmentSqlDAO : IDepartmentDAO
    {
        private string connectionString;

        // Single Parameter Constructor
        public DepartmentSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns a list of all of the departments.
        /// </summary>
        /// <returns></returns>
        public IList<Department> GetDepartments()
        {

            IList<Department> list = new List<Department>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from departments", conn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Department dept = new Department();
                    dept.DepartmentId = Convert.ToInt32(rdr["department_id"]);
                    dept.Name = Convert.ToString(rdr["name"]);

                    list.Add(dept);
                }

            }

            return list;

        }

        /// <summary>
        /// Creates a new department.
        /// </summary>
        /// <param name="newDepartment">The department object.</param>
        /// <returns>The id of the new department (if successful).</returns>
        public int CreateDepartment(Department newDepartment)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("Insert Into department (name) Values (@name); Select @@identity;", conn);

                cmd.Parameters.AddWithValue("@name", newDepartment.Name);

                int newDeptId = Convert.ToInt32(cmd.ExecuteScalar());

                return newDeptId;

            }

        }

        /// <summary>
        /// Updates an existing department.
        /// </summary>
        /// <param name="updatedDepartment">The department object.</param>
        /// <returns>True, if successful.</returns>
        public bool UpdateDepartment(Department updatedDepartment)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Update department Set name = @name Where department_id", conn);

                cmd.Parameters.AddWithValue("@name", updatedDepartment.Name);
                cmd.Parameters.AddWithValue("@department_id", updatedDepartment.DepartmentId);


                int rowsUpdated = cmd.ExecuteNonQuery();
                return rowsUpdated == 1;
            }
            throw new NotImplementedException();
        }


    }

}



