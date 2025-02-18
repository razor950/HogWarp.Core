namespace HogWarp.Game
{
    public interface IPlayer
    {
        public void Kick();

        public ulong Id
        {
            get;
        }

        public uint ConnectionId
        {
            get;
        }

        public string Username
        {
            get;
        }

        public string UniqueId
        {
            get;
        }

        // Where do we put shared types? In this module?
        /*public Types.FVector Position
        {
            get;
        }*/

        public float Direction
        {
            get;
        }

        public float Speed
        {
            get;
        }

        public bool IsInAir
        {
            get;
        }

        public byte House
        {
            get;
        }

        public byte Gender
        {
            get;
        }

        public bool IsMounted
        {
            get;
        }
    }
}