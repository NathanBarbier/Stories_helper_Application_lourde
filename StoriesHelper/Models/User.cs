using MySql.Data.MySqlClient;
using System;

namespace StoriesHelper.Models
{
    class User : Model
    {
        protected int rowid;
        protected string email;
        protected string password;
        protected int fk_organization;
        protected bool admin;
        protected string firstname;
        protected string lastname;
        protected DateTime birth;
        public User(int idUser = -1)
        {
            if (idUser != -1)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", idUser);
                string sql = "SELECT *";
                sql += " FROM storieshelper_user";
                sql += " WHERE rowid = @id";
                command.CommandText = sql;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rowid = reader.GetInt32(0);
                    lastname = reader.GetString(1);
                    firstname = reader.GetString(2);
                    birth = reader.GetDateTime(3);
                    password = reader.GetString(4);
                    email = reader.GetString(5);
                    fk_organization = reader.GetInt32(6);
                    admin = reader.GetBoolean(10);
                }
                conn.Close();
            }
        }

        public int getRowId()
        {
            return rowid;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string newEmail)
        {
            email = newEmail;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string newPassword)
        {
            password = newPassword;
        }
        public int getOrganization()
        {
            return fk_organization;
        }
        public void setFkOrganization(int newOrganization)
        {
            fk_organization = newOrganization;
        }
        public string getFirstname()
        {
            return firstname;
        }
        public void setFirstname(string newFirstname)
        {
            firstname = newFirstname;
        }
        public string getLastname()
        {
            return lastname;
        }
        public void setLastname(string newLastname)
        {
            lastname = newLastname;
        }
        public DateTime getBirth()
        {
            return birth;
        }
        public void setBirth(DateTime newBirth)
        {
            birth = newBirth;
        }
        public bool isAdmin()
        {
            return admin;
        }
        public void setAdmin(bool admin)
        {
            this.admin = admin;
        }

        public void initializedCollaborator(int idUser, string lastname, string firstname, DateTime birth, string password, string email, int fk_organization)
        {
            this.rowid = idUser;
            this.lastname = lastname;
            this.firstname = firstname;
            this.birth = birth;
            this.password = password;
            this.email = email;
            this.fk_organization = fk_organization;
        }

        public void update()
        {
            conn.Open();
            MySqlCommand update = conn.CreateCommand();
            string sql = "UPDATE storieshelper_user ";
            sql += "SET ";
            sql += "lastname = @lastname, ";
            sql += "firstname = @firstname, ";
            sql += "birth = @birth, ";
            sql += "password = @password, ";
            sql += "email = @email, ";
            sql += "admin = @admin ";
            sql += "WHERE rowid = @rowid";
            update.Parameters.AddWithValue("@lastname", lastname);
            update.Parameters.AddWithValue("@firstname", firstname);
            update.Parameters.AddWithValue("@birth", birth);
            update.Parameters.AddWithValue("@password", password);
            update.Parameters.AddWithValue("@email", email);
            update.Parameters.AddWithValue("@admin", admin);
            update.Parameters.AddWithValue("@rowid", rowid);
            update.CommandText = sql;
            update.ExecuteNonQuery();
            conn.Close();
        }
         public void delete()
        {
            conn.Open();
            MySqlCommand delete = conn.CreateCommand();
            string sql = "DELETE FROM storieshelper_user ";
            sql += "WHERE rowid = @rowid ";
            delete.Parameters.AddWithValue("@rowid", rowid);
            delete.CommandText = sql;
            delete.ExecuteNonQuery();
            conn.Close();
        }
    }
}
