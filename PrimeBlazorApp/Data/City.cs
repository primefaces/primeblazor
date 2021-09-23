namespace PrimeBlazorDemo.Data
{
    public class City {
        public string name { get; set; }
        public string code { get; set; }

        public City() {

        }

        public City(string name, string code) 
        {
            this.name = name;
            this.code = code;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is City))
            {
                return false;
            }
            return (this.name == ((City)obj).name)
                && (this.code == ((City)obj).code);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() ^ code.GetHashCode();
        }
    }
}
