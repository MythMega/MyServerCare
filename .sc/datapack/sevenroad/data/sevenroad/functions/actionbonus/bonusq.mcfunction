give @s minecraft:torch 128
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Torcheur expert","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a