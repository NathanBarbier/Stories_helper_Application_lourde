using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class TaskMembers : Model
    {
        private int fk_user;
        private int fk_task;
        public TaskMembers(int fk_user = 0, int fk_task = 0)
        {
            if(fk_user != 0 && fk_task != 0)
            {
                fetch(fk_user, fk_task);
            }
        }

        // SETTER
        public void setUser(int user)
        {
            fk_user = user;
        }

        public void setTask(int task)
        {
            fk_task = task;
        }

        // GETTER
        public int getUser()
        {
            return fk_user;
        }

        public int getTask()
        {
            return fk_task;
        }

        // FETCH
        public void fetch(int fk_user, int fk_task)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@fk_user", fk_user);
            command.Parameters.AddWithValue("@fk_task", fk_task);

            string sql = "SELECT t.fk_user, t.fk_task";
            sql += " FROM storieshelper_task_member";
            sql += " WHERE t.fk_user = @fk_user AND t.fk_task = @fk_task";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                this.fk_user = reader.GetInt32(1);
                this.fk_task = reader.GetInt32(2);
            }
            conn.Close();
        }
    }
}
