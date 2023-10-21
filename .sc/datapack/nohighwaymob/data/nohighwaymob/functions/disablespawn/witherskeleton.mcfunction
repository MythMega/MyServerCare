scoreboard players set prevent_wither nohighwaymob 0
tellraw @s ["",{"text":"Wither Skeletons spawning "},{"text":"prevented","color":"dark_red"},{"text":" !"}]
function nohighwaymob:_config