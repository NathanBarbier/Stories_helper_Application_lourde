using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class TaskComment : Model
    {
        private int rowid;
        private int fk_task;
        private string note;
        private int fk_user;

        public TaskComment(int rowid = 0)
        {
            if (rowid != 0)
            {
                try
                {
                    conn.Open();

                    MySqlCommand command = conn.CreateCommand();

                    command.Parameters.AddWithValue("@rowid", rowid);

                    string sql = "SELECT *";
                    sql += " FROM storieshelper_task_comment";
                    sql += " WHERE rowid = @rowid";

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string comment = "";
                        if (!reader.IsDBNull(1))
                        {
                            comment = reader.GetString(1);
                        }
                        this.rowid = rowid;
                        this.fk_task = reader.GetInt32(0);
                        this.note = comment;
                        this.fk_user = reader.GetInt32(2);
                    }

                    conn.Close();
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }

        public void initializeTaskComment(int rowid, int fk_task, string note, int fk_user)
        {
            this.rowid = rowid;
            this.fk_task = fk_task;
            this.note = note;
            this.fk_user = fk_user;
        }

        // SETTER

        public void setRowid(int rowid)
        {
            this.rowid = rowid;
        }

        public void setFk_task(int task)
        {
            this.fk_task = task;
        }

        public void setNote(string note)
        {
            this.note = note;
        }

        public void setFk_user(int user)
        {
            this.fk_user = user;
        }

        // GETTER

        public int getRowid()
        {
            return this.rowid;
        }

        public int getTask()
        {
            return this.fk_task;
        }

        public string getNote()
        {
            return this.note;
        }

        public int getUser()
        {
            return this.fk_user;
        }

        // FETCH
        public void fetch(int rowid = 0)
        {
            rowid = rowid == 0 ? this.rowid : rowid;

            try
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();

                string sql = "SELECT t.rowid, t.fk_task, t.note, t.fk_user";
                sql += " FROM storieshelper_task_comment AS t";
                sql += " WHERE rowid = @rowid";

                MySqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    this.rowid = reader.GetInt32(0);
                    this.fk_task = reader.GetInt32(1);
                    this.note = reader.GetString(2);
                    this.fk_user = reader.GetInt32(3);
                }

                conn.Close();
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}
