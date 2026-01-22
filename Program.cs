using System;
using System.IO;

namespace SkyShards
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Shard grove = new Shard();

            grove.Name = "Grove";
            grove.Rarity = "Common";
            grove.ImagePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Images", "Grove.png"));
            grove.Family = "elemental";
            grove.Type = "global";
            grove.Level = 1;
            grove.Effect ="Grants +2 to +20 Health based on level";
            grove.CanFuse = true;
            grove.IsEnabled = true;


            Console.WriteLine("Which shard would you like to see?");
            

            Console.WriteLine("Shard Name: " + grove.Name);
            Console.WriteLine("Image Path: " + grove.ImagePath);
            Console.WriteLine("Rarity: " + grove.Rarity);
            Console.WriteLine("Family: " + grove.Family);
            Console.WriteLine("Type: " + grove.Type);
            Console.WriteLine("Level: " + grove.Level);
            Console.WriteLine("Effect: " + grove.Effect);
            Console.WriteLine("Can Fuse: " + grove.CanFuse);
            Console.WriteLine("Is Enabled: " + grove.IsEnabled);
        }
    }
}
