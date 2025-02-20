namespace section4.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;
        public Location Location
        {
            get { return location; }
            set
            {
                if (!location.Equals(value))
                {
                    location = value;
                    if (BAllLocationChanged != null)
                        BAllLocationChanged.Invoke(this);
                }
            }
        }
        // using Delegate
        //public  Action<Ball> BAllLocationChanged;
        // using Event
        public event Action<Ball> BAllLocationChanged;
        public override string ToString()
        {
            return $"Id : {Id} :: Location : {location}";
        }

    }
}
