give @s minecraft:ladder 32
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"The Escalator 1.0","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a
