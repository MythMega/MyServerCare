fill ~-3 ~-1 ~-3 ~3 ~1 ~3 minecraft:cobweb replace minecraft:air
give @s wooden_sword{Enchantments:[{}]} 1
tellraw @a ["",{"selector":"@s"},{"text":" à eu le malus "},{"text":"Arachnophile","color":"dark_red"},{"text":" !"}]