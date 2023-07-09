give @s bowl 3
give @s minecraft:brown_mushroom 16
give @s minecraft:red_mushroom 16
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Le souper est prêt","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a
