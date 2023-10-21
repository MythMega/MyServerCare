

scoreboard objectives add ch_display dummy
scoreboard objectives add ch_tickstime dummy

#si = 1 timer tourne
scoreboard objectives add ch_startedbool dummy

function chronos:resettimes

scoreboard players set ch_IsStarted ch_startedbool 1
