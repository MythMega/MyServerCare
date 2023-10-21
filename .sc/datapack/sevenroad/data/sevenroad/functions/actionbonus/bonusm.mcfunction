give @s enchanted_golden_apple 1
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Cadeau de notch","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a