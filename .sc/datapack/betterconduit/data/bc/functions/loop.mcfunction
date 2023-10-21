### creation conduit
scoreboard players set @a can_spawn_conduit 1
execute as @e[type=marker,tag=bc] at @s run scoreboard players set @a[distance=0..6] can_spawn_conduit 0

execute as @a[scores={can_spawn_conduit=1}] at @s anchored eyes if block ^ ^ ^1 minecraft:conduit run function bc:create_conduit
execute as @a[scores={can_spawn_conduit=1}] at @s anchored eyes if block ^ ^ ^1.5 minecraft:conduit run function bc:create_conduit
execute as @a[scores={can_spawn_conduit=1}] at @s if block ~ ~-1 ~ minecraft:conduit run function bc:create_conduit


#suppression conduit
execute as @a[scores={mine_conduit=1}] at @s run function bc:delete_conduit

#effet conduit
execute as @e[type=minecraft:marker,tag=bc] at @s run tp @e[type=minecraft:drowned,distance=0..96] ~ -1000 ~