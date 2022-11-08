using System;
using System.Collections.Generic;
using StoriesHelper.Models;
using MySql.Data.MySqlClient;
using StoriesHelper.Services;

namespace StoriesHelper.Repository
{
    class UserRepository : Repository
    {
        List<User> list_collaborators = new List<User>();
        List<UserList> list_users = new List<UserList>();
        
        public List<UserList> getUserFromOrganization(int fkOrganization ,string lastname = null, string firstname = null, string email = null, string team = null, string project = null, string id = null, int page = 0, bool pagination = true)
        {
            int offset = 25 * page;
            int limit = 25;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idOrganization", fkOrganization);
            string sql = "select u.rowid, u.email, u.admin, u.firstname, u.lastname, u.birth, GROUP_CONCAT(t.name SEPARATOR '####') as teams, GROUP_CONCAT(p.name SEPARATOR '####') as projects ";
            sql += " FROM storieshelper_organization o ";
            sql += " INNER JOIN storieshelper_project p on p.fk_organization = o.rowid";
            sql += " INNER JOIN storieshelper_team t on t.fk_project = p.rowid";
            sql += " INNER JOIN storieshelper_belong_to bt on bt.fk_team = t.rowid";
            sql += " INNER JOIN storieshelper_user u on bt.fk_user = u.rowid";
            sql += " WHERE o.rowid = @idOrganization";
            if (lastname != null && lastname != "")
            {
                command.Parameters.AddWithValue("@name", "%" + lastname + "%");
                sql += " AND u.lastname LIKE @name";
            }
            if(firstname != null && firstname != "")
            {
                command.Parameters.AddWithValue("@firstname", "%" + firstname + "%");
                sql += " AND u.firstname LIKE @firstname";
            }
            if(email != null && email != "")
            {
                command.Parameters.AddWithValue("@email", "%" + email + "%");
                sql += " AND u.email LIKE @email";
            }
            if(team != null && team != "")
            {
                command.Parameters.AddWithValue("@team", "%" + team + "%");
                sql += " AND t.name LIKE @team";
            }
            if(project != null && project != "")
            {
                command.Parameters.AddWithValue("@project", "%" + project + "%");
                sql += " AND p.name LIKE @project";
            }
            if(id != null && id != "")
            {
                command.Parameters.AddWithValue("@id", "%" + id + "%");
                sql += " AND u.rowid LIKE @id";
            }

            sql += " GROUP BY u.rowid";
            if (pagination)
            {
                command.Parameters.AddWithValue("@offset", offset);
                command.Parameters.AddWithValue("@limit", limit);
                sql += " LIMIT @limit";
                sql += " OFFSET @offset";
            }

            command.CommandText = sql;
            MySqlDataReader users = command.ExecuteReader();
            while (users.Read())
            {
                UserList user = new UserList(users.GetInt32(0), users.GetString(1), users.GetBoolean(2), users.GetString(3), users.GetString(4), users.GetDateTime(5), users.GetString(6), users.GetString(7));
                list_users.Add(user);
            }
            conn.Close();
            return list_users;
        }

        public List<User> getUserFromTeam(int fkTeam, string lastname = null, string firstname = null, string email = null, int page = 0, bool pagination = true)
        {
            int offset = 10 * page;
            int limit = 10;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idTeam", fkTeam);
            string sql = "select u.* ";
            sql += " FROM storieshelper_team t ";
            sql += " INNER JOIN storieshelper_belong_to bt ON bt.fk_team = t.rowid ";
            sql += " INNER JOIN storieshelper_user u ON bt.fk_user = u.rowid ";
            sql += " WHERE t.rowid = @idTeam";
            if (lastname != null)
            {
                command.Parameters.AddWithValue("@name", "%" + lastname + "%");
                sql += " AND u.lastname LIKE @name";
            }
            if (firstname != null)
            {
                command.Parameters.AddWithValue("@firstname", "%" + firstname + "%");
                sql += " AND u.firstname LIKE @firstname";
            }
            if (email != null)
            {
                command.Parameters.AddWithValue("@email", "%" + email + "%");
                sql += " AND u.email LIKE @email";
            }
            if (pagination)
            {
                command.Parameters.AddWithValue("@offset", offset);
                command.Parameters.AddWithValue("@limit", limit);
                sql += " LIMIT @limit";
                sql += " OFFSET @offset";
            }
            command.CommandText = sql;
            MySqlDataReader users = command.ExecuteReader();
            while (users.Read())
            {
                User user = new User();
                user.initializedCollaborator(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(5), users.GetInt32(6));
                list_collaborators.Add(user);
            }
            conn.Close();
            return list_collaborators;
        }
    }
}
