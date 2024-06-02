scoreboard players set prevent_piglin nohighwaymob 0
tellraw @s ["",{"text":"Piglin spawning "},{"text":"prevented","color":"dark_red"},{"text":" !"}]
function nohighwaymob:_config