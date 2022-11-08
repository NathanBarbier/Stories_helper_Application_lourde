using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class Organization : Model
    {
        protected int rowid;
        protected string name;
        protected List<Project> list_projects = new List<Project>();
        protected List<User> list_collaborators = new List<User>();
        protected List<LogHistory> list_logs = new List<LogHistory>();

        public Organization(int idOrganization = -1)
        {
            if(idOrganization != -1)
            {
                fetch(idOrganization);
            }
        }
        public int getRowId()
        {
            return rowid;
        }
        public void setRowid(int newRowid)
        {
            rowid = newRowid;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string newName)
        {
            name = newName;
        }
        public List<Project> getListProjects()
        {
            return list_projects;
        }
        public void setListProjects(List<Project> newListProject)
        {
            list_projects = newListProject;
        }
        public List<User> getListUsers()
        {
            return list_collaborators;
        }
        public void setListUsers(List<User> newListUser)
        {
            list_collaborators = newListUser;
        }
        public List<LogHistory> getLogs()
        {
            return list_logs;
        }
        public void setListLogs(List<LogHistory> newListLog)
        {
            list_logs = newListLog;
        }

        public void fetch(int idOrganization)
        {
            // récupère les informations de l'organisation
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", idOrganization);
            string sql = "SELECT *";
            sql += " FROM storieshelper_organization ";
            sql += "WHERE rowid = @id";
            command.CommandText = sql;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                rowid = reader.GetInt32(0);
                name = reader.GetString(1);
            }
            conn.Close();
            //initialise les projets de l'organisation
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idOrganization", idOrganization );
            string sql2 = "SELECT *";
            sql2 += " FROM storieshelper_project";
            sql2 += " WHERE fk_organization = @idOrganization";
            command2.CommandText = sql2;
            MySqlDataReader projects = command2.ExecuteReader();
            while (projects.Read())
            {
                Project project = new Project();
                project.initializedProject(projects.GetInt32(0), projects.GetString(1), projects.GetString(2), projects.GetDateTime(3), projects.GetInt32(4), projects.GetString(5), projects.GetBoolean(6));
                list_projects.Add(project);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command3 = conn.CreateCommand();
            command3.Parameters.AddWithValue("@idOrganization", idOrganization);
            string sql3 = "SELECT *";
            sql3 += " FROM storieshelper_user";
            sql3 += " WHERE fk_organization = @idOrganization";
            command3.CommandText = sql3;
            MySqlDataReader users = command3.ExecuteReader();
            while (users.Read())
            {
                User user = new User();
                user.initializedCollaborator(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(5), users.GetInt32(6));
                list_collaborators.Add(user);
            }
            conn.Close();
        }
    }
}
