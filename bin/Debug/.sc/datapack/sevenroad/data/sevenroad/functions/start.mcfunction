execute positioned 0 0 0 run function sevenroad:tpall
advancement revoke @a from sevenroad:root
scoreboard players set sevenroad_isStarted var 1
gamemode survival @a
setworldspawn 1000000 500 0
scoreboard players set sevenroad_oneplayerfinished var 0
fill 0 0 0 0 255 0 minecraft:glowstone
scoreboard players set Seconds sevenroad 0
scoreboard players set Minutes sevenroad 0
scoreboard players set Hours sevenroad 0
team leave @a
gamerule fallDamage false
gamerule reducedDebugInfo true
clear @s
xp set @a 0 points
xp set @a 0 levels



scoreboard players set @a 7r_brk_blackstone 0
scoreboard players set @a 7r_brk_netherrack 0
scoreboard players set @a 7r_use_fishingrods 0
scoreboard players set @a 7r_brk_stone 0
scoreboard players set @a 7r_rc_villager 0
scoreboard players set @a 7r_rc_breeds 0
scoreboard players set @a 7r_rc_death 0
scoreboard players set @a 7r_cft_ironhoe 0