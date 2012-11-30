using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Cadastro.Model;

namespace Cadastro.DAL.SqlProvider
{
    public class FisicaDao : IDAL<Fisica>
    {
        public List<Fisica> GetAll()
        {
            List<Fisica> fisicas = new List<Fisica>();
            Fisica fisica = null;

            using (SqlConnection connection = new SqlConnection(""))
            {
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fisica = new Fisica();
                            fisica.ID = Guid.Parse(reader[0].ToString());
                            fisica.Nome = reader[1].ToString();
                            fisica.Idade = int.Parse(reader[2].ToString());
                            fisica.Sexo = reader[3].ToString();
                            //fisica.Telefones = ???

                            fisicas.Add(fisica);
                        }
                        connection.Close();
                    }
                }
            }

            return fisicas;
        }

        public Fisica Get(Guid id)
        {
            Fisica fisica = null;

            using (SqlConnection connection = new SqlConnection(""))
            {
                using (SqlCommand command = new 
                    SqlCommand("SELECT * FROM FISICA WHERE ID = " + id.ToString(), connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fisica = new Fisica();
                            fisica.ID = Guid.Parse(reader[0].ToString());
                            fisica.Nome = reader[1].ToString();
                            fisica.Idade = int.Parse(reader[2].ToString());
                            fisica.Sexo = reader[3].ToString();
                            //fisica.Telefones = ???
                        }
                        connection.Close();
                    }
                }
            }

            return fisica;
        }

        public void Delete(Fisica entity)
        {
            using (SqlConnection connection = new SqlConnection(""))
            {
                using (SqlCommand command = new
                    SqlCommand("DELETE FROM FISICA WHERE ID = " + entity.ID.ToString(), connection))
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void Update(Fisica entity)
        {
            using (SqlConnection connection = new SqlConnection(""))
            {
                using (SqlCommand command = new
                    SqlCommand("UPDATE FISICA SET Nome =  WHERE ID = " + entity.ID.ToString(), connection))
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void SaveAll()
        {
            
        }
    }
}
