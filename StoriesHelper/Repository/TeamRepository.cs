using MySql.Data.MySqlClient;
using System.Collections.Generic;
using StoriesHelper.Services;

namespace StoriesHelper.Repository
{
    class TeamRepository : Repository
    {
        public List<TeamNameType> GetTeamsByOrganization(int fkOrganization, bool open = true, bool archived = false, int page = 0, string name = null, bool pagination = true)
        {
            int offset = 25 * page;
            int limit = 25;

            List<TeamNameType> TeamList = new List<TeamNameType>();
            if (open || archived)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@idOrganization", fkOrganization);
                string sql = "SELECT t.rowid, t.name, t.active ";
                sql += "FROM storieshelper_team t ";
                sql += "INNER JOIN storieshelper_project p ON p.rowid = t.fk_project ";
                sql += "WHERE p.fk_organization = @idOrganization ";
                if (name != null)
                {
                    command.Parameters.AddWithValue("@name", "%" + name + "%");
                    sql += "AND t.name LIKE @name ";
                }
                if (open && !archived)
                {
                    sql += "AND t.active = 1 ";
                }
                else if (archived && !open)
                {
                    sql += "AND t.active = 0 ";
                }
                sql += "ORDER BY t.name ASC ";
                if(pagination)
                {
                    command.Parameters.AddWithValue("@offset", offset);
                    command.Parameters.AddWithValue("@limit", limit);
                    sql += "LIMIT @limit ";
                    sql += "OFFSET @offset ";
                }
                command.CommandText = sql;
                MySqlDataReader Team = command.ExecuteReader();
                while (Team.Read())
                {
                    TeamNameType TeamNameType = new TeamNameType();
                    TeamNameType.initializeTeamNameType(Team.GetInt32(0), Team.GetString(1), Team.GetBoolean(2));
                    TeamList.Add(TeamNameType);
                }
            }

            conn.Close();

            return TeamList;
        }

        public List<TeamNameType> GetTeamsByProjects(int fkProject, bool open = true, bool archived = false, int page = 0, string name = null, bool pagination = true)
        {
            int offset = 25 * page;
            int limit = 25;

            List<TeamNameType> TeamList = new List<TeamNameType>();
            if (open || archived)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@idProject", fkProject);
                string sql = "SELECT t.rowid, t.name, t.active ";
                sql += "FROM storieshelper_team t ";
                sql += "INNER JOIN storieshelper_project p ON t.fk_project = p.rowid ";
                sql += "WHERE p.rowid = @idProject ";
                sql += "GROUP BY t.rowid ";

                if (name != null)
                {
                    command.Parameters.AddWithValue("@name", "%" + name + "%");
                    sql += "AND t.name LIKE @name ";
                }
                if (open && !archived)
                {
                    sql += "AND t.active = 1 ";
                }
                else if (archived && !open)
                {
                    sql += "AND t.active = 0 ";
                }
                sql += "ORDER BY t.name ASC ";
                if (pagination)
                {
                    command.Parameters.AddWithValue("@offset", offset);
                    command.Parameters.AddWithValue("@limit", limit);
                    sql += "LIMIT @limit ";
                    sql += "OFFSET @offset ";
                }
                command.CommandText = sql;
                MySqlDataReader Team = command.ExecuteReader();
                while (Team.Read())
                {
                    TeamNameType TeamNameType = new TeamNameType();
                    TeamNameType.initializeTeamNameType(Team.GetInt32(0), Team.GetString(1), Team.GetBoolean(2));
                    TeamList.Add(TeamNameType);
                }
            }

            conn.Close();

            return TeamList;
        }

        public int GetCountUser(int fkTeam, bool open = true, bool archived = false, int page = 0, string name = null, bool pagination = true)
        {
            int offset = 25 * page;
            int limit = 25;
            int users = 0;

            List<TeamNameType> TeamList = new List<TeamNameType>();
            if (open || archived)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@idTeam", fkTeam);
                string sql = "SELECT count(*) users ";
                sql += "FROM storieshelper_team t ";
                sql += "INNER JOIN storieshelper_belong_to bt  ON bt.fk_team = t.rowid ";
                sql += "WHERE t.rowid = @idTeam ";

                if (name != null)
                {
                    command.Parameters.AddWithValue("@name", "%" + name + "%");
                    sql += "AND t.name LIKE @name ";
                }
                if (open && !archived)
                {
                    sql += "AND t.active = 1 ";
                }
                else if (archived && !open)
                {
                    sql += "AND t.active = 0 ";
                }
                sql += "ORDER BY t.name ASC ";
                if (pagination)
                {
                    command.Parameters.AddWithValue("@offset", offset);
                    command.Parameters.AddWithValue("@limit", limit);
                    sql += "LIMIT @limit ";
                    sql += "OFFSET @offset ";
                }
                command.CommandText = sql;
                MySqlDataReader count = command.ExecuteReader();
                while (count.Read())
                {
                    users = count.GetInt32(0);
                }
            }

            conn.Close();

            return users;
        }


        public int GetCountTask(int fkTeam, bool open = true, bool archived = false, int page = 0, string name = null, bool pagination = true)
        {
            int offset = 25 * page;
            int limit = 25;
            int tasks = 0;

            List<TeamNameType> TeamList = new List<TeamNameType>();
            if (open || archived)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@idTeam", fkTeam);
                string sql = "SELECT count(*) tasks ";
                sql += "FROM storieshelper_team t ";
                sql += "INNER JOIN storieshelper_map_column mc ON mc.fk_team = t.rowid  ";
                sql += "INNER JOIN storieshelper_task tk ON tk.fk_column = mc.rowid  ";
                sql += "WHERE t.rowid = @idTeam ";
                sql += "AND tk.active <> 0 ";

                if (name != null)
                {
                    command.Parameters.AddWithValue("@name", "%" + name + "%");
                    sql += "AND t.name LIKE @name ";
                }
                if (open && !archived)
                {
                    sql += "AND t.active = 1 ";
                }
                else if (archived && !open)
                {
                    sql += "AND t.active = 0 ";
                }
                sql += "ORDER BY t.name ASC ";
                if (pagination)
                {
                    command.Parameters.AddWithValue("@offset", offset);
                    command.Parameters.AddWithValue("@limit", limit);
                    sql += "LIMIT @limit ";
                    sql += "OFFSET @offset ";
                }
                command.CommandText = sql;
                MySqlDataReader count = command.ExecuteReader();
                while (count.Read())
                {
                    tasks = count.GetInt32(0);
                }
            }

            conn.Close();

            return tasks;
        }
    }
}
