tellraw @s {"text":"-----------------"}

execute if score sevenroad_rng7 var matches 1 run function sevenroad:quests/quest_0
execute if score sevenroad_rng7 var matches 2 run function sevenroad:quests/quest_1
execute if score sevenroad_rng7 var matches 3 run function sevenroad:quests/quest_2
execute if score sevenroad_rng7 var matches 4 run function sevenroad:quests/quest_3
execute if score sevenroad_rng7 var matches 5 run function sevenroad:quests/quest_4
execute if score sevenroad_rng7 var matches 6 run function sevenroad:quests/quest_5
execute if score sevenroad_rng7 var matches 7 run function sevenroad:quests/quest_6
execute if score sevenroad_rng7 var matches 7 run function sevenroad:quests/quest_7

tellraw @s {"text":"-----------------"}

tag @s add event