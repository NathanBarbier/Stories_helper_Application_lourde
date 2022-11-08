using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class Team : Model
    {
        protected int rowid;
        protected string name;
        protected int fk_project;
        protected List<User> list_collaborators = new List<User>();
        protected List<Column> list_columns = new List<Column>();
        protected List<ColumnState> list_column_states = new List<ColumnState>();
        protected bool active;

        public Team(int idTeam = -1)
        {
            if(idTeam != -1)
            {
                fetch(idTeam);
            }
        }
        public int getRowId()
        {
            return rowid;
        }
        public int setRowId()
        {
            return rowid;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string newName)
        {
            name = newName;
        }     
        public int getProject()
        {
            return fk_project;
        }
        public void setProject(int newProject)
        {
            fk_project = newProject;
        }        
        public List<User> getListCollaborators()
        {
            return list_collaborators;
        }
        public void setListCollaborators(List<User> newListCollaborators)
        {
            list_collaborators = newListCollaborators;
        }
        public List<Column> getListColumns()
        {
            return list_columns;
        }
        public void setListColumns(List<Column> newListColumns)
        {
            list_columns = newListColumns;
        }

        public List<ColumnState> getListColumnState()
        {
            return list_column_states;
        }
        public void setListColumnState(List<ColumnState> list_column_states)
        {
            this.list_column_states = list_column_states;
        }

        public bool isActive()
        {
            return active;
        }
        public void setActive(bool newActive)
        {
            this.active = newActive;
        }
        public void fetch(int idTeam)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", idTeam);
            string sql = "SELECT *";
            sql += " FROM storieshelper_team ";
            sql += "WHERE rowid = @id";
            command.CommandText = sql;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                rowid = reader.GetInt32(0);
                name = reader.GetString(1);
                fk_project = reader.GetInt32(2);
                active = reader.GetBoolean(3);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idTeam", idTeam);
            string sql2 = "SELECT *";
            sql2 += " FROM storieshelper_user AS u";
            sql2 += " LEFT JOIN storieshelper_belong_to AS b ON u.rowid = b.fk_user";
            sql2 += " WHERE b.fk_team = @idTeam";
            sql += " AND u.admin = 0";
            command2.CommandText = sql2;
            MySqlDataReader users = command2.ExecuteReader();
            while (users.Read())
            {

                User user = new User();
                user.initializedCollaborator(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(5), users.GetInt32(6));
                list_collaborators.Add(user);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command3 = conn.CreateCommand();
            command3.Parameters.AddWithValue("@idTeam", idTeam);
            string sql3 = "SELECT *";
            sql3 += " FROM storieshelper_map_column";
            sql3 += " WHERE fk_team = @idTeam";
            command3.CommandText = sql3;
            MySqlDataReader columns = command3.ExecuteReader();
            while (columns.Read())
            {
                Column column = new Column();
                column.initializedColumn(columns.GetInt32(0), columns.GetString(1), columns.GetInt32(2), columns.GetInt32(3));
                list_columns.Add(column);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command4 = conn.CreateCommand();
            command4.Parameters.AddWithValue("@idTeam", idTeam);
            string sql4 = "SELECT *";
            sql4 += " FROM storieshelper_column_state";
            sql4 += " WHERE fk_team = @idTeam";
            command4.CommandText = sql4;
            MySqlDataReader columnStates = command4.ExecuteReader();
            while (columnStates.Read())
            {
                ColumnState ColumnState = new ColumnState();
                ColumnState.initializedColumnState(columnStates.GetInt32(0), columnStates.GetInt32(1), columnStates.GetInt32(2), columnStates.GetString(3), columnStates.GetInt32(4), columnStates.GetDateTime(5), columnStates.GetString(6));
                list_column_states.Add(ColumnState);
            }
            conn.Close();
        }

        public void initializedTeam(int idTeam, string name, int fk_project, bool active)
        {
            this.rowid = idTeam;
            this.name = name;
            this.fk_project = fk_project;
            this.active = active;

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idTeam", idTeam);
            string sql = "SELECT *";
            sql += " FROM storieshelper_user AS u";
            sql += " LEFT JOIN storieshelper_belong_to AS b ON u.rowid = b.fk_user";
            sql += " WHERE b.fk_team = @idTeam";
            sql += " AND u.admin = 0";
            command.CommandText = sql;
            MySqlDataReader users = command.ExecuteReader();
            while(users.Read())
            {
                User user = new User();
                user.initializedCollaborator(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(5), users.GetInt32(6));
                list_collaborators.Add(user);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idTeam", idTeam);
            string sql2 = "SELECT *";
            sql2 += " FROM storieshelper_map_column";
            sql2 += " WHERE fk_team = @idTeam";
            command2.CommandText = sql2;
            MySqlDataReader columns = command2.ExecuteReader();
            while (columns.Read())
            {
                Column column = new Column();
                column.initializedColumn(columns.GetInt32(0), columns.GetString(1), columns.GetInt32(2), columns.GetInt32(3));
                list_columns.Add(column);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command3 = conn.CreateCommand();
            command3.Parameters.AddWithValue("@idTeam", idTeam);
            string sql3 = "SELECT *";
            sql3 += " FROM storieshelper_column_state";
            sql3 += " WHERE fk_team = @idTeam";
            command3.CommandText = sql3;
            MySqlDataReader columnStates = command3.ExecuteReader();
            while (columnStates.Read())
            {
                ColumnState ColumnState = new ColumnState();
                ColumnState.initializedColumnState(columnStates.GetInt32(0), columnStates.GetInt32(1), columnStates.GetInt32(2), columnStates.GetString(3), columnStates.GetInt32(4), columnStates.GetDateTime(5), columnStates.GetString(6));
                list_column_states.Add(ColumnState);
            }
            conn.Close();
        }

        public void delete()
        {  
            // supprime la team
            conn.Open();
            MySqlCommand deleteTeams = conn.CreateCommand();
            string sql = "DELETE tm FROM storieshelper_team tm ";
            sql += "WHERE tm.rowid = @rowid ";
            deleteTeams.Parameters.AddWithValue("@rowid", rowid);
            deleteTeams.CommandText = sql;
            deleteTeams.ExecuteNonQuery();
            conn.Close();
        }

        public void update()
        {
            conn.Open();
            MySqlCommand update = conn.CreateCommand();
            string sql = "UPDATE storieshelper_team ";
            sql += "SET ";
            sql += "name = @name, ";
            sql += "fk_project = @fk_project, ";
            sql += "active = @active ";
            sql += "WHERE rowid = @rowid";
            update.Parameters.AddWithValue("@name", name);
            update.Parameters.AddWithValue("@fk_project", fk_project);
            update.Parameters.AddWithValue("@active", active);
            update.Parameters.AddWithValue("@rowid", rowid);
            update.CommandText = sql;
            update.ExecuteNonQuery();
            conn.Close();
        }
    }
}
