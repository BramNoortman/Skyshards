using System;
using System.IO;
using System.Windows.Forms;



namespace SkyShards
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        { 
            Shards.Name = "Grove";
            Shards.Rarity = "Common";
            Shards.ImagePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Images", "Grove.png"));
            Shards.family = "elemental";
            Shards.Type = "global";
            Shards.Level = 1;
            Shards.Effect ="Grants +2 to +20 Health based on level";
            Shards.CanFuse = true;
            Shards.isenabled = true;

            Console.WriteLine("Shard Name: " + Shards.Name);
            Console.WriteLine("Image Path: " + Shards.ImagePath);
            Console.WriteLine("Rarity: " + Shards.Rarity);
            Console.WriteLine("Family: " + Shards.family);
            Console.WriteLine("Type: " + Shards.Type);
            Console.WriteLine("Level: " + Shards.Level);
            Console.WriteLine("Effect: " + Shards.Effect);
            Console.WriteLine("Can Fuse: " + Shards.CanFuse);
            Console.WriteLine("Is Enabled: " + Shards.isenabled);
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShardForm());
        }
    }
}
