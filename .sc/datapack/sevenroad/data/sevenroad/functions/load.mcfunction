scoreboard objectives add sevenroad dummy "7 ROADS"
scoreboard objectives add var dummy
scoreboard players set sevenroad_tick var 0
scoreboard players set sevenroad_cycle1200 var 0
scoreboard players set sevenroad_cycle3600 var 0
scoreboard players set sevenroad_rng7 var 1
scoreboard players set sevenroad_rnggood var 1
scoreboard players set sevenroad_rngbad var 1
scoreboard players set sevenroard_oneplayerfinished var 0
scoreboard players set ---------- sevenroad 9999
scoreboard players set sevenroad_isStarted var 0
function sevenroad:panel
scoreboard objectives setdisplay sidebar sevenroad
team add 7r_finito
team add 7r_waiting
team modify 7r_waiting collisionRule never 
team modify 7r_waiting friendlyFire false
team modify 7r_finito collisionRule never 
team modify 7r_finito friendlyFire false
function sevenroad:teaminit


#stats
scoreboard objectives add 7r_deathcount deathCount
scoreboard objectives add 7r_runned minecraft.custom:minecraft.jump
scoreboard objectives add 7r_health health
scoreboard objectives setdisplay list 7r_health


#pour meca
scoreboard objectives add 7r_sneaked minecraft.custom:minecraft.sneak_time

#pour events

scoreboard objectives add 7r_brk_netherrack minecraft.mined:minecraft.netherrack
scoreboard objectives add 7r_use_fishingrods minecraft.custom:minecraft.fish_caught
scoreboard objectives add 7r_brk_blackstone minecraft.mined:minecraft.deepslate
scoreboard objectives add 7r_brk_stone minecraft.mined:minecraft.stone
scoreboard objectives add 7r_rc_villager minecraft.custom:minecraft.talked_to_villager
scoreboard objectives add 7r_rc_breeds minecraft.custom:minecraft.animals_bred
scoreboard objectives add 7r_rc_death deathCount
scoreboard objectives add 7r_cft_ironhoe minecraft.crafted:minecraft.iron_hoe
