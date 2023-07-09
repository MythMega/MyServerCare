execute in minecraft:overworld positioned 0 128 0 run execute as @a[distance=0..] at @s if block ~ ~-1 ~ #minecraft:valid_spawn run spawnpoint @s
execute in minecraft:overworld positioned 0 128 0 run execute as @a[distance=0..] at @s if block ~ ~-1 ~ #minecraft:valid_spawn run tellraw @a {"text":"-checkpoint-"}
give @a[team=!7r_finito] minecraft:emerald
execute as @a[x_rotation=-90..-20] run scoreboard players add sevenroad_rnggood var 1
execute as @a[x_rotation=20..90] run scoreboard players add sevenroad_rngbad var 1
execute as @a at @s if block ~ ~-1 ~ minecraft:grass_block run scoreboard players add sevenroad_rnggood var 1
execute as @a at @s if block ~ ~-1 ~ minecraft:sand run scoreboard players add sevenroad_rngbad var 1