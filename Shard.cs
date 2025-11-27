using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyShards
{
    public class Shard
    {
        public string name;
        public string imagepath;
        public string rarity;
        public string family;
        public string type;
        public int level;
        public string effect;
        public bool canfuse;
        public bool isenabled;

        public Shard()
        { 
            name = "standaart";
            imagepath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Images", "Error.png"));
            rarity = "common";
            family = "elemental";   
            type = "global";
            level = 1;
            effect = "Placeholder";
            canfuse = false;
            isenabled = false;
        }

        public Shard(string name, string imagepath, string rarity, string family, string type, int level, string effect, bool canfuse, bool isenabled)
        {
            this.name = name;
            this.imagepath = imagepath;
            this.rarity = rarity;
            this.family = family;
            this.type = type;
            this.level = level;
            this.effect = effect;
            this.canfuse = canfuse;
            this.isenabled = isenabled;
        }

    }
}