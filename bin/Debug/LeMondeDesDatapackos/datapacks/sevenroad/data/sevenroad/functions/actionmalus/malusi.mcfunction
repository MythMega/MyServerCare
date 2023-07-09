fill ~-2 ~-2 ~-2 ~2 ~2 ~2 minecraft:cobbled_deepslate
fill ~ ~-1 ~ ~ ~1 ~ air
fill ~ ~ ~ ~ ~ ~ minecraft:torch
effect give @s minecraft:resistance 30 5 true
fill ~1 0 ~1 ~ ~-2 ~ tnt[unstable=true]
fill ~ -2 ~ ~ -2 ~ minecraft:redstone_block
fill ~ -1 ~ ~ -1 ~ minecraft:tnt
summon creeper ~ ~ ~ {Fuse:5,ignited:1b}
tellraw @a ["",{"selector":"@s"},{"text":" à eu le malus "},{"text":"Sol instable","color":"dark_red"},{"text":" !"}]