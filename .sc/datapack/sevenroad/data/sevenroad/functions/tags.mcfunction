#tag first and last

tag @a[team=!7r_finito] remove first
tag @a[team=!7r_finito] remove last
execute in minecraft:overworld positioned 0 0 0 run tag @a[limit=1,sort=furthest,team=!7r_finito] add last
execute in minecraft:overworld positioned 0 0 0 run tag @a[limit=1,sort=nearest,team=!7r_finito] add first

execute in minecraft:overworld positioned 0 0 0 run tag @a[distance=0..] add overworld
execute in minecraft:overworld positioned 0 0 0 run tag @a[distance=0..] remove nether
execute in minecraft:overworld positioned 0 0 0 run tag @a[distance=0..] remove end

execute in minecraft:the_nether positioned 0 0 0 run tag @a[distance=0..] remove overworld
execute in minecraft:the_nether positioned 0 0 0 run tag @a[distance=0..] add nether
execute in minecraft:the_nether positioned 0 0 0 run tag @a[distance=0..] remove end

execute in minecraft:the_end positioned 0 0 0 run tag @a[distance=0..] remove overworld
execute in minecraft:the_end positioned 0 0 0 run tag @a[distance=0..] remove nether
execute in minecraft:the_end positioned 0 0 0 run tag @a[distance=0..] add end




execute as @a[scores={7r_rc_death=..0}] run tag @s add unfinished
execute as @a[scores={7r_brk_blackstone=..0}] run tag @s add unfinished
execute as @a[scores={7r_brk_stone=..0}] run tag @s add unfinished
execute as @a[scores={7r_brk_netherrack=..0}] run tag @s add unfinished
execute as @a[scores={7r_rc_villager=..0}] run tag @s add unfinished
execute as @a[scores={7r_rc_breeds=..0}] run tag @s add unfinished
execute as @a[scores={7r_use_fishingrods=..0}] run tag @s add unfinished
execute as @a[scores={7r_cft_ironhoe=..0}] run tag @s add unfinished
execute as @a[scores={7r_rc_death=0..,7r_brk_blackstone=0..,7r_brk_stone=0..,7r_brk_netherrack=0..,7r_rc_villager=0..,7r_rc_breeds=0..,7r_cft_ironhoe=0..,7r_use_fishingrods=0..}] remove unfinished