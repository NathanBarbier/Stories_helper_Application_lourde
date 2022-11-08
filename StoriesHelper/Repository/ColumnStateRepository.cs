using MySql.Data.MySqlClient;
using StoriesHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoriesHelper.Repository
{
    class ColumnStateRepository : Repository
    {
        protected List<ColumnState> ListTaskState = new List<ColumnState>();
        public List<ColumnState> fetchBackupColumn(int idTeam, string date, string scope)
        {
            List<ColumnState> ListTaskState = new List<ColumnState>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idTeam", idTeam);
            command.Parameters.AddWithValue("@date", date);
            switch (scope)
            {
                case "jour":
                    command.Parameters.AddWithValue("@scope", "Day");
                    break;
                case "semaine":
                    command.Parameters.AddWithValue("@scope", "Week");
                    break;
                case "mois":
                    command.Parameters.AddWithValue("@scope", "Month");
                    break;
                case "annee":
                    command.Parameters.AddWithValue("@scope", "Year");
                    break;
            }
            string sql = "SELECT *";
            sql += " FROM storieshelper_column_state";
            sql += " WHERE fk_team = @idTeam";
            sql += " AND state_date LIKE @date";
            sql += " AND state_scope = @scope";
            sql += " ORDER BY column_rank";
            command.CommandText = sql;
            MySqlDataReader taskStates = command.ExecuteReader();
            while (taskStates.Read())
            {
                ColumnState TaskState = new ColumnState();
                TaskState.initializedColumnState(taskStates.GetInt32(0), taskStates.GetInt32(1), taskStates.GetInt32(2), taskStates.GetString(3), taskStates.GetInt32(4), taskStates.GetDateTime(5), taskStates.GetString(6));
                ListTaskState.Add(TaskState);
            }
            conn.Close();
            return ListTaskState;
        }

        public List<string> fetchDistinctColumnBetweenDate(int idTeam, string dateDebut, string dateFin, string scope)
        {
            List<string> ListColumnName = new List<string>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idTeam", idTeam);
            command.Parameters.AddWithValue("@dateDebut", dateDebut);
            command.Parameters.AddWithValue("@dateFin", dateFin);
            switch (scope)
            {
                case "jour":
                    command.Parameters.AddWithValue("@scope", "Day");
                    break;
                case "semaine":
                    command.Parameters.AddWithValue("@scope", "Week");
                    break;
                case "mois":
                    command.Parameters.AddWithValue("@scope", "Month");
                    break;
                case "annee":
                    command.Parameters.AddWithValue("@scope", "Year");
                    break;
            }
            string sql = "SELECT DISTINCT(column_name)";
            sql += " FROM storieshelper_column_state";
            sql += " WHERE fk_team = @idTeam";
            sql += " AND state_date BETWEEN @dateDebut AND @dateFin";
            sql += " AND state_scope = @scope";
            sql += " ORDER BY column_rank";
            command.CommandText = sql;
            MySqlDataReader columnNames = command.ExecuteReader();
            while (columnNames.Read())
            {
                string columnName = columnNames.GetString(0);
                ListColumnName.Add(columnName);
            }
            conn.Close();
            return ListColumnName;
        }
    }
}
