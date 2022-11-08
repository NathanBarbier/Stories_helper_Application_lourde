using MySql.Data.MySqlClient;
using System;

namespace StoriesHelper.Models
{
    class ColumnState : Model
    {
        protected int rowid;
        protected int fk_team;
        protected int nb_task;
        protected string column_name;
        protected int column_rank;
        protected DateTime state_date;
        protected string state_scope;
        public ColumnState(int rowid = 0)
        {
            if (rowid != 0)
            {
                this.fetch(rowid);
            }
        }
        public int getRowid()
        {
            return this.rowid;
        }

        public int getFkTeam()
        {
            return this.fk_team;
        }

        public void setFkTeam(int fk_team)
        {
            this.fk_team = fk_team;
        }

        public int getNbTask()
        {
            return this.nb_task;
        }

        public void setNbTask(int nb_task)
        {
            this.nb_task = nb_task;
        }

        public string getColumnName()
        {
            return this.column_name;
        }

        public void setColumnName(string column_name)
        {
            this.column_name = column_name;
        }

        public int getColumnRank()
        {
            return this.column_rank;
        }

        public void setColumnRank(int column_rank)
        {
            this.column_rank = column_rank;
        }

        public DateTime getStateDate()
        {
            return this.state_date;
        }

        public void setStateDate(DateTime state_date)
        {
            this.state_date = state_date;
        }

        public string getStateScope()
        {
            return this.state_scope;
        }

        public void setStateScope(string state_scope)
        {
            this.state_scope = state_scope;
        }

        public void fetch(int rowid)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@rowid", rowid);

            string sql = "SELECT *";
            sql += " FROM storieshelper_task_state";
            sql += " WHERE rowid = @rowid";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                rowid = reader.GetInt32(0);
                fk_team = reader.GetInt32(1);
                nb_task = reader.GetInt32(2);
                column_name = reader.GetString(3);
                column_rank = reader.GetInt32(4);
                state_date = reader.GetDateTime(5);
                state_scope = reader.GetString(6);
            }
            conn.Close();
        }

        public void initializedColumnState(int rowid, int fk_team, int nb_task, string column_name, int column_rank, DateTime state_date, string state_scope)
        {
            this.rowid = rowid;
            this.fk_team = fk_team;
            this.nb_task = nb_task;
            this.column_name = column_name;
            this.column_rank = column_rank;
            this.state_date = state_date;
            this.state_scope = state_scope;
        }
    }
}
