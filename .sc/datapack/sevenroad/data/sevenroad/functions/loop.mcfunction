#items
item replace entity @a[tag=!noCompass] hotbar.8 with compass{LodestoneDimension:"minecraft:overworld",LodestoneTracked:0b,LodestonePos:{X:0,Y:0,Z:0}} 1

#nerf des slimes
execute as @e[type=minecraft:slime,tag=!modif,limit=1] run function sevenroad:slimenerf


execute if score sevenroad_isStarted var matches 0 run gamemode adventure @a[team=!admin]
execute if score sevenroad_isStarted var matches 0 run time set 0
execute if score sevenroad_isStarted var matches 0 run difficulty peaceful

execute if score sevenroad_isStarted var matches 0 run team join waiting @a[team=!admin]


execute if score sevenroad_isStarted var matches 1 run function sevenroad:gameloop


execute as @e[type=minecraft:boat] run schedule function sevenroad:killme 30s


scoreboard players set sevenroad_playerfinished var 0
scoreboard players set sevenroad_totalplayer var 0

execute as @a[team=7r_finito] run scoreboard players add sevenroad_playerfinished var 1
execute as @a run scoreboard players add sevenroad_totalplayer var 1

execute if score sevenroad_totalplayer var = sevenroad_playerfinished var run function sevenroad:endgame

function sevenroad:plants
scoreboard players set @a 7r_sneaked 0