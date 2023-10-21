give @s minecraft:poppy
tellraw @a ["",{"selector":"@s"},{"text":" à eu le malus, non en fait "},{"text":"on lui a donné une fleur","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a
