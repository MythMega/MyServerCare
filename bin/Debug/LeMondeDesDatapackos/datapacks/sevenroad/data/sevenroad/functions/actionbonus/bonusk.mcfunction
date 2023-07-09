summon parrot ~ ~ ~ {Invulnerable:1b,Sitting:1b}
give @s minecraft:wheat_seeds 64
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"La classe moussaillon","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a