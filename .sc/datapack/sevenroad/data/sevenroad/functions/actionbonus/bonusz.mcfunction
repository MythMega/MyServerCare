effect give @s minecraft:strength 240 4 true
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Incroyable Hulk","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a
