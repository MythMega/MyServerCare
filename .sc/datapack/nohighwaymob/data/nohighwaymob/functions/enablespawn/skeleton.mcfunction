scoreboard players set prevent_skeleton nohighwaymob -1
tellraw @s ["",{"text":"Skeletons spawning "},{"text":"allowed","color":"dark_green"},{"text":" !"}]
function nohighwaymob:_config