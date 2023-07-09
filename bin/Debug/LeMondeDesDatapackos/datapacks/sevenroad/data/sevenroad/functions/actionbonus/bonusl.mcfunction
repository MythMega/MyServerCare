give @s milk_bucket 1
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Sauve toi","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a