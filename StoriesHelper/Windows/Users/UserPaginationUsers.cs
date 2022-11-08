using StoriesHelper.Repository;
using StoriesHelper.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Users
{
    public partial class UserPaginationUsers : UserControl
    {
        UserRepository UserRepository = new UserRepository();
        protected string lastname;
        protected string firstname;
        protected string email;
        protected string team;
        protected string project;
        protected string id;
        protected int page;
        protected int pagination;
        public UserPaginationUsers(string lastname = null, string firstname = null, string email = null, string team = null, string project = null, string id = null, int page = 0)
        {
            InitializeComponent();

            this.lastname = lastname != "" || lastname != null ? lastname : null;
            this.firstname = firstname != "" || firstname != null ? firstname : null;
            this.email = email != "" || email != null ? email : null;
            this.team = team != "" || team != null ? team : null;
            this.project = project != "" || project != null ? project : null;
            this.id = id != "" || id != null ? id : null;
            this.page = page;

            int NbUser = UserRepository.getUserFromOrganization(Session.UserId, lastname, firstname, email, team, project, id, page, false).Count();

            int pagination = NbUser / 25;

            if (pagination != 0 && NbUser % pagination == 0)
            {
                pagination--;
            }
            this.pagination = pagination;

            Button FastBackward = new Button();
            FastBackward.Name = "FastBackward";
            FastBackward.Text = "<<<";
            FastBackward.FlatStyle = FlatStyle.Flat;
            FastBackward.FlatAppearance.BorderSize = 0;
            FastBackward.BackColor = Color.Transparent;
            FastBackward.Cursor = Cursors.Hand;
            FastBackward.Font = new Font("Cambria", 10);
            FastBackward.AutoSize = true;
            FastBackward.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FastBackward.Location = new Point(0, 2);
            FastBackward.Click += new EventHandler(goToPaginateUser);
            Controls.Add(FastBackward);

            Button Backward = new Button();
            Backward.Name = "Backward";
            Backward.Text = "<";
            Backward.FlatStyle = FlatStyle.Flat;
            Backward.FlatAppearance.BorderSize = 0;
            Backward.BackColor = Color.Transparent;
            Backward.Cursor = Cursors.Hand;
            Backward.Font = new Font("Cambria", 10);
            Backward.AutoSize = true;
            Backward.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Backward.Location = new Point(50, 2);
            Backward.Click += new EventHandler(goToPaginateUser);
            Controls.Add(Backward);

            int positionButton = 90;

            for (int i = page - 10; i <= pagination; i++)
            {
                if (i < 0)
                {
                    continue;
                }

                if (i >= page + 10)
                {
                    continue;
                }

                Button button = new Button();
                button.Name = i.ToString();
                button.Text = i.ToString();
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                if (i == page)
                {
                    button.BackColor = Color.Gray;
                }
                button.Cursor = Cursors.Hand;
                button.Font = new Font("Cambria", 10);
                button.AutoSize = true;
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                button.Location = new Point(positionButton, 2);
                button.Click += new EventHandler(goToPaginateUser);
                Controls.Add(button);

                positionButton += 30;
            }

            positionButton += 10;

            Button Forward = new Button();
            Forward.Name = "Forward";
            Forward.Text = ">";
            Forward.FlatStyle = FlatStyle.Flat;
            Forward.FlatAppearance.BorderSize = 0;
            Forward.BackColor = Color.Transparent;
            Forward.Cursor = Cursors.Hand;
            Forward.Font = new Font("Cambria", 10);
            Forward.AutoSize = true;
            Forward.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Forward.Location = new Point(positionButton, 2);
            Forward.Click += new EventHandler(goToPaginateUser);
            Controls.Add(Forward);

            Button FastForward = new Button();
            FastForward.Name = "FastForward";
            FastForward.Text = ">>>";
            FastForward.FlatStyle = FlatStyle.Flat;
            FastForward.FlatAppearance.BorderSize = 0;
            FastForward.BackColor = Color.Transparent;
            FastForward.Cursor = Cursors.Hand;
            FastForward.Font = new Font("Cambria", 10);
            FastForward.AutoSize = true;
            FastForward.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FastForward.Location = new Point(positionButton + 30, 2);
            FastForward.Click += new EventHandler(goToPaginateUser);
            Controls.Add(FastForward);

            Label Label = new Label();
            Label.Text = NbUser.ToString();
            this.Controls.Add(Label);
        }

        private void goToPaginateUser(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (Convert.ToString(button.Name) == "FastForward")
            {
                UserMainList.goToPaginateUser(lastname, firstname, email, team, project, id, pagination);
            }
            else if (Convert.ToString(button.Name) == "Forward")
            {
                if (page < pagination)
                {
                    UserMainList.goToPaginateUser(lastname, firstname, email, team, project, id, page + 1);
                }
            }
            else if (Convert.ToString(button.Name) == "Backward")
            {
                if (page > 0)
                {
                    UserMainList.goToPaginateUser(lastname, firstname, email, team, project, id, page -1);
                }
            }
            else if (Convert.ToString(button.Name) == "FastBackward")
            {
                UserMainList.goToPaginateUser(lastname, firstname, email, team, project, id, 0);
            }
            else
            {
                UserMainList.goToPaginateUser(lastname, firstname, email, team, project, id, Convert.ToInt32(button.Name));
            }
        }
    }
}
