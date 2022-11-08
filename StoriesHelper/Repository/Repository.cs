using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Repository
{
    class Repository
    {
        protected MySqlConnection conn;

        protected Repository()
        {
            conn = new MySqlConnection("database=storieshelper;server=localhost;user id = root;pwd=");
        }
    }
}
