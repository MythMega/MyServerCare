effect give @s minecraft:hero_of_the_village 120 4 true
effect give @s minecraft:luck 120 4 true
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Mauvais karma","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a