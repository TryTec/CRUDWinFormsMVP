using CRUDWinFormsMVP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CRUDWinFormsMVP._Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        //Constructor
        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void Add(PetModel petModel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO Pet VALUES(@name, @type, @colour)";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = petModel.Name;
                    command.Parameters.Add("@type", SqlDbType.NVarChar).Value = petModel.Type;
                    command.Parameters.Add("@colour", SqlDbType.NVarChar).Value = petModel.Colour;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"DELETE FROM Pet WHERE Pet_Id = @id";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit(PetModel petModel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Pet SET Pet_Name = @name, Pet_Type = @type, Pet_Colour = @colour WHERE Pet_Id = @id";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = petModel.Name;
                    command.Parameters.Add("@type", SqlDbType.NVarChar).Value = petModel.Type;
                    command.Parameters.Add("@colour", SqlDbType.NVarChar).Value = petModel.Colour;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = petModel.Id;
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<PetModel> GetAll()
        {
            List<PetModel> petList = new List<PetModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Pet ORDER BY Pet_Id DESC";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PetModel petModel = new PetModel();
                            petModel.Id = (int)reader[0];
                            petModel.Name = (string)reader[1];
                            petModel.Type = (string)reader[2];
                            petModel.Colour = (string)reader[3];
                            petList.Add(petModel);
                        }
                    }
                }
            }
            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            List<PetModel> petList = new List<PetModel>();
            int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string petName = value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM Pet 
                                            WHERE Pet_Id = @id OR Pet_Name LIKE @name + '%' 
                                            ORDER BY Pet_Id DESC";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = petName;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PetModel petModel = new PetModel();
                            petModel.Id = (int)reader[0];
                            petModel.Name = (string)reader[1];
                            petModel.Type = (string)reader[2];
                            petModel.Colour = (string)reader[3];
                            petList.Add(petModel);
                        }
                    }
                }
            }
            return petList;
        }
    }
}
