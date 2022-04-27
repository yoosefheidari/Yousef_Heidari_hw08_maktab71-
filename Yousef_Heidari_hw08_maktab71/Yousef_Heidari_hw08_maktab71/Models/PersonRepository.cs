namespace Yousef_Heidari_hw08_maktab71.Models
{
    public static class PersonRepository
    {
        public static List<Person> Persons = new List<Person>();
        static PersonRepository()
        {
            Persons.Add(new Person() { Id = 12, Name = "Yousef" });
            Persons.Add(new Person() { Id = 25, Name = "Ali" });
            Persons.Add(new Person() { Id = 29, Name = "Amir" });
            Persons.Add(new Person() { Id = 4, Name = "Hasan" });
            Persons.Add(new Person() { Id = 1, Name = "Reza" });

        }
        public static List<Person> GetAll()
        {
            return Persons;

        }
        public static void Delete(int id)
        {
            var person = Persons.FirstOrDefault(o=>o.Id==id);
            Persons.Remove(person);
        }
        public static Person Find(int id)
        {
            return Persons.FirstOrDefault((o)=>o.Id==id);
        }

    }
}
