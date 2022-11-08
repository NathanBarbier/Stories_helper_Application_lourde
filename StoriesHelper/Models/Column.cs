using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace StoriesHelper.Models
{
    class Column : Model
    {
        protected int rowid;
        protected string name;
        protected int fk_team;
        protected List<Task> list_tasks = new List<Task>();
        protected int rank;

        public Column(int idMap = -1)
        {
            if (idMap != -1)
            {
                fetch(idMap);
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
        public List<Task> getListTasks()
        {
            return list_tasks;
        }
        public List<Task> getListTasksOpen()
        {
            List<Task> list_task_open = new List<Task>();
            foreach (Task task in list_tasks)
            {
                if (task.isActive() == 1)
                {
                    list_task_open.Add(task);
                }
            }
            return list_task_open;
        }
        public List<Task> getListTasksClosed()
        {
            List<Task> list_task_closed = new List<Task>();
            foreach (Task task in list_tasks)
            {
                if (task.isActive() == -1)
                {
                    list_task_closed.Add(task);
                }
            }
            return list_task_closed;
        }
        public void setListTasks(List<Task> newTask)
        {
            list_tasks = newTask;
        }
        public int getFkTeam()
        {
            return fk_team;
        }
        public void setFkTeam(int newTeam)
        {
            fk_team = newTeam;
        }
        public int getRank()
        {
            return rank;
        }
        public void setRank(int newRank)
        {
            rank = newRank;
        }
        public void fetch(int idMap)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", idMap);
            string sql = "SELECT *";
            sql += " FROM storieshelper_map_column";
            sql += " WHERE rowid = @id";
            command.CommandText = sql;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                rowid = reader.GetInt32(0);
                name = reader.GetString(1);
                fk_team = reader.GetInt32(2);
                rank = reader.GetInt32(3);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idColumn", idMap);
            string sql2 = "SELECT *";
            sql2 += " FROM storieshelper_task";
            sql2 += " WHERE fk_column = @idColumn";
            command2.CommandText = sql2;
            MySqlDataReader tasks = command2.ExecuteReader();
            while (tasks.Read())
            {
                Task task = new Task();
                task.initializedTask(tasks.GetInt32(0), tasks.GetString(1), tasks.GetString(2), tasks.GetInt32(3), tasks.GetInt32(4), tasks.GetInt32(5), tasks.GetInt32(7));
                list_tasks.Add(task);
            }
            conn.Close();
        }

        public void initializedColumn(int rowid, string name, int fk_team, int rank)
        {
            this.rowid = rowid;
            this.name = name;
            this.fk_team = fk_team;
            this.rank = rank;

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idColumn", rowid);
            string sql = "SELECT *";
            sql += " FROM storieshelper_task";
            sql += " WHERE fk_column = @idColumn";
            command.CommandText = sql;
            MySqlDataReader tasks = command.ExecuteReader();
            while (tasks.Read())
            {
                Task task = new Task();
                string taskName = "";
                if (!tasks.IsDBNull(1))
                {
                    taskName = tasks.GetString(1);
                }
                string taskDescription = "";
                if (!tasks.IsDBNull(2))
                {
                    taskDescription = tasks.GetString(2);
                }
                task.initializedTask(tasks.GetInt32(0), taskName, taskDescription, tasks.GetInt32(3), tasks.GetInt32(4), tasks.GetInt32(5), tasks.GetInt32(6));
                list_tasks.Add(task);
            }
            conn.Close();
        }

        public List<Task> fetchTaskBetweenTime(int idColumn, string dateBegin, string dateEnd)
        {
            List<Task> ListTask = new List<Task>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idColumn", idColumn);
            command.Parameters.AddWithValue("@dateBegin", dateBegin);
            command.Parameters.AddWithValue("@dateEnd", dateEnd);
            string sql = "SELECT *";
            sql += " FROM storieshelper_task";
            sql += " WHERE fk_column = @idColumn";
            sql += " And active <> 0";
            command.CommandText = sql;
            MySqlDataReader tasks = command.ExecuteReader();
            while (tasks.Read())
            {
                Task task = new Task();
                string taskName = "";
                if (!tasks.IsDBNull(1))
                {
                    taskName = tasks.GetString(1);
                }
                string taskDescription = "";
                if (!tasks.IsDBNull(2))
                {
                    taskDescription = tasks.GetString(2);
                }
                task.initializedTask(tasks.GetInt32(0), taskName, taskDescription, tasks.GetInt32(3), tasks.GetInt32(4), tasks.GetInt32(5), tasks.GetInt32(6));
                ListTask.Add(task);
            }
            conn.Close();
            return ListTask;
        }
    }
}
