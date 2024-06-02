give @s shears{display:{Name:'{"text":"Soufleur de feuille"}'},Unbreakable:1b} 3
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Souffleur de feuille","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a