give @s minecraft:leather_boots{Enchantments:[{id:"minecraft:frost_walker",lvl:3s}]} 1
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Bottes de Jesus","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a