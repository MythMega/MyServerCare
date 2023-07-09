#valueAdder
execute if score sevenroad_isStarted var matches 1 run scoreboard players add sevenroad_tick var 1

### TEAM BOOST 
execute as @a at @s run effect give @a[distance=1..20] speed 1 1 true
execute as @a at @s run effect give @a[distance=1..20] glowing 1 1 true


# kill boat is DEFINITIVE
kill @e[type=item,nbt={Item:{id:"minecraft:oak_boat",Count:1b}}]
kill @e[type=item,nbt={Item:{id:"minecraft:birch_boat",Count:1b}}]
kill @e[type=item,nbt={Item:{id:"minecraft:acacia_boat",Count:1b}}]
kill @e[type=item,nbt={Item:{id:"minecraft:jungle_boat",Count:1b}}]
kill @e[type=item,nbt={Item:{id:"minecraft:spruce_boat",Count:1b}}]
kill @e[type=item,nbt={Item:{id:"minecraft:dark_oak_boat",Count:1b}}]

#bed obstructed
execute positioned 1000000 500 0 as @a[distance=0..2000] run function sevenroad:newspawn

#gamemode, difficulty and time
execute if score sevenroad_isStarted var matches 1 run gamemode survival @a[team=!7r_finito]
execute if score sevenroad_isStarted var matches 1 run gamemode spectator @a[team=7r_finito]
execute if score sevenroad_isStarted var matches 1 run time add 1
execute if score sevenroad_isStarted var matches 1 run difficulty easy


####placement displayer
title @a actionbar ["",{"text":"First ","color":"dark_green"},{"text":": "},{"selector":"@a[tag=first]","bold":true,"color":"gold"},{"text":" \u0020 Last ","color":"dark_red"},{"text":": "},{"selector":"@a[tag=last]","bold":true,"color":"gold"}]

#achievements
execute if score sevenroad_isStarted var matches 1 run execute positioned -5 0 -5 run advancement grant @a[dx=11,dz=11,dy=400] only sevenroad:finito
execute if score sevenroad_isStarted var matches 1 run execute positioned 0 192 0 run advancement grant @a[distance=0..5000] only sevenroad:5000
execute if score sevenroad_isStarted var matches 1 run execute positioned 0 192 0 run advancement grant @a[distance=0..2500] only sevenroad:2500
execute if score sevenroad_isStarted var matches 1 run execute positioned 0 192 0 run advancement grant @a[distance=0..1000] only sevenroad:1000
execute if score sevenroad_isStarted var matches 1 run execute positioned 0 192 0 run advancement grant @a[distance=0..300] only sevenroad:300

#advance boat state each second
execute if score sevenroad_tick var matches 20 run function sevenroad:boatnerf

#xp booster
execute if score sevenroad_tick var matches 20 run xp add @a 1 points

####chrono
execute if score sevenroad_tick var matches 20 run scoreboard players add Seconds sevenroad 1
execute if score sevenroad_tick var matches 20 run scoreboard players remove sevenroad_tick var 20
execute if score Seconds sevenroad matches 60 run scoreboard players add Minutes sevenroad 1
execute if score Seconds sevenroad matches 60 run scoreboard players remove Seconds sevenroad 60
execute if score Minutes sevenroad matches 60 run scoreboard players add Hours sevenroad 1
execute if score Minutes sevenroad matches 60 run scoreboard players remove Minutes sevenroad 60
execute if score Hours sevenroad matches 24 run scoreboard players add Days sevenroad 1
execute if score Hours sevenroad matches 24 run scoreboard players remove Hours sevenroad 24
execute if score Minutes Days matches 365 run scoreboard players add Years sevenroad 1
execute if score Minutes Days matches 365 run scoreboard players remove Days sevenroad 365

# ROULEMENT DE LA RNG de base
scoreboard players add sevenroad_rng7 var 1
execute if score sevenroad_rng7 var matches 8 run scoreboard players set sevenroad_rng7 var 1

# --------------------------------ONLY FOR DEBUG-
#scoreboard players set sevenroad_rng7 var 2


# ROULEMENT DE LA RNG DES BONUS MALUS
scoreboard players add sevenroad_rnggood var 1
scoreboard players add sevenroad_rngbad var 1
execute if score sevenroad_rnggood var matches 30.. run scoreboard players remove sevenroad_rnggood var 29
execute if score sevenroad_rngbad var matches 30.. run scoreboard players remove sevenroad_rngbad var 29


#### ROULEMENTS DES CYCLES 
execute if score sevenroad_isStarted var matches 1 run scoreboard players add sevenroad_cycle1200 var 1
execute if score sevenroad_isStarted var matches 1 run scoreboard players add sevenroad_cycle3600 var 1
execute if score sevenroad_isStarted var matches 1 if score sevenroard_oneplayerfinished var matches 1 run scoreboard players add sevenroad_cycle3600 var 1


#action cycle court 60 secondes
execute if score sevenroad_cycle1200 var matches 1200 run function sevenroad:shortaction
#action2: execute if score sevenroad_cycle1200 var matches 1200 run ??????????????
execute if score sevenroad_cycle1200 var matches 1200 run scoreboard players set sevenroad_cycle1200 var 0

#action cycle long 180 secondes
execute if score sevenroad_cycle3600 var matches 3600..3601 run function sevenroad:longbonus
execute if score sevenroad_cycle3600 var matches 3600..3601 run function sevenroad:longmalus
#action2: execute if score sevenroad_cycle3600 var matches 1200 run ??????????????
execute if score sevenroad_cycle3600 var matches 3600.. run scoreboard players set sevenroad_cycle3600 var 1


#TAGS
execute positioned 0 100 0 run function sevenroad:tags


#### REBALANCE
execute if score Minutes sevenroad matches 10 if score Seconds sevenroad matches 10 if score sevenroad_tick var matches 1 run function sevenroad:balance
execute if score Minutes sevenroad matches 20 if score Seconds sevenroad matches 10 if score sevenroad_tick var matches 1 run function sevenroad:balance
execute if score Minutes sevenroad matches 25 if score Seconds sevenroad matches 10 if score sevenroad_tick var matches 1 run function sevenroad:balance
execute if score Minutes sevenroad matches 30 if score Seconds sevenroad matches 10 if score sevenroad_tick var matches 1 run function sevenroad:balance
execute if score Minutes sevenroad matches 35 if score Seconds sevenroad matches 10 if score sevenroad_tick var matches 1 run function sevenroad:balance
execute if score Minutes sevenroad matches 40 if score Seconds sevenroad matches 10 if score sevenroad_tick var matches 1 run function sevenroad:balance
execute if score Minutes sevenroad matches 45 if score Seconds sevenroad matches 10 if score sevenroad_tick var matches 1 run function sevenroad:balance
execute if score Minutes sevenroad matches 50 if score Seconds sevenroad matches 10 if score sevenroad_tick var matches 1 run function sevenroad:balance
execute if score Minutes sevenroad matches 55 if score Seconds sevenroad matches 10 if score sevenroad_tick var matches 1 run function sevenroad:balance
