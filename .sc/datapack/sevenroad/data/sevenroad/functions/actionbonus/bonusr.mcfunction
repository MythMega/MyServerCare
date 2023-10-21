give @s minecraft:shield
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Défenseur hors pairs","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a