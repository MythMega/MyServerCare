effect give @s minecraft:speed 30 2 true
effect give @s minecraft:dolphins_grace 30 0 true
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"SPEED 3 (30s)","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a