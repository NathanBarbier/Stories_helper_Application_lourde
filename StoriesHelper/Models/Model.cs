using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class Model
    {
        protected MySqlConnection conn;

        protected Model()
        {
            conn = new MySqlConnection("database=storieshelper;server=localhost;user id = root;pwd=");
        }
    }
}
