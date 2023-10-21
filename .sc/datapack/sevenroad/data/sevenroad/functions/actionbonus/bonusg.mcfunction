give @s minecraft:cobblestone 24
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Des Blocs !","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a