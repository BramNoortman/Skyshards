using System;
using System.IO;

namespace SkyShards
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Shard grove = new Shard();

            grove.name = "Grove";
            grove.rarity = "Common";
            grove.imagepath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Images", "Grove.png"));
            grove.family = "elemental";
            grove.type = "global";
            grove.level = 1;
            grove.effect ="Grants +2 to +20 Health based on level";
            grove.canfuse = true;
            grove.isenabled = true;


            Console.WriteLine("Welke shard wil je graag zien");
            

            Console.WriteLine("Shard Name: " + grove.name);
            Console.WriteLine("Image Path: " + grove.imagepath);
            Console.WriteLine("Rarity: " + grove.rarity);
            Console.WriteLine("Family: " + grove.family);
            Console.WriteLine("Type: " + grove.type);
            Console.WriteLine("Level: " + grove.level);
            Console.WriteLine("Effect: " + grove.effect);
            Console.WriteLine("Can Fuse: " + grove.canfuse);
            Console.WriteLine("Is Enabled: " + grove.isenabled);
        }
    }
}
