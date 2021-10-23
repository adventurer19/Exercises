namespace VetClinic
{
    public class Pet
    {

        public string Name { get;private set; }
        public int Age { get; private set; }
        public string Owner { get; private set; }

        public Pet(string name,int age,string owner)
        {
            this.Name = name;
            this.Age = age;
            this.Owner = owner;
        }
        public override string ToString()
        {
            return $"Name: {this.Name} Age: {this.Age} Owner: {this.Owner}";
        }
    }
}
