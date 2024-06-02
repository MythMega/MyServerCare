give @s minecraft:crying_obsidian 24
give @s minecraft:honey_block 4
give @s minecraft:observer 2
give @s minecraft:sticky_piston 2
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Kit machine volante","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a