namespace StoriesHelper.Services
{
    class ProjectNameType
    {
        public int id;
        public string name;
        public string type;
        public bool active;

        public void initializeProjectNameType(int id, string name, string type, bool active)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.active = active;
        }
    }
}
