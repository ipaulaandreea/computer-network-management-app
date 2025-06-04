namespace NetworkManagementApp.Model
{
    public class Drept
    {
        public int? Id { get; set; }
        public string? Nume { get; set; }


        public Drept(int id, string nume)
        {
            this.Id = id;
            this.Nume = nume;
        }

        public Drept() { }

    }
}