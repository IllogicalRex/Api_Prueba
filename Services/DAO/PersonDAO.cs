using Contracts.DTO;
using Contracts.Interfaces.IDAO;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace Services.DAO
{
    public class PersonDAO : IPersonDAO
    {
        BaseDataAccess connection = null;
        SqlConnection con = null;
        public PersonDAO()
        {
            connection = new BaseDataAccess("Server=localhost\\MSSQLSERVER2016;Database=Training;Trusted_Connection=True;");
            con = connection.GetConnection();
        }
        public int CreatePerson(PersonDTO person)
        {


            throw new NotImplementedException();
        }

        public int DeletePerson(int PersonId)
        {
            throw new NotImplementedException();
        }

        public List<PersonDTO> GetAllPerson(int role)
        {
            List<PersonDTO> person = null;
            // List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
            // string parameter = string.Empty;
            try
            {

                using (var cmd = new SqlCommand("Get_All_Students", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@role", role);
                    // con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            person.Add(new PersonDTO
                            {
                                IdPerson = Convert.ToInt32(reader["IdPerson"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                BirthDate = Convert.ToDateTime(reader["BirthDate"].ToString()),
                                CreationDate = Convert.ToDateTime(reader["CreationDate"].ToString())
                            });
                        }
                    }
                    con.Close();
                }
            } catch(Exception ex)
            {

            }
            return person;
        }

        public PersonDTO GetPersonPersonById()
        {
            throw new NotImplementedException();
        }

        public List<PersonDTO> GetPersonPersonByName()
        {
            throw new NotImplementedException();
        }

        public int UpdatePerson(PersonDTO person)
        {
            throw new NotImplementedException();
        }
    }
}
