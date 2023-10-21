scoreboard players set prevent_wither nohighwaymob -1
tellraw @s ["",{"text":"Wither Skeletons spawning "},{"text":"allowed","color":"dark_green"},{"text":" !"}]
function nohighwaymob:_config