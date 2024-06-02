scoreboard players set prevent_hoglin nohighwaymob -1
tellraw @s ["",{"text":"Hoglin spawning "},{"text":"allowed","color":"dark_green"},{"text":" !"}]
function nohighwaymob:_config