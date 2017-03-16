module Blocks

(*
let allBlocks = [|
    { Name="Air"; TileName="air"; DataTag=None; ID=0}
    { Name="Stone"; TileName="stone"; DataTag=Some 0; ID=1}
    { Name="Granite"; TileName="stone"; DataTag=Some 1; ID=1}
    { Name="Polished Granite"; TileName="stone"; DataTag=Some 2; ID=1}
    { Name="Diorite"; TileName="stone"; DataTag=Some 3; ID=1}
    { Name="Polished Diorite"; TileName="stone"; DataTag=Some 4; ID=1}
    { Name="Andesite"; TileName="stone"; DataTag=Some 5; ID=1}
    { Name="Polished Andesite"; TileName="stone"; DataTag=Some 6; ID=1}
    { Name="Grass Block"; TileName="grass"; DataTag=None; ID=2}
    { Name="Dirt"; TileName="dirt"; DataTag=Some 0; ID=3}
    { Name="Coarse Dirt"; TileName="dirt"; DataTag=Some 1; ID=3}
    { Name="Podzol"; TileName="dirt"; DataTag=Some 2; ID=3}
    { Name="Cobblestone"; TileName="cobblestone"; DataTag=None; ID=4}
    { Name="Oak Wood Plank"; TileName="planks"; DataTag=Some 0; ID=5}
    { Name="Spruce Wood Plank"; TileName="planks"; DataTag=Some 1; ID=5}
    { Name="Birch Wood Plank"; TileName="planks"; DataTag=Some 2; ID=5}
    { Name="Jungle Wood Plank"; TileName="planks"; DataTag=Some 3; ID=5}
    { Name="Acacia Wood Plank"; TileName="planks"; DataTag=Some 4; ID=5}
    { Name="Dark Oak Wood Plank"; TileName="planks"; DataTag=Some 5; ID=5}
    { Name="Oak Sapling"; TileName="sapling"; DataTag=Some 0; ID=6}
    { Name="Spruce Sapling"; TileName="sapling"; DataTag=Some 1; ID=6}
    { Name="Birch Sapling"; TileName="sapling"; DataTag=Some 2; ID=6}
    { Name="Jungle Sapling"; TileName="sapling"; DataTag=Some 3; ID=6}
    { Name="Acacia Sapling"; TileName="sapling"; DataTag=Some 4; ID=6}
    { Name="Dark Oak Sapling"; TileName="sapling"; DataTag=Some 5; ID=6}
    { Name="Bedrock"; TileName="bedrock"; DataTag=None; ID=7}
    { Name="Sand"; TileName="sand"; DataTag=Some 0; ID=12}
    { Name="Red Sand"; TileName="sand"; DataTag=Some 1; ID=12}
    { Name="Gravel"; TileName="gravel"; DataTag=None; ID=13}
    { Name="Gold Ore"; TileName="gold_ore"; DataTag=None; ID=14}
    { Name="Iron Ore"; TileName="iron_ore"; DataTag=None; ID=15}
    { Name="Coal Ore"; TileName="coal_ore"; DataTag=None; ID=16}
    { Name="Oak Wood"; TileName="log"; DataTag=Some 0; ID=17}
    { Name="Spruce Wood"; TileName="log"; DataTag=Some 1; ID=17}
    { Name="Birch Wood"; TileName="log"; DataTag=Some 2; ID=17}
    { Name="Jungle Wood"; TileName="log"; DataTag=Some 3; ID=17}
    { Name="Oak Leaves"; TileName="leaves"; DataTag=Some 0; ID=18}
    { Name="Spruce Leaves"; TileName="leaves"; DataTag=Some 1; ID=18}
    { Name="Birch Leaves"; TileName="leaves"; DataTag=Some 2; ID=18}
    { Name="Jungle Leaves"; TileName="leaves"; DataTag=Some 3; ID=18}
    { Name="Sponge"; TileName="sponge"; DataTag=Some 0; ID=19}
    { Name="Wet Sponge"; TileName="sponge"; DataTag=Some 1; ID=19}
    { Name="Glass"; TileName="glass"; DataTag=None; ID=20}
    { Name="Lapis Lazuli Ore"; TileName="lapis_ore"; DataTag=None; ID=21}
    { Name="Lapis Lazuli Block"; TileName="lapis_block"; DataTag=None; ID=22}
    { Name="Dispenser"; TileName="dispenser"; DataTag=None; ID=23}
    { Name="Sandstone"; TileName="sandstone"; DataTag=Some 0; ID=24}
    { Name="Chiseled Sandstone"; TileName="sandstone"; DataTag=Some 1; ID=24}
    { Name="Smooth Sandstone"; TileName="sandstone"; DataTag=Some 2; ID=24}
    { Name="Note Block"; TileName="noteblock"; DataTag=None; ID=25}
    { Name="Powered Rails"; TileName="golden_rail"; DataTag=None; ID=27}
    { Name="Detector Rails"; TileName="detector_rail"; DataTag=None; ID=28}
    { Name="Sticky Piston"; TileName="sticky_piston"; DataTag=None; ID=29}
    { Name="Cobweb"; TileName="web"; DataTag=None; ID=30}
    { Name="Grass"; TileName="tallgrass"; DataTag=Some 1; ID=31}
    { Name="Fern"; TileName="tallgrass"; DataTag=Some 2; ID=31}
    { Name="Dead Bush"; TileName="deadbush"; DataTag=None; ID=32}
    { Name="Piston"; TileName="piston"; DataTag=None; ID=33}
    { Name="Wool"; TileName="wool"; DataTag=Some 0; ID=35}
    { Name="Orange Wool"; TileName="wool"; DataTag=Some 1; ID=35}
    { Name="Magenta Wool"; TileName="wool"; DataTag=Some 2; ID=35}
    { Name="Light Blue Wool"; TileName="wool"; DataTag=Some 3; ID=35}
    { Name="Yellow Wool"; TileName="wool"; DataTag=Some 4; ID=35}
    { Name="Lime Wool"; TileName="wool"; DataTag=Some 5; ID=35}
    { Name="Pink Wool"; TileName="wool"; DataTag=Some 6; ID=35}
    { Name="Gray Wool"; TileName="wool"; DataTag=Some 7; ID=35}
    { Name="Light Gray Wool"; TileName="wool"; DataTag=Some 8; ID=35}
    { Name="Cyan Wool"; TileName="wool"; DataTag=Some 9; ID=35}
    { Name="Purple Wool"; TileName="wool"; DataTag=Some 10; ID=35}
    { Name="Blue Wool"; TileName="wool"; DataTag=Some 11; ID=35}
    { Name="Brown Wool"; TileName="wool"; DataTag=Some 12; ID=35}
    { Name="Green Wool"; TileName="wool"; DataTag=Some 13; ID=35}
    { Name="Red Wool"; TileName="wool"; DataTag=Some 14; ID=35}
    { Name="Black Wool"; TileName="wool"; DataTag=Some 15; ID=35}
    { Name="Dandelion"; TileName="yellow_flower"; DataTag=Some 0; ID=37}
    { Name="Poppy"; TileName="red_flower"; DataTag=Some 0; ID=38}
    { Name="Blue Orchid"; TileName="red_flower"; DataTag=Some 1; ID=38}
    { Name="Allium"; TileName="red_flower"; DataTag=Some 2; ID=38}
    { Name="Azure Bluet"; TileName="red_flower"; DataTag=Some 3; ID=38}
    { Name="Red Tulip"; TileName="red_flower"; DataTag=Some 4; ID=38}
    { Name="Orange Tulip"; TileName="red_flower"; DataTag=Some 5; ID=38}
    { Name="White Tulip"; TileName="red_flower"; DataTag=Some 6; ID=38}
    { Name="Pink Tulip"; TileName="red_flower"; DataTag=Some 7; ID=38}
    { Name="Oxeye Daisy"; TileName="red_flower"; DataTag=Some 8; ID=38}
    { Name="Mushroom (brown)"; TileName="brown_mushroom"; DataTag=None; ID=39}
    { Name="Mushroom (red with white spots)"; TileName="red_mushroom"; DataTag=None; ID=40}
    { Name="Block of Gold"; TileName="gold_block"; DataTag=None; ID=41}
    { Name="Block of Iron"; TileName="iron_block"; DataTag=None; ID=42}
    { Name="Stone Slab"; TileName="stone_slab"; DataTag=Some 0; ID=44}
    { Name="Sandstone Slab"; TileName="stone_slab"; DataTag=Some 1; ID=44}
    { Name="Cobblestone Slab"; TileName="stone_slab"; DataTag=Some 3; ID=44}
    { Name="Bricks Slab"; TileName="stone_slab"; DataTag=Some 4; ID=44}
    { Name="Stone Bricks Slab"; TileName="stone_slab"; DataTag=Some 5; ID=44}
    { Name="Nether Brick Slab"; TileName="stone_slab"; DataTag=Some 6; ID=44}
    { Name="Quartz Slab"; TileName="stone_slab"; DataTag=Some 7; ID=44}
    { Name="Bricks"; TileName="brick_block"; DataTag=None; ID=45}
    { Name="TNT"; TileName="tnt"; DataTag=None; ID=46}
    { Name="Bookshelf"; TileName="bookshelf"; DataTag=None; ID=47}
    { Name="Moss Stone"; TileName="mossy_cobblestone"; DataTag=None; ID=48}
    { Name="Obsidian"; TileName="obsidian"; DataTag=None; ID=49}
    { Name="Torch"; TileName="torch"; DataTag=None; ID=50}
    { Name="Mob Spawner"; TileName="mob_spawner"; DataTag=None; ID=52}
    { Name="Oak Wood Stairs"; TileName="oak_stairs"; DataTag=None; ID=53}
    { Name="Chest"; TileName="chest"; DataTag=None; ID=54}
    { Name="Diamond Ore"; TileName="diamond_ore"; DataTag=None; ID=56}
    { Name="Block of Diamond"; TileName="diamond_block"; DataTag=None; ID=57}
    { Name="Crafting Table"; TileName="crafting_table"; DataTag=None; ID=58}
    { Name="Farmland"; TileName="farmland"; DataTag=None; ID=60}
    { Name="Furnace"; TileName="furnace"; DataTag=None; ID=61}
    { Name="Furnace - Lit"; TileName="lit_furnace"; DataTag=None; ID=62}
    { Name="Ladder"; TileName="ladder"; DataTag=None; ID=65}
    { Name="Rails"; TileName="rail"; DataTag=None; ID=66}
    { Name="Cobblestone Stairs"; TileName="stone_stairs"; DataTag=None; ID=67}
    { Name="Lever"; TileName="lever"; DataTag=None; ID=69}
    { Name="Stone Pressure Plate"; TileName="stone_pressure_plate"; DataTag=None; ID=70}
    { Name="Wooden Pressure Plate"; TileName="wooden_pressure_plate"; DataTag=None; ID=72}
    { Name="Redstone Ore"; TileName="redstone_ore"; DataTag=None; ID=73}
    { Name="Redstone Torch"; TileName="redstone_torch"; DataTag=None; ID=76}
    { Name="Stone Button"; TileName="stone_button"; DataTag=None; ID=77}
    { Name="Snow"; TileName="snow_layer"; DataTag=Some 0; ID=78}
    { Name="Ice"; TileName="ice"; DataTag=None; ID=79}
    { Name="Snow"; TileName="snow"; DataTag=None; ID=80}
    { Name="Cactus"; TileName="cactus"; DataTag=None; ID=81}
    { Name="Clay Block"; TileName="clay"; DataTag=None; ID=82}
    { Name="Jukebox"; TileName="jukebox"; DataTag=None; ID=84}
    { Name="Oak Fence"; TileName="fence"; DataTag=None; ID=85}
    { Name="Pumpkin"; TileName="pumpkin"; DataTag=None; ID=86}
    { Name="Netherrack"; TileName="netherrack"; DataTag=None; ID=87}
    { Name="Soul Sand"; TileName="soul_sand"; DataTag=None; ID=88}
    { Name="Glowstone"; TileName="glowstone"; DataTag=None; ID=89}
    { Name="Jack o'Lantern"; TileName="lit_pumpkin"; DataTag=None; ID=91}
    { Name="White Stained Glass"; TileName="stained_glass"; DataTag=Some 0; ID=95}
    { Name="Orange Stained Glass"; TileName="stained_glass"; DataTag=Some 1; ID=95}
    { Name="Magenta Stained Glass"; TileName="stained_glass"; DataTag=Some 2; ID=95}
    { Name="Light Blue Stained Glass"; TileName="stained_glass"; DataTag=Some 3; ID=95}
    { Name="Yellow Stained Glass"; TileName="stained_glass"; DataTag=Some 4; ID=95}
    { Name="Lime Stained Glass"; TileName="stained_glass"; DataTag=Some 5; ID=95}
    { Name="Pink Stained Glass"; TileName="stained_glass"; DataTag=Some 6; ID=95}
    { Name="Gray Stained Glass"; TileName="stained_glass"; DataTag=Some 7; ID=95}
    { Name="Light Gray Stained Glass"; TileName="stained_glass"; DataTag=Some 8; ID=95}
    { Name="Cyan Stained Glass"; TileName="stained_glass"; DataTag=Some 9; ID=95}
    { Name="Purple Stained Glass"; TileName="stained_glass"; DataTag=Some 10; ID=95}
    { Name="Blue Stained Glass"; TileName="stained_glass"; DataTag=Some 11; ID=95}
    { Name="Brown Stained Glass"; TileName="stained_glass"; DataTag=Some 12; ID=95}
    { Name="Green Stained Glass"; TileName="stained_glass"; DataTag=Some 13; ID=95}
    { Name="Red Stained Glass"; TileName="stained_glass"; DataTag=Some 14; ID=95}
    { Name="Black Stained Glass"; TileName="stained_glass"; DataTag=Some 15; ID=95}
    { Name="Wooden Trapdoor"; TileName="trapdoor"; DataTag=None; ID=96}
    { Name="Stone Monster Egg"; TileName="monster_egg"; DataTag=Some 0; ID=97}
    { Name="Cobblestone Monster Egg"; TileName="monster_egg"; DataTag=Some 1; ID=97}
    { Name="Stone Brick Monster Egg"; TileName="monster_egg"; DataTag=Some 2; ID=97}
    { Name="Mossy Stone Brick Monster Egg"; TileName="monster_egg"; DataTag=Some 3; ID=97}
    { Name="Cracked Stone Brick Monster Egg"; TileName="monster_egg"; DataTag=Some 4; ID=97}
    { Name="Chiseled Stone Brick Monster Egg"; TileName="monster_egg"; DataTag=Some 5; ID=97}
    { Name="Stone Bricks"; TileName="stonebrick"; DataTag=Some 0; ID=98}
    { Name="Mossy Stone Bricks"; TileName="stonebrick"; DataTag=Some 1; ID=98}
    { Name="Cracked Stone Bricks"; TileName="stonebrick"; DataTag=Some 2; ID=98}
    { Name="Chiseled Stone Bricks"; TileName="stonebrick"; DataTag=Some 3; ID=98}
    { Name="Brown Mushroom Block"; TileName="brown_mushroom_block"; DataTag=None; ID=99}
    { Name="Red Mushroom Block"; TileName="red_mushroom_block"; DataTag=None; ID=100}
    { Name="Iron Bars"; TileName="iron_bars"; DataTag=None; ID=101}
    { Name="Glass Pane"; TileName="glass_pane"; DataTag=None; ID=102}
    { Name="Block of Melon"; TileName="melon_block"; DataTag=None; ID=103}
    { Name="Vines"; TileName="vine"; DataTag=None; ID=106}
    { Name="Oak Fence Gate"; TileName="fence_gate"; DataTag=None; ID=107}
    { Name="Brick Stairs"; TileName="brick_stairs"; DataTag=None; ID=108}
    { Name="Stone Brick Stairs"; TileName="stone_brick_stairs"; DataTag=None; ID=109}
    { Name="Mycelium"; TileName="mycelium"; DataTag=None; ID=110}
    { Name="Lily Pad"; TileName="waterlily"; DataTag=None; ID=111}
    { Name="Block of Nether Brick"; TileName="nether_brick"; DataTag=None; ID=112}
    { Name="Nether Brick Fence"; TileName="nether_brick_fence"; DataTag=None; ID=113}
    { Name="Nether Brick Stairs"; TileName="nether_brick_stairs"; DataTag=None; ID=114}
    { Name="Enchantment Table"; TileName="enchanting_table"; DataTag=None; ID=116}
    { Name="End Portal"; TileName="end_portal_frame"; DataTag=None; ID=120}
    { Name="End Stone"; TileName="end_stone"; DataTag=None; ID=121}
    { Name="Dragon Egg"; TileName="dragon_egg"; DataTag=None; ID=122}
    { Name="Redstone Lamp"; TileName="redstone_lamp"; DataTag=None; ID=123}
    { Name="Oak Wood Slab"; TileName="wooden_slab"; DataTag=Some 0; ID=126}
    { Name="Spruce Wood Slab"; TileName="wooden_slab"; DataTag=Some 1; ID=126}
    { Name="Birch Wood Slab"; TileName="wooden_slab"; DataTag=Some 2; ID=126}
    { Name="Jungle Wood Slab"; TileName="wooden_slab"; DataTag=Some 3; ID=126}
    { Name="Acacia Wood Slab"; TileName="wooden_slab"; DataTag=Some 4; ID=126}
    { Name="Dark Oak Wood Slab"; TileName="wooden_slab"; DataTag=Some 5; ID=126}
    { Name="Sandstone Stairs"; TileName="sandstone_stairs"; DataTag=None; ID=128}
    { Name="Emerald Ore"; TileName="emerald_ore"; DataTag=None; ID=129}
    { Name="Ender Chest"; TileName="ender_chest"; DataTag=None; ID=130}
    { Name="Tripwire Hook"; TileName="tripwire_hook"; DataTag=None; ID=131}
    { Name="Block of Emerald"; TileName="emerald_block"; DataTag=None; ID=133}
    { Name="Spruce Wood Stairs"; TileName="spruce_stairs"; DataTag=None; ID=134}
    { Name="Birch Wood Stairs"; TileName="birch_stairs"; DataTag=None; ID=135}
    { Name="Jungle Wood Stairs"; TileName="jungle_stairs"; DataTag=None; ID=136}
    { Name="Command Block"; TileName="command_block"; DataTag=None; ID=137}
    { Name="Beacon"; TileName="beacon"; DataTag=None; ID=138}
    { Name="Cobblestone Wall"; TileName="cobblestone_wall"; DataTag=Some 0; ID=139}
    { Name="Mossy Cobblestone Wall"; TileName="cobblestone_wall"; DataTag=Some 1; ID=139}
    { Name="Wooden Button"; TileName="wooden_button"; DataTag=None; ID=143}
    { Name="Anvil"; TileName="anvil"; DataTag=Some 0; ID=145}
    { Name="Slightly Damaged Anvil"; TileName="anvil"; DataTag=Some 1; ID=145}
    { Name="Very Damaged Anvil"; TileName="anvil"; DataTag=Some 2; ID=145}
    { Name="Trapped Chest"; TileName="trapped_chest"; DataTag=None; ID=146}
    { Name="Light Weighted Pressure Plate"; TileName="light_weighted_pressure_plate"; DataTag=None; ID=147}
    { Name="Heavy Weighted Pressure Plate"; TileName="heavy_weighted_pressure_plate"; DataTag=None; ID=148}
    { Name="Daylight Sensor"; TileName="daylight_detector"; DataTag=None; ID=151}
    { Name="Block of Redstone"; TileName="redstone_block"; DataTag=None; ID=152}
    { Name="Nether Quartz Ore"; TileName="quartz_ore"; DataTag=None; ID=153}
    { Name="Hopper"; TileName="hopper"; DataTag=None; ID=154}
    { Name="Block of Quartz"; TileName="quartz_block"; DataTag=Some 0; ID=155}
    { Name="Chiseled Quartz Block"; TileName="quartz_block"; DataTag=Some 1; ID=155}
    { Name="Pillar Quartz Block"; TileName="quartz_block"; DataTag=Some 2; ID=155}
    { Name="Quartz Stairs"; TileName="quartz_stairs"; DataTag=None; ID=156}
    { Name="Activator Rails"; TileName="activator_rail"; DataTag=None; ID=157}
    { Name="Dropper"; TileName="dropper"; DataTag=None; ID=158}
    { Name="White Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 0; ID=159}
    { Name="Orange Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 1; ID=159}
    { Name="Magenta Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 2; ID=159}
    { Name="Light Blue Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 3; ID=159}
    { Name="Yellow Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 4; ID=159}
    { Name="Lime Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 5; ID=159}
    { Name="Pink Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 6; ID=159}
    { Name="Gray Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 7; ID=159}
    { Name="Light Gray Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 8; ID=159}
    { Name="Cyan Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 9; ID=159}
    { Name="Purple Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 10; ID=159}
    { Name="Blue Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 11; ID=159}
    { Name="Brown Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 12; ID=159}
    { Name="Green Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 13; ID=159}
    { Name="Red Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 14; ID=159}
    { Name="Black Stained Clay"; TileName="stained_hardened_clay"; DataTag=Some 15; ID=159}
    { Name="White Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 0; ID=160}
    { Name="Orange Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 1; ID=160}
    { Name="Magenta Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 2; ID=160}
    { Name="Light Blue Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 3; ID=160}
    { Name="Yellow Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 4; ID=160}
    { Name="Lime Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 5; ID=160}
    { Name="Pink Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 6; ID=160}
    { Name="Gray Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 7; ID=160}
    { Name="Light Gray Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 8; ID=160}
    { Name="Cyan Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 9; ID=160}
    { Name="Purple Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 10; ID=160}
    { Name="Blue Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 11; ID=160}
    { Name="Brown Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 12; ID=160}
    { Name="Green Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 13; ID=160}
    { Name="Red Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 14; ID=160}
    { Name="Black Stained Glass Pane"; TileName="stained_glass_pane"; DataTag=Some 15; ID=160}
    { Name="Acacia Leaves"; TileName="leaves2"; DataTag=Some 0; ID=161}
    { Name="Dark Oak Leaves"; TileName="leaves2"; DataTag=Some 1; ID=161}
    { Name="Acacia Wood"; TileName="log2"; DataTag=Some 0; ID=162}
    { Name="Dark Oak Wood"; TileName="log2"; DataTag=Some 1; ID=162}
    { Name="Acacia Wood Stairs"; TileName="acacia_stairs"; DataTag=None; ID=163}
    { Name="Dark Oak Wood Stairs"; TileName="dark_oak_stairs"; DataTag=None; ID=164}
    { Name="Slime Block"; TileName="slime"; DataTag=None; ID=165}
    { Name="Barrier"; TileName="barrier"; DataTag=None; ID=166}
    { Name="Iron Trapdoor"; TileName="iron_trapdoor"; DataTag=None; ID=167}
    { Name="Prismarine"; TileName="prismarine"; DataTag=Some 0; ID=168}
    { Name="Prismarine Bricks"; TileName="prismarine"; DataTag=Some 1; ID=168}
    { Name="Dark Prismarine"; TileName="prismarine"; DataTag=Some 2; ID=168}
    { Name="Sea Lantern"; TileName="sea_lantern"; DataTag=None; ID=169}
    { Name="Hay Bale"; TileName="hay_block"; DataTag=None; ID=170}
    { Name="Carpet"; TileName="carpet"; DataTag=Some 0; ID=171}
    { Name="Orange Carpet"; TileName="carpet"; DataTag=Some 1; ID=171}
    { Name="Magenta Carpet"; TileName="carpet"; DataTag=Some 2; ID=171}
    { Name="Light Blue Carpet"; TileName="carpet"; DataTag=Some 3; ID=171}
    { Name="Yellow Carpet"; TileName="carpet"; DataTag=Some 4; ID=171}
    { Name="Lime Carpet"; TileName="carpet"; DataTag=Some 5; ID=171}
    { Name="Pink Carpet"; TileName="carpet"; DataTag=Some 6; ID=171}
    { Name="Gray Carpet"; TileName="carpet"; DataTag=Some 7; ID=171}
    { Name="Light Gray Carpet"; TileName="carpet"; DataTag=Some 8; ID=171}
    { Name="Cyan Carpet"; TileName="carpet"; DataTag=Some 9; ID=171}
    { Name="Purple Carpet"; TileName="carpet"; DataTag=Some 10; ID=171}
    { Name="Blue Carpet"; TileName="carpet"; DataTag=Some 11; ID=171}
    { Name="Brown Carpet"; TileName="carpet"; DataTag=Some 12; ID=171}
    { Name="Green Carpet"; TileName="carpet"; DataTag=Some 13; ID=171}
    { Name="Red Carpet"; TileName="carpet"; DataTag=Some 14; ID=171}
    { Name="Black Carpet"; TileName="carpet"; DataTag=Some 15; ID=171}
    { Name="Hardened Clay"; TileName="hardened_clay"; DataTag=None; ID=172}
    { Name="Coal Block"; TileName="coal_block"; DataTag=None; ID=173}
    { Name="Packed Ice"; TileName="packed_ice"; DataTag=None; ID=174}
    { Name="Sunflower"; TileName="double_plant"; DataTag=Some 0; ID=175}
    { Name="Lilac"; TileName="double_plant"; DataTag=Some 1; ID=175}
    { Name="Double Tallgrass"; TileName="double_plant"; DataTag=Some 2; ID=175}
    { Name="Large Fern"; TileName="double_plant"; DataTag=Some 3; ID=175}
    { Name="Rose Bush"; TileName="double_plant"; DataTag=Some 4; ID=175}
    { Name="Peony"; TileName="double_plant"; DataTag=Some 5; ID=175}
    { Name="Red Sandstone"; TileName="red_sandstone"; DataTag=Some 0; ID=179}
    { Name="Chiseled Red Sandstone"; TileName="red_sandstone"; DataTag=Some 1; ID=179}
    { Name="Smooth Red Sandstone"; TileName="red_sandstone"; DataTag=Some 2; ID=179}
    { Name="Red Sandstone Stairs"; TileName="red_sandstone_stairs"; DataTag=None; ID=180}
    { Name="Red Sandstone Slab"; TileName="stone_slab2"; DataTag=Some 0; ID=182}
    { Name="Spruce Fence Gate"; TileName="spruce_fence_gate"; DataTag=None; ID=183}
    { Name="Birch Fence Gate"; TileName="birch_fence_gate"; DataTag=None; ID=184}
    { Name="Jungle Fence Gate"; TileName="jungle_fence_gate"; DataTag=None; ID=185}
    { Name="Dark Oak Fence Gate"; TileName="dark_oak_fence_gate"; DataTag=None; ID=186}
    { Name="Acacia Fence Gate"; TileName="acacia_fence_gate"; DataTag=None; ID=187}
    { Name="Spruce Fence"; TileName="spruce_fence"; DataTag=None; ID=188}
    { Name="Birch Fence"; TileName="birch_fence"; DataTag=None; ID=189}
    { Name="Jungle Fence"; TileName="jungle_fence"; DataTag=None; ID=190}
    { Name="Dark Oak Fence"; TileName="dark_oak_fence"; DataTag=None; ID=191}
    { Name="Acacia Fence"; TileName="acacia_fence"; DataTag=None; ID=192}
    { Name="Iron Shovel"; TileName="iron_shovel"; DataTag=None; ID=256}
    { Name="Iron Pickaxe"; TileName="iron_pickaxe"; DataTag=None; ID=257}
    { Name="Iron Axe"; TileName="iron_axe"; DataTag=None; ID=258}
    { Name="Flint and Steel"; TileName="flint_and_steel"; DataTag=None; ID=259}
    { Name="Apple"; TileName="apple"; DataTag=None; ID=260}
    { Name="Bow"; TileName="bow"; DataTag=None; ID=261}
    { Name="Arrow"; TileName="arrow"; DataTag=None; ID=262}
    { Name="Coal"; TileName="coal"; DataTag=Some 0; ID=263}
    { Name="Charcoal"; TileName="coal"; DataTag=Some 1; ID=263}
    { Name="Diamond"; TileName="diamond"; DataTag=None; ID=264}
    { Name="Iron Ingot"; TileName="iron_ingot"; DataTag=None; ID=265}
    { Name="Gold Ingot"; TileName="gold_ingot"; DataTag=None; ID=266}
    { Name="Iron Sword"; TileName="iron_sword"; DataTag=None; ID=267}
    { Name="Wooden Sword"; TileName="wooden_sword"; DataTag=None; ID=268}
    { Name="Wooden Shovel"; TileName="wooden_shovel"; DataTag=None; ID=269}
    { Name="Wooden Pickaxe"; TileName="wooden_pickaxe"; DataTag=None; ID=270}
    { Name="Wooden Axe"; TileName="wooden_axe"; DataTag=None; ID=271}
    { Name="Stone Sword"; TileName="stone_sword"; DataTag=None; ID=272}
    { Name="Stone Shovel"; TileName="stone_shovel"; DataTag=None; ID=273}
    { Name="Stone Pickaxe"; TileName="stone_pickaxe"; DataTag=None; ID=274}
    { Name="Stone Axe"; TileName="stone_axe"; DataTag=None; ID=275}
    { Name="Diamond Sword"; TileName="diamond_sword"; DataTag=None; ID=276}
    { Name="Diamond Shovel"; TileName="diamond_shovel"; DataTag=None; ID=277}
    { Name="Diamond Pickaxe"; TileName="diamond_pickaxe"; DataTag=None; ID=278}
    { Name="Diamond Axe"; TileName="diamond_axe"; DataTag=None; ID=279}
    { Name="Stick"; TileName="stick"; DataTag=None; ID=280}
    { Name="Bowl"; TileName="bowl"; DataTag=None; ID=281}
    { Name="Mushroom Stew"; TileName="mushroom_stew"; DataTag=None; ID=282}
    { Name="Golden Sword"; TileName="golden_sword"; DataTag=None; ID=283}
    { Name="Golden Shovel"; TileName="golden_shovel"; DataTag=None; ID=284}
    { Name="Golden Pickaxe"; TileName="golden_pickaxe"; DataTag=None; ID=285}
    { Name="Golden Axe"; TileName="golden_axe"; DataTag=None; ID=286}
    { Name="String"; TileName="string"; DataTag=None; ID=287}
    { Name="Feather"; TileName="feather"; DataTag=None; ID=288}
    { Name="Gunpowder"; TileName="gunpowder"; DataTag=None; ID=289}
    { Name="Wooden Hoe"; TileName="wooden_hoe"; DataTag=None; ID=290}
    { Name="Stone Hoe"; TileName="stone_hoe"; DataTag=None; ID=291}
    { Name="Iron Hoe"; TileName="iron_hoe"; DataTag=None; ID=292}
    { Name="Diamond Hoe"; TileName="diamond_hoe"; DataTag=None; ID=293}
    { Name="Golden Hoe"; TileName="golden_hoe"; DataTag=None; ID=294}
    { Name="Seeds"; TileName="wheat_seeds"; DataTag=None; ID=295}
    { Name="Wheat"; TileName="wheat"; DataTag=None; ID=296}
    { Name="Bread"; TileName="bread"; DataTag=None; ID=297}
    { Name="Leather Cap"; TileName="leather_helmet"; DataTag=None; ID=298}
    { Name="Leather Tunic"; TileName="leather_chestplate"; DataTag=None; ID=299}
    { Name="Leather Pants"; TileName="leather_leggings"; DataTag=None; ID=300}
    { Name="Leather Boots"; TileName="leather_boots"; DataTag=None; ID=301}
    { Name="Chain Helmet"; TileName="chainmail_helmet"; DataTag=None; ID=302}
    { Name="Chain Chestplate"; TileName="chainmail_chestplate"; DataTag=None; ID=303}
    { Name="Chain Leggings"; TileName="chainmail_leggings"; DataTag=None; ID=304}
    { Name="Chain Boots"; TileName="chainmail_boots"; DataTag=None; ID=305}
    { Name="Iron Helmet"; TileName="iron_helmet"; DataTag=None; ID=306}
    { Name="Iron Chestplate"; TileName="iron_chestplate"; DataTag=None; ID=307}
    { Name="Iron Leggings"; TileName="iron_leggings"; DataTag=None; ID=308}
    { Name="Iron Boots"; TileName="iron_boots"; DataTag=None; ID=309}
    { Name="Diamond Helmet"; TileName="diamond_helmet"; DataTag=None; ID=310}
    { Name="Diamond Chestplate"; TileName="diamond_chestplate"; DataTag=None; ID=311}
    { Name="Diamond Leggings"; TileName="diamond_leggings"; DataTag=None; ID=312}
    { Name="Diamond Boots"; TileName="diamond_boots"; DataTag=None; ID=313}
    { Name="Golden Helmet"; TileName="golden_helmet"; DataTag=None; ID=314}
    { Name="Golden Chestplate"; TileName="golden_chestplate"; DataTag=None; ID=315}
    { Name="Golden Leggings"; TileName="golden_leggings"; DataTag=None; ID=316}
    { Name="Golden Boots"; TileName="golden_boots"; DataTag=None; ID=317}
    { Name="Flint"; TileName="flint"; DataTag=None; ID=318}
    { Name="Raw Porkchop"; TileName="porkchop"; DataTag=None; ID=319}
    { Name="Cooked Porkchop"; TileName="cooked_porkchop"; DataTag=None; ID=320}
    { Name="Painting"; TileName="painting"; DataTag=None; ID=321}
    { Name="Golden Apple"; TileName="golden_apple"; DataTag=Some 0; ID=322}
    { Name="Enchanted Golden Apple"; TileName="golden_apple"; DataTag=Some 1; ID=322}
    { Name="Sign"; TileName="sign"; DataTag=None; ID=323}
    { Name="Oak Door"; TileName="wooden_door"; DataTag=None; ID=324}
    { Name="Bucket"; TileName="bucket"; DataTag=None; ID=325}
    { Name="Water Bucket"; TileName="water_bucket"; DataTag=None; ID=326}
    { Name="Lava Bucket"; TileName="lava_bucket"; DataTag=None; ID=327}
    { Name="Minecart"; TileName="minecart"; DataTag=None; ID=328}
    { Name="Saddle"; TileName="saddle"; DataTag=None; ID=329}
    { Name="Iron Door"; TileName="iron_door"; DataTag=None; ID=330}
    { Name="Redstone"; TileName="redstone"; DataTag=None; ID=331}
    { Name="Snowball"; TileName="snowball"; DataTag=None; ID=332}
    { Name="Boat"; TileName="boat"; DataTag=None; ID=333}
    { Name="Leather"; TileName="leather"; DataTag=None; ID=334}
    { Name="Milk"; TileName="milk_bucket"; DataTag=None; ID=335}
    { Name="Brick"; TileName="brick"; DataTag=None; ID=336}
    { Name="Clay"; TileName="clay_ball"; DataTag=None; ID=337}
    { Name="Sugar Canes"; TileName="reeds"; DataTag=None; ID=338}
    { Name="Paper"; TileName="paper"; DataTag=None; ID=339}
    { Name="Book"; TileName="book"; DataTag=None; ID=340}
    { Name="Slimeball"; TileName="slime_ball"; DataTag=None; ID=341}
    { Name="Minecart with Chest"; TileName="chest_minecart"; DataTag=None; ID=342}
    { Name="Minecart with Furnace"; TileName="furnace_minecart"; DataTag=None; ID=343}
    { Name="Egg"; TileName="egg"; DataTag=None; ID=344}
    { Name="Compass"; TileName="compass"; DataTag=None; ID=345}
    { Name="Fishing Rod"; TileName="fishing_rod"; DataTag=None; ID=346}
    { Name="Clock"; TileName="clock"; DataTag=None; ID=347}
    { Name="Glowstone Dust"; TileName="glowstone_dust"; DataTag=None; ID=348}
    { Name="Raw Fish"; TileName="fish"; DataTag=Some 0; ID=349}
    { Name="Raw Salmon"; TileName="fish"; DataTag=Some 1; ID=349}
    { Name="Clownfish"; TileName="fish"; DataTag=Some 2; ID=349}
    { Name="Pufferfish"; TileName="fish"; DataTag=Some 3; ID=349}
    { Name="Cooked Fish"; TileName="cooked_fish"; DataTag=Some 0; ID=350}
    { Name="Cooked Salmon"; TileName="cooked_fish"; DataTag=Some 1; ID=350}
    { Name="Ink Sac"; TileName="dye"; DataTag=Some 0; ID=351}
    { Name="Rose Red"; TileName="dye"; DataTag=Some 1; ID=351}
    { Name="Cactus Green"; TileName="dye"; DataTag=Some 2; ID=351}
    { Name="Cocoa Beans"; TileName="dye"; DataTag=Some 3; ID=351}
    { Name="Lapis Lazuli"; TileName="dye"; DataTag=Some 4; ID=351}
    { Name="Purple Dye"; TileName="dye"; DataTag=Some 5; ID=351}
    { Name="Cyan Dye"; TileName="dye"; DataTag=Some 6; ID=351}
    { Name="Light Gray Dye"; TileName="dye"; DataTag=Some 7; ID=351}
    { Name="Gray Dye"; TileName="dye"; DataTag=Some 8; ID=351}
    { Name="Pink Dye"; TileName="dye"; DataTag=Some 9; ID=351}
    { Name="Lime Dye"; TileName="dye"; DataTag=Some 10; ID=351}
    { Name="Dandelion Yellow"; TileName="dye"; DataTag=Some 11; ID=351}
    { Name="Light Blue Dye"; TileName="dye"; DataTag=Some 12; ID=351}
    { Name="Magenta Dye"; TileName="dye"; DataTag=Some 13; ID=351}
    { Name="Orange Dye"; TileName="dye"; DataTag=Some 14; ID=351}
    { Name="Bone Meal"; TileName="dye"; DataTag=Some 15; ID=351}
    { Name="Bone"; TileName="bone"; DataTag=None; ID=352}
    { Name="Sugar"; TileName="sugar"; DataTag=None; ID=353}
    { Name="Cake"; TileName="cake"; DataTag=None; ID=354}
    { Name="Bed"; TileName="bed"; DataTag=None; ID=355}
    { Name="Redstone Repeater"; TileName="repeater"; DataTag=None; ID=356}
    { Name="Cookie"; TileName="cookie"; DataTag=None; ID=357}
    { Name="Map (Filled)"; TileName="filled_map"; DataTag=None; ID=358}
    { Name="Shears"; TileName="shears"; DataTag=None; ID=359}
    { Name="Melon"; TileName="melon"; DataTag=None; ID=360}
    { Name="Pumpkin Seeds"; TileName="pumpkin_seeds"; DataTag=None; ID=361}
    { Name="Melon Seeds"; TileName="melon_seeds"; DataTag=None; ID=362}
    { Name="Raw Beef"; TileName="beef"; DataTag=None; ID=363}
    { Name="Steak"; TileName="cooked_beef"; DataTag=None; ID=364}
    { Name="Raw Chicken"; TileName="chicken"; DataTag=None; ID=365}
    { Name="Cooked Chicken"; TileName="cooked_chicken"; DataTag=None; ID=366}
    { Name="Rotten Flesh"; TileName="rotten_flesh"; DataTag=None; ID=367}
    { Name="Ender Pearl"; TileName="ender_pearl"; DataTag=None; ID=368}
    { Name="Blaze Rod"; TileName="blaze_rod"; DataTag=None; ID=369}
    { Name="Ghast Tear"; TileName="ghast_tear"; DataTag=None; ID=370}
    { Name="Gold Nugget"; TileName="gold_nugget"; DataTag=None; ID=371}
    { Name="Nether Wart"; TileName="nether_wart"; DataTag=None; ID=372}
    { Name="Water Bottle"; TileName="potion"; DataTag=Some 0; ID=373}
    { Name="Potion of Regeneration (0:45)"; TileName="potion"; DataTag=Some 8193; ID=373}
    { Name="Potion of Swiftness (3:00)"; TileName="potion"; DataTag=Some 8194; ID=373}
    { Name="Potion of Poison (0:45)"; TileName="potion"; DataTag=Some 8196; ID=373}
    { Name="Potion of Strength (3:00)"; TileName="potion"; DataTag=Some 8201; ID=373}
    { Name="Potion of Leaping (3:00 - Jump Boost)"; TileName="potion"; DataTag=Some 8203; ID=373}
    { Name="Potion of Regeneration (0:22 - Regeneration II)"; TileName="potion"; DataTag=Some 8225; ID=373}
    { Name="Potion of Swiftness (1:30 - Speed II)"; TileName="potion"; DataTag=Some 8226; ID=373}
    { Name="Potion of Fire Resistance (3:00)"; TileName="potion"; DataTag=Some 8227; ID=373}
    { Name="Potion of Poison (0:22 - Poison II)"; TileName="potion"; DataTag=Some 8228; ID=373}
    { Name="Potion of Healing (Instant Health II)"; TileName="potion"; DataTag=Some 8229; ID=373}
    { Name="Potion of Night Vision (3:00)"; TileName="potion"; DataTag=Some 8230; ID=373}
    { Name="Potion of Weakness (1:30)"; TileName="potion"; DataTag=Some 8232; ID=373}
    { Name="Potion of Strength (1:30 - Strength II)"; TileName="potion"; DataTag=Some 8233; ID=373}
    { Name="Potion of Slowness (1:30)"; TileName="potion"; DataTag=Some 8234; ID=373}
    { Name="Potion of Leaping (1:30 - Jump Boost II)"; TileName="potion"; DataTag=Some 8235; ID=373}
    { Name="Potion of Harming (Instant Damage II)"; TileName="potion"; DataTag=Some 8236; ID=373}
    { Name="Potion of Water Breathing (3:00)"; TileName="potion"; DataTag=Some 8237; ID=373}
    { Name="Potion of Invisibility (3:00)"; TileName="potion"; DataTag=Some 8238; ID=373}
    { Name="Potion of Regeneration (2:00)"; TileName="potion"; DataTag=Some 8257; ID=373}
    { Name="Potion of Swiftness (8:00)"; TileName="potion"; DataTag=Some 8258; ID=373}
    { Name="Potion of Fire Resistance (8:00)"; TileName="potion"; DataTag=Some 8259; ID=373}
    { Name="Potion of Poison (2:00)"; TileName="potion"; DataTag=Some 8260; ID=373}
    { Name="Potion of Healing (Instant Health)"; TileName="potion"; DataTag=Some 8261; ID=373}
    { Name="Potion of Night Vision (8:00)"; TileName="potion"; DataTag=Some 8262; ID=373}
    { Name="Potion of Weakness (4:00)"; TileName="potion"; DataTag=Some 8264; ID=373}
    { Name="Potion of Strength (8:00)"; TileName="potion"; DataTag=Some 8265; ID=373}
    { Name="Potion of Slowness (4:00)"; TileName="potion"; DataTag=Some 8266; ID=373}
    { Name="Potion of Leaping (8:00 - Jump Boost)"; TileName="potion"; DataTag=Some 8267; ID=373}
    { Name="Potion of Harming (Instant Damage)"; TileName="potion"; DataTag=Some 8268; ID=373}
    { Name="Potion of Water Breathing (8:00)"; TileName="potion"; DataTag=Some 8269; ID=373}
    { Name="Potion of Invisibility (8:00)"; TileName="potion"; DataTag=Some 8270; ID=373}
    { Name="Splash Potion of Regeneration (0:33)"; TileName="potion"; DataTag=Some 16385; ID=373}
    { Name="Splash Potion of Swiftness (2:15)"; TileName="potion"; DataTag=Some 16386; ID=373}
    { Name="Splash Potion of Poison (0:33)"; TileName="potion"; DataTag=Some 16388; ID=373}
    { Name="Splash Potion of Strength (2:15)"; TileName="potion"; DataTag=Some 16393; ID=373}
    { Name="Splash Potion of Leaping (2:15 - Jump Boost)"; TileName="potion"; DataTag=Some 16395; ID=373}
    { Name="Splash Potion of Regeneration (0:16 - Regeneration II)"; TileName="potion"; DataTag=Some 16417; ID=373}
    { Name="Splash Potion of Swiftness (1:07 - Speed II)"; TileName="potion"; DataTag=Some 16418; ID=373}
    { Name="Splash Potion of Fire Resistance (2:15)"; TileName="potion"; DataTag=Some 16419; ID=373}
    { Name="Splash Potion of Poison (0:16 - Poison II)"; TileName="potion"; DataTag=Some 16420; ID=373}
    { Name="Splash Potion of Healing (Instant Health II)"; TileName="potion"; DataTag=Some 16421; ID=373}
    { Name="Splash Potion of Night Vision (3:00/2:15)"; TileName="potion"; DataTag=Some 16422; ID=373}
    { Name="Splash Potion of Weakness (1:30/1:07)"; TileName="potion"; DataTag=Some 16424; ID=373}
    { Name="Splash Potion of Strength (1:07 - Strength II)"; TileName="potion"; DataTag=Some 16425; ID=373}
    { Name="Splash Potion of Slowness (1:07)"; TileName="potion"; DataTag=Some 16426; ID=373}
    { Name="Splash Potion of Leaping (1:07 - Jump Boost II)"; TileName="potion"; DataTag=Some 16427; ID=373}
    { Name="Splash Potion of Harming (Instant Damage II)"; TileName="potion"; DataTag=Some 16428; ID=373}
    { Name="Splash Potion of Water Breathing (2:15)"; TileName="potion"; DataTag=Some 16429; ID=373}
    { Name="Splash Potion of Invisibility (2:15)"; TileName="potion"; DataTag=Some 16430; ID=373}
    { Name="Splash Potion of Regeneration (1:30)"; TileName="potion"; DataTag=Some 16449; ID=373}
    { Name="Splash Potion of Swiftness (6:00)"; TileName="potion"; DataTag=Some 16450; ID=373}
    { Name="Splash Potion of Fire Resistance (6:00)"; TileName="potion"; DataTag=Some 16451; ID=373}
    { Name="Splash Potion of Poison (1:30)"; TileName="potion"; DataTag=Some 16452; ID=373}
    { Name="Splash Potion of Healing (Instant Health)"; TileName="potion"; DataTag=Some 16453; ID=373}
    { Name="Splash Potion of Night Vision (6:00)"; TileName="potion"; DataTag=Some 16454; ID=373}
    { Name="Splash Potion of Weakness (3:00)"; TileName="potion"; DataTag=Some 16456; ID=373}
    { Name="Splash Potion of Strength (6:00)"; TileName="potion"; DataTag=Some 16457; ID=373}
    { Name="Splash Potion of Slowness (3:00)"; TileName="potion"; DataTag=Some 16458; ID=373}
    { Name="Splash Potion of Leaping (6:00 - Jump Boost)"; TileName="potion"; DataTag=Some 16459; ID=373}
    { Name="Splash Potion of Harming (Instant Damage)"; TileName="potion"; DataTag=Some 16460; ID=373}
    { Name="Splash Potion of Water Breathing (6:00)"; TileName="potion"; DataTag=Some 16461; ID=373}
    { Name="Splash Potion of Invisibility (6:00)"; TileName="potion"; DataTag=Some 16462; ID=373}
    { Name="Glass Bottle"; TileName="glass_bottle"; DataTag=None; ID=374}
    { Name="Spider Eye"; TileName="spider_eye"; DataTag=None; ID=375}
    { Name="Fermented Spider Eye"; TileName="fermented_spider_eye"; DataTag=None; ID=376}
    { Name="Blaze Powder"; TileName="blaze_powder"; DataTag=None; ID=377}
    { Name="Magma Cream"; TileName="magma_cream"; DataTag=None; ID=378}
    { Name="Brewing Stand"; TileName="brewing_stand"; DataTag=None; ID=379}
    { Name="Cauldron"; TileName="cauldron"; DataTag=None; ID=380}
    { Name="Eye of Ender"; TileName="ender_eye"; DataTag=None; ID=381}
    { Name="Glistering Melon"; TileName="speckled_melon"; DataTag=None; ID=382}
    { Name="Spawn Creeper"; TileName="spawn_egg"; DataTag=Some 50; ID=383}
    { Name="Spawn Skeleton"; TileName="spawn_egg"; DataTag=Some 51; ID=383}
    { Name="Spawn Spider"; TileName="spawn_egg"; DataTag=Some 52; ID=383}
    { Name="Spawn Zombie"; TileName="spawn_egg"; DataTag=Some 54; ID=383}
    { Name="Spawn Slime"; TileName="spawn_egg"; DataTag=Some 55; ID=383}
    { Name="Spawn Ghast"; TileName="spawn_egg"; DataTag=Some 56; ID=383}
    { Name="Spawn Zombie Pigman"; TileName="spawn_egg"; DataTag=Some 57; ID=383}
    { Name="Spawn Enderman"; TileName="spawn_egg"; DataTag=Some 58; ID=383}
    { Name="Spawn Cave Spider"; TileName="spawn_egg"; DataTag=Some 59; ID=383}
    { Name="Spawn Silverfish"; TileName="spawn_egg"; DataTag=Some 60; ID=383}
    { Name="Spawn Blaze"; TileName="spawn_egg"; DataTag=Some 61; ID=383}
    { Name="Spawn Magma Cube"; TileName="spawn_egg"; DataTag=Some 62; ID=383}
    { Name="Spawn Bat"; TileName="spawn_egg"; DataTag=Some 65; ID=383}
    { Name="Spawn Witch"; TileName="spawn_egg"; DataTag=Some 66; ID=383}
    { Name="Spawn Endermite"; TileName="spawn_egg"; DataTag=Some 67; ID=383}
    { Name="Spawn Guardian"; TileName="spawn_egg"; DataTag=Some 68; ID=383}
    { Name="Spawn Pig"; TileName="spawn_egg"; DataTag=Some 90; ID=383}
    { Name="Spawn Sheep"; TileName="spawn_egg"; DataTag=Some 91; ID=383}
    { Name="Spawn Cow"; TileName="spawn_egg"; DataTag=Some 92; ID=383}
    { Name="Spawn Chicken"; TileName="spawn_egg"; DataTag=Some 93; ID=383}
    { Name="Spawn Squid"; TileName="spawn_egg"; DataTag=Some 94; ID=383}
    { Name="Spawn Wolf"; TileName="spawn_egg"; DataTag=Some 95; ID=383}
    { Name="Spawn Mooshroom"; TileName="spawn_egg"; DataTag=Some 96; ID=383}
    { Name="Spawn Ocelot"; TileName="spawn_egg"; DataTag=Some 98; ID=383}
    { Name="Spawn Horse"; TileName="spawn_egg"; DataTag=Some 100; ID=383}
    { Name="Spawn Rabbit"; TileName="spawn_egg"; DataTag=Some 101; ID=383}
    { Name="Spawn Villager"; TileName="spawn_egg"; DataTag=Some 120; ID=383}
    { Name="Bottle o'Enchanting"; TileName="experience_bottle"; DataTag=None; ID=384}
    { Name="Fire Charge"; TileName="fire_charge"; DataTag=None; ID=385}
    { Name="Book and Quill"; TileName="writable_book"; DataTag=None; ID=386}
    { Name="Written Book"; TileName="written_book"; DataTag=None; ID=387}
    { Name="Emerald"; TileName="emerald"; DataTag=None; ID=388}
    { Name="Item Frame"; TileName="item_frame"; DataTag=None; ID=389}
    { Name="Flower Pot"; TileName="flower_pot"; DataTag=None; ID=390}
    { Name="Carrot"; TileName="carrot"; DataTag=None; ID=391}
    { Name="Potato"; TileName="potato"; DataTag=None; ID=392}
    { Name="Baked Potato"; TileName="baked_potato"; DataTag=None; ID=393}
    { Name="Poisonous Potato"; TileName="poisonous_potato"; DataTag=None; ID=394}
    { Name="Map"; TileName="map"; DataTag=None; ID=395}
    { Name="Golden Carrot"; TileName="golden_carrot"; DataTag=None; ID=396}
    { Name="Skeleton Skull"; TileName="skull"; DataTag=Some 0; ID=397}
    { Name="Wither Skeleton Skull"; TileName="skull"; DataTag=Some 1; ID=397}
    { Name="Zombie Head"; TileName="skull"; DataTag=Some 2; ID=397}
    { Name="Head"; TileName="skull"; DataTag=Some 3; ID=397}
    { Name="Creeper Head"; TileName="skull"; DataTag=Some 4; ID=397}
    { Name="Carrot on a Stick"; TileName="carrot_on_a_stick"; DataTag=None; ID=398}
    { Name="Nether Star"; TileName="nether_star"; DataTag=None; ID=399}
    { Name="Pumpkin Pie"; TileName="pumpkin_pie"; DataTag=None; ID=400}
    { Name="Firework Rocket"; TileName="fireworks"; DataTag=None; ID=401}
    { Name="Firework Star"; TileName="firework_charge"; DataTag=None; ID=402}
    { Name="Enchanted Book"; TileName="enchanted_book"; DataTag=None; ID=403}
    { Name="Redstone Comparator"; TileName="comparator"; DataTag=None; ID=404}
    { Name="Nether Brick"; TileName="netherbrick"; DataTag=None; ID=405}
    { Name="Nether Quartz"; TileName="quartz"; DataTag=None; ID=406}
    { Name="Minecart with TNT"; TileName="tnt_minecart"; DataTag=None; ID=407}
    { Name="Minecart with Hopper"; TileName="hopper_minecart"; DataTag=None; ID=408}
    { Name="Prismarine Shard"; TileName="prismarine_shard"; DataTag=None; ID=409}
    { Name="Prismarine Crystals"; TileName="prismarine_crystals"; DataTag=None; ID=410}
    { Name="Raw Rabbit"; TileName="rabbit"; DataTag=None; ID=411}
    { Name="Cooked Rabbit"; TileName="cooked_rabbit"; DataTag=None; ID=412}
    { Name="Rabbit Stew"; TileName="rabbit_stew"; DataTag=None; ID=413}
    { Name="Rabbit's Foot"; TileName="rabbit_foot"; DataTag=None; ID=414}
    { Name="Rabbit Hide"; TileName="rabbit_hide"; DataTag=None; ID=415}
    { Name="Armor Stand"; TileName="armor_stand"; DataTag=None; ID=416}
    { Name="Iron Horse Armor"; TileName="iron_horse_armor"; DataTag=None; ID=417}
    { Name="Gold Horse Armor"; TileName="golden_horse_armor"; DataTag=None; ID=418}
    { Name="Diamond Horse Armor"; TileName="diamond_horse_armor"; DataTag=None; ID=419}
    { Name="Lead"; TileName="lead"; DataTag=None; ID=420}
    { Name="Name Tag"; TileName="name_tag"; DataTag=None; ID=421}
    { Name="Minecart with Command Block"; TileName="command_block_minecart"; DataTag=None; ID=422}
    { Name="Raw Mutton"; TileName="mutton"; DataTag=None; ID=423}
    { Name="Cooked Mutton"; TileName="cooked_mutton"; DataTag=None; ID=424}
    { Name="Black Banner"; TileName="banner"; DataTag=Some 0; ID=425}
    { Name="Red Banner"; TileName="banner"; DataTag=Some 1; ID=425}
    { Name="Green Banner"; TileName="banner"; DataTag=Some 2; ID=425}
    { Name="Brown Banner"; TileName="banner"; DataTag=Some 3; ID=425}
    { Name="Blue Banner"; TileName="banner"; DataTag=Some 4; ID=425}
    { Name="Purple Banner"; TileName="banner"; DataTag=Some 5; ID=425}
    { Name="Cyan Banner"; TileName="banner"; DataTag=Some 6; ID=425}
    { Name="Light Gray Banner"; TileName="banner"; DataTag=Some 7; ID=425}
    { Name="Gray Banner"; TileName="banner"; DataTag=Some 8; ID=425}
    { Name="Pink Banner"; TileName="banner"; DataTag=Some 9; ID=425}
    { Name="Lime Banner"; TileName="banner"; DataTag=Some 10; ID=425}
    { Name="Yellow Banner"; TileName="banner"; DataTag=Some 11; ID=425}
    { Name="Light Blue Banner"; TileName="banner"; DataTag=Some 12; ID=425}
    { Name="Magenta Banner"; TileName="banner"; DataTag=Some 13; ID=425}
    { Name="Orange Banner"; TileName="banner"; DataTag=Some 14; ID=425}
    { Name="White Banner"; TileName="banner"; DataTag=Some 15; ID=425}
    { Name="Spruce Door"; TileName="spruce_door"; DataTag=None; ID=427}
    { Name="Birch Door"; TileName="birch_door"; DataTag=None; ID=428}
    { Name="Jungle Door"; TileName="jungle_door"; DataTag=None; ID=429}
    { Name="Acacia Door"; TileName="acacia_door"; DataTag=None; ID=430}
    { Name="Dark Oak Door"; TileName="dark_oak_door"; DataTag=None; ID=431}
    { Name="Chorus Fruit"; TileName="chorus_fruit"; DataTag=None; ID=432}
    { Name="Beetroot"; TileName="beetroot"; DataTag=None; ID=434}
    { Name="Beetroot Seeds"; TileName="beetroot_seeds"; DataTag=None; ID=435}
    { Name="Beetroot Soup"; TileName="beetroot_soup"; DataTag=None; ID=436}
    { Name="Dragon's Breath"; TileName="dragon_breath"; DataTag=None; ID=437}
    { Name="Spectral Arrow"; TileName="spectral_arrow"; DataTag=None; ID=439}
    { Name="Arrow of Night Vision (0:22)"; TileName="tipped_arrow"; DataTag=None; ID=440}
    { Name="Arrow of Weakness (0:11)"; TileName="tipped_arrow"; DataTag=None; ID=440}
    { Name="Lingering Potion of Night Vision (0:45)"; TileName="lingering_potion"; DataTag=None; ID=441}
    { Name="Lingering Potion of Weakness (0:22)"; TileName="lingering_potion"; DataTag=None; ID=441}
    { Name="Shield"; TileName="shield"; DataTag=None; ID=442}
    { Name="Music Disc - 13"; TileName="record_13"; DataTag=None; ID=2256}
    { Name="Music Disc - Cat"; TileName="record_cat"; DataTag=None; ID=2257}
    { Name="Music Disc - Blocks"; TileName="record_blocks"; DataTag=None; ID=2258}
    { Name="Music Disc - Chirp"; TileName="record_chirp"; DataTag=None; ID=2259}
    { Name="Music Disc - Far"; TileName="record_far"; DataTag=None; ID=2260}
    { Name="Music Disc - Mall"; TileName="record_mall"; DataTag=None; ID=2261}
    { Name="Music Disc - Mellohi"; TileName="record_mellohi"; DataTag=None; ID=2262}
    { Name="Music Disc - Stal"; TileName="record_stal"; DataTag=None; ID=2263}
    { Name="Music Disc - Strad"; TileName="record_strad"; DataTag=None; ID=2264}
    { Name="Music Disc - Ward"; TileName="record_ward"; DataTag=None; ID=2265}
    { Name="Music Disc - 11"; TileName="record_11"; DataTag=None; ID=2266}
    { Name="Music Disc - Wait"; TileName="record_wait"; DataTag=None; ID=2267}
|]
*)
