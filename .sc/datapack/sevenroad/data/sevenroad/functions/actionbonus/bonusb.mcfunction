give @s minecraft:ender_pearl 6
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"6 Enderpearl","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a