namespace section4.YouTube
{
    internal class Subscriber
    {
        public string Name { get; set; }
        public void Notify(Channel channel, Video video)
        {
            Console.WriteLine($"Channel : {channel.Title} is add video : {video} ya {Name}");
        }
        public override string ToString()
        {
            return $"subscriber Name : {Name}";
        }

    }
}
