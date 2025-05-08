namespace Final // or whatever your project namespace is
{
    public abstract class User
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public User(string name, string role)
        {
            this.Name = name;   // use 'this.' to refer to the property
            this.Role = role;
        }

        public abstract void OpenDashboard();
    }
}
