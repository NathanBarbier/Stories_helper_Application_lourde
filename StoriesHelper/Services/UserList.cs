using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Services
{
    class UserList
    {
        public int rowid;
        public string email;
        public bool admin;
        public string firstname;
        public string lastname;
        public DateTime birth;
        public string[] TeamsName;
        public string[] ProjectsName;

        public UserList(int rowid, string email, bool admin, string firstname, string lastname, DateTime birth, string teams, string projects)
        {
            this.rowid = rowid;
            this.email = email;
            this.admin = admin;
            this.firstname = firstname;
            this.lastname = lastname;
            this.birth = birth;
            string[] separator = { "####"};
            this.TeamsName = teams.Split(separator, 9999, StringSplitOptions.None);
            this.ProjectsName = projects.Split(separator, 9999, StringSplitOptions.None);

        }
    }
}
