give @s minecraft:chorus_fruit 16
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Fruit multifonctions","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a
