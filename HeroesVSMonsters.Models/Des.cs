namespace HeroesVSMonsters.Models
{
    public class Des
    {
        int _minimum = 1;
        int _maximum;
        protected int Minimum
        {
            get { return _minimum; }
            private set { _minimum = value; }
        }
        protected int Maximum
        { 
            get {return _maximum; }
            private set {_maximum = value; }    
        }
        public int Lance (int Maximum)
        {
            Random random = new Random();
            int result= random.Next(Minimum, Maximum+1);
            return result;
        }
    }
}
