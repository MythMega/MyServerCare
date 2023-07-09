scoreboard players set prevent_skeleton nohighwaymob 0
tellraw @s ["",{"text":"Skeletons spawning "},{"text":"prevented","color":"dark_red"},{"text":" !"}]
function nohighwaymob:_config