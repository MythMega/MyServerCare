title @a actionbar ["",{"text":"time : ","bold":true,"color":"white"},{"score":{"name":"ch_minutes","objective":"ch_display"},"bold":true,"color":"dark_red"},{"text":" minutes & ","bold":true,"color":"white"},{"score":{"name":"ch_seconds","objective":"ch_display"},"bold":true,"color":"dark_red"},{"text":" seconds !","bold":true,"color":"white"}]

execute if score ch_tick ch_tickstime matches 20 run function chronos:add_sec
execute if score ch_seconds ch_display matches 60 run function chronos:add_min
scoreboard players add ch_tick ch_tickstime 1
