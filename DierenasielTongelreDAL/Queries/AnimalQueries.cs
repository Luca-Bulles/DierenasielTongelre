using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using DierenasielTongelreDAL.DTO;
using DierenasielTongelreInterfaces.Models;
using DierenasielTongelreInterfaces.Queries;

namespace DierenasielTongelreDAL.Queries
{
    public class AnimalQueries: IAnimalQueries
    {
        //private readonly DatabaseConnection _connection;
        public string ConnectionString { get; set; }

        public AnimalQueries()
        {
            this.ConnectionString = "Server=studmysql01.fhict.local;Uid=dbi437981;Database=dbi437981;Pwd=Dierenasiel;";
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public void EditAnimals(IAnimal animal)
        {
            string query = "UPDATE animal SET Name = @Name, Race = @Race, Color = @Color, DateOfBirth = @DateOfBirth, Available = @Available, DateOfRegistration = @DateOfRegistration, ImageSrc = @ImageSrc WHERE id = @id;";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", animal.Id);
                cmd.Parameters.AddWithValue("@Name", animal.Name);
                cmd.Parameters.AddWithValue("@Race", animal.Race);
                cmd.Parameters.AddWithValue("@Color", animal.Color);
                cmd.Parameters.AddWithValue("@DateOfBirth", animal.DateOfBirth);
                cmd.Parameters.AddWithValue("@Available", animal.Available);
                cmd.Parameters.AddWithValue("@DateOfRegistration", animal.DateOfRegistration);
                cmd.Parameters.AddWithValue("@ImageSrc", animal.ImageSrc);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteAnimal(int id)
        {
            string query = "DELETE FROM animal WHERE id = @id;";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public IAnimal GetById(IAnimal animal)
        {
            string query = "SELECT * FROM animal WHERE id = @id; ";
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", animal.Id);
                cmd.Parameters.AddWithValue("@Name", animal.Name);
                cmd.Parameters.AddWithValue("@Race", animal.Race);
                cmd.Parameters.AddWithValue("@Color", animal.Color);
                cmd.Parameters.AddWithValue("@DateOfBirth", animal.DateOfBirth);
                cmd.Parameters.AddWithValue("@Available", animal.Available);
                cmd.Parameters.AddWithValue("@DateOfRegistration", animal.DateOfRegistration);
                cmd.Parameters.AddWithValue("@ImageSrc", animal.ImageSrc);
            }
            return animal;
        }

        public IEnumerable<IAnimal> GetAllAnimals()
        {
            string query = "Select * FROM animal;";
            List<IAnimal> animals = new List<IAnimal>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    animals.Add(new AnimalDTO()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Race = reader.GetString(2),
                        Color = reader.GetString(3),
                        DateOfBirth = reader.GetDateTime(4),
                        Available = reader.GetBoolean(5),
                        DateOfRegistration = reader.GetDateTime(6),
                        ImageSrc = reader.GetString(7)

                    }) ;
                }
            }

            return animals;
        }
    }
    
}
