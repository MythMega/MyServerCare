scoreboard players set prevent_piglin nohighwaymob -1
tellraw @s ["",{"text":"Piglin spawning "},{"text":"allowed","color":"dark_green"},{"text":" !"}]
function nohighwaymob:_config