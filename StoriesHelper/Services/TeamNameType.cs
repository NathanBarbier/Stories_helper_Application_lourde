namespace StoriesHelper.Services
{
    class TeamNameType
    {
        public int id;
        public string name;
        public bool active;

        public void initializeTeamNameType(int id, string name, bool active)
        {
            this.id = id;
            this.name = name;
            this.active = active;
        }
    }
}
