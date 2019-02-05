using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EmblemMod.NPCs
{
    public class EmblemGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            base.NPCLoot(npc);
            if(npc.type == NPCID.WallofFlesh) // This is used to add to the Wall of Flesh's loot table.
            {
                if (Main.rand.Next(8) == 0) // This means 1 in 8 chance.
                    Item.NewItem(npc.getRect(), mod.ItemType("ThrowerEmblem")); // Write mod.ItemType("ItemNameHere") to refer to an item from the mod.

                // For some reason it doesn't work with "if (Main.rand.NextFloat() < .1225f)" which means 12.25% drop chance, 
                // so I use "if (Main.rand.Next(8) == 0)" which means 1/8 drop chance and is essentially the same thing.
            }
        }
    }
}
