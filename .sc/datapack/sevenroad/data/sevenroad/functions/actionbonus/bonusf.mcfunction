give @s minecraft:cooked_beef 12
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"FULL BOUFFE","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a