using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class Task : Model
    {
        private int rowid;
        private string name;
        private string description;
        private int fk_column;
        private int rank;
        private int fk_author;
        private int active;
        private List<TaskComment> TaskComments = new List<TaskComment>();

        public Task(int taskId = 0)
        {
            if (taskId != 0)
            {
                this.fetch(taskId);
            }
        }

        // SETTER
        public void setrowid(int rowid)
        {
            this.rowid = rowid;
        }

        public void setname(string name)
        {
            this.name = name;
        }

        public void setdescription(string description)
        {
            this.description = description;
        }

        public void setColumn(int column)
        {
            this.fk_column = column;
        }

        public void setAuthor(int author)
        {
            this.fk_author = author;
        }

        public void setActive(int active)
        {
            this.active = active;
        }


        // GETTER
        public int getRowid()
        {
            return this.rowid;
        }

        public string getName()
        {
            return this.name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public int getColumn()
        {
            return this.fk_column;
        }

        public int getAuthor()
        {
            return this.fk_author;
        }

        public int isActive()
        {
            return this.active;
        }
        // FETCH
        public void fetch(int taskId)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@rowid", taskId);

            string sql = "SELECT *";
            sql += " FROM storieshelper_task";
            sql += " WHERE rowid = @rowid";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string taskName = "";
                if (!reader.IsDBNull(1))
                {
                    taskName = reader.GetString(1);
                }
                string taskDescription = "";
                if (!reader.IsDBNull(2))
                {
                    taskDescription = reader.GetString(2);
                }
                rowid = reader.GetInt32(0); 
                name = taskName;
                description = taskDescription;
                fk_column = reader.GetInt32(3);
                rank = reader.GetInt32(4);
                fk_author = reader.GetInt32(5);
                active = reader.GetInt32(6);
            }
            conn.Close();

            conn.Open();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@fk_task", taskId);

            sql = "SELECT t.rowid, t.fk_task, t.note, t.fk_user";
            sql += " FROM storieshelper_task_comment AS t";
            sql += " WHERE fk_task = @fk_task";

            command.CommandText = sql;

            MySqlDataReader commentReader = command.ExecuteReader();

            while(commentReader.Read())
            {
                TaskComment taskComment = new TaskComment();

                taskComment.initializeTaskComment(commentReader.GetInt32(0), commentReader.GetInt32(1), commentReader.GetString(2), commentReader.GetInt32(3));
                this.TaskComments.Add(taskComment);
            }

            conn.Close();
        }

        public void initializedTask(int rowid, string name, string description, int fk_column, int rank, int fk_user, int active)
        {
            this.rowid = rowid;
            this.name = name;
            this.description = description;
            this.fk_column = fk_column;
            this.rank = rank;
            this.fk_author = fk_user;
            this.active = active;

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@fk_task", rowid);
           
            string sql = "SELECT *";
            sql += " FROM storieshelper_task_comment";
            sql += " WHERE fk_task = @fk_task";

            command.CommandText = sql;

            MySqlDataReader commentReader = command.ExecuteReader();

            while (commentReader.Read())
            {
                TaskComment taskComment = new TaskComment();

                taskComment.initializeTaskComment(commentReader.GetInt32(0), commentReader.GetInt32(1), commentReader.GetString(2), commentReader.GetInt32(3));
                this.TaskComments.Add(taskComment);
            }

            conn.Close();
        }
        public int fetch_last_insert_id()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            string sql = "SELECT MAX(rowid) AS rowid";
            sql += " FROM storieshelper_task";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            int lastInsertId = 0;

            while (reader.Read())
            {
                lastInsertId = reader.GetInt32(0);
            }

            conn.Close();

            return lastInsertId;
        }
    }
}
