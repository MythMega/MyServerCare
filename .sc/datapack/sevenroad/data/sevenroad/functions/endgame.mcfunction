scoreboard players set sevenroad_isStarted var 0
gamemode adventure @a
spreadplayers 0 0 15 5 true @a
clear @a
tellraw @a ["",{"text":"LA PARTIE EST TERMINÉE.\nELLE AURA DURÉE","color":"gold"},{"text":" ","color":"dark_red"},{"score":{"name":"Hours","objective":"sevenroad"},"color":"gold"},{"text":" heure(s)","color":"dark_red"},{"text":", ","color":"gold"},{"score":{"name":"Hours","objective":"sevenroad"},"color":"gold"},{"text":" minute(s)","color":"dark_green"},{"text":" et ","color":"gold"},{"score":{"name":"Hours","objective":"sevenroad"},"color":"gold"},{"text":" seconde(s)","color":"dark_aqua"},{"text":".","color":"gold"}]