effect give @s minecraft:fire_resistance 1200 2 true
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Insensibilité au feu","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a
