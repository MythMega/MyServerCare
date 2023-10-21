fill ~-5 1 ~-5 ~5 20 ~5 minecraft:cobblestone
fill ~-4 2 ~-4 ~4 19 ~4 minecraft:air
tp @s ~ 10 ~
give @s iron_pickaxe{Enchantments:[{id:"minecraft:efficiency",lvl:10s}]} 1
tellraw @a ["",{"selector":"@s"},{"text":" à eu le malus "},{"text":"Dig Down","color":"dark_red"},{"text":" !"}]