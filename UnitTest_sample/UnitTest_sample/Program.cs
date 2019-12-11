namespace UnitTest_sample
{
    public class GamePlayer
    {
        private string Name { get; set; } 
        public uint TotalPlayTime { get; private set; }
        

        public GamePlayer(string name)
        {
            this.Name = name;
            this.TotalPlayTime = 0;
        }

        public void AddPlayTime(uint time)
        {
            this.TotalPlayTime += time;
        }

        public string GetPlayerStatus()
        {
            var status = $"name:{this.Name} playTime:${this.TotalPlayTime}";
            return status;
        }
    }
    
    
    
}