using System;
using System.IO;

namespace SkyShards
{
    public class Shard
    {
        public string Name;
        public string ImagePath;
        public string Rarity;
        public string Family;
        public string Type;
        public int Level;
        public string Effect;
        public bool CanFuse;
        public bool IsEnabled;

        public Shard()
        {
            Name = "standaart";
            ImagePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Images",
                "Error.png"));
            Rarity = "common";
            Family = "elemental";
            Type = "global";
            Level = 1;
            Effect = "Placeholder";
            CanFuse = false;
            IsEnabled = false;
        }

        public Shard(string name, string imagepath, string rarity, string family, string type, int level, string effect,
            bool canfuse, bool isenabled)
        {
            this.Name = name;
            this.ImagePath = imagepath;
            this.Rarity = rarity;
            this.Family = family;
            this.Type = type;
            this.Level = level;
            this.Effect = effect;
            this.CanFuse = canfuse;
            this.IsEnabled = isenabled;
        }
    }
}