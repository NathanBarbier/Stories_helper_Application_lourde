using MySql.Data.MySqlClient;
using StoriesHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Repository
{
    class LogHistoryRepository : Repository
    {
        public List<LogHistory> GetLogsByOrganization(int fkOrganization, string dateDebutValue = null, string dateFinValue = null, string statusValue = null, string actionValue = null, string objetValue = null, string pageValue = null, int page = 0)
        {
            int offset = 200 * page;
            int limit = 200;

            List<LogHistory> LogHistoryList = new List<LogHistory>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idOrganization", fkOrganization);
            string sql = "SELECT * ";
            sql += "FROM storieshelper_log_history ";
            sql += "WHERE fk_organization = @idOrganization ";

            if (dateDebutValue != null)
            {
                DateTime DateDebut = DateTime.Parse(dateDebutValue);
                command.Parameters.AddWithValue("@dateDebut", DateDebut);
                sql += " AND date_creation >= @dateDebut ";
            }
            if (dateFinValue != null)
            {
                DateTime DateFin = DateTime.Parse(dateFinValue);
                command.Parameters.AddWithValue("@dateFin", DateFin);
                sql += " AND date_creation <= @dateFin ";
            }
            if (statusValue != null && statusValue != "")
            {
                command.Parameters.AddWithValue("@status", statusValue);
                sql += " AND status = @status ";
            }
            if (actionValue != null && actionValue != "")
            {
                command.Parameters.AddWithValue("@action", actionValue);
                sql += " AND action = @action ";
            }
            if (objetValue != null && objetValue != "")
            {
                command.Parameters.AddWithValue("@object", objetValue);
                sql += " AND object = @object ";
            }
            if (pageValue != null && pageValue != "")
            {
                command.Parameters.AddWithValue("@page", "%" + pageValue + "%");
                sql += " AND page LIKE @page ";
            }

            command.Parameters.AddWithValue("@offset", offset);
            command.Parameters.AddWithValue("@limit", limit);
            sql += "ORDER BY date_creation DESC ";
            sql += "LIMIT @limit ";
            sql += "OFFSET @offset ";
            command.CommandText = sql;
            MySqlDataReader logs = command.ExecuteReader();
            while (logs.Read())
            {
                string object_id = null;
                if (!logs.IsDBNull(5))
                {
                    object_id = logs.GetString(5);
                }
                string object_name = null;
                if (!logs.IsDBNull(6))
                {
                    object_name = logs.GetString(6);
                }
                string object_parent = null;
                if (!logs.IsDBNull(7))
                {
                    object_parent = logs.GetString(7);
                }
                string object_parent_id = null;
                if (!logs.IsDBNull(8))
                {
                    object_parent_id = logs.GetString(8);
                }
                string object_parent_name = null;
                if (!logs.IsDBNull(9))
                {
                    object_parent_name = logs.GetString(9);
                }
                string exception = null;
                if (!logs.IsDBNull(12))
                {
                    exception = logs.GetString(12);
                }
                string pageLog = null;
                if (!logs.IsDBNull(14))
                {
                    pageLog = logs.GetString(14);
                }
                LogHistory LogHistory = new LogHistory();
                LogHistory.initialize(logs.GetInt32(0), logs.GetInt32(1), logs.GetDateTime(2), logs.GetString(3), logs.GetString(4), logs.GetInt32(10), logs.GetString(11), logs.GetString(13), object_id, object_name, object_parent, object_parent_id, object_parent_name, exception, pageLog);
                LogHistoryList.Add(LogHistory);
            }
            
            conn.Close();
            return LogHistoryList;
        }

        public int getCountByStatut(int fkOrganization, string status = null)
        {
            int CountLogs = 0;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idOrganization", fkOrganization);
            string sql = "SELECT COUNT(*) ";
            sql += "FROM storieshelper_log_history ";
            sql += "WHERE fk_organization = @idOrganization ";
            if (status != null && status != "")
            {
                command.Parameters.AddWithValue("@status", status);
                sql += "AND status = @status ";
            }
            command.CommandText = sql;
            MySqlDataReader logs = command.ExecuteReader();
            while (logs.Read())
            {
                CountLogs = logs.GetInt32(0);
            }

            conn.Close();
            return CountLogs;
        }
    }
}
