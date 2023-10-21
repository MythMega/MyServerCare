give @s minecraft:golden_pickaxe{Enchantments:[{id:"minecraft:efficiency",lvl:5s}]} 1
give @s minecraft:golden_shovel{Enchantments:[{id:"minecraft:efficiency",lvl:5s}]} 1
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Stuff de mineur","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a