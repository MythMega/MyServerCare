tellraw @a ["",{"text":"EQUILIBRAGE ","bold":true},{"text":": on a aidé le "},{"text":"dernier","color":"red"},{"text":" (","color":"gold"},{"selector":"@a[tag=last]","color":"gold"},{"text":")","color":"gold"},{"text":" et embété le "},{"text":"premier","color":"dark_green"},{"text":" (","color":"gold"},{"selector":"@a[tag=first]","color":"gold"},{"text":")","color":"gold"}]

execute as @a[tag=last] at @s if score sevenroad_rng7 var matches 1 run function sevenroad:actionbonus/bonusa
execute as @a[tag=last] at @s if score sevenroad_rng7 var matches 2 run function sevenroad:actionbonus/bonusb
execute as @a[tag=last] at @s if score sevenroad_rng7 var matches 3 run function sevenroad:actionbonus/bonusc
execute as @a[tag=last] at @s if score sevenroad_rng7 var matches 4 run function sevenroad:actionbonus/bonusd
execute as @a[tag=last] at @s if score sevenroad_rng7 var matches 5 run function sevenroad:actionbonus/bonuse
execute as @a[tag=last] at @s if score sevenroad_rng7 var matches 6 run function sevenroad:actionbonus/bonusf
execute as @a[tag=last] at @s if score sevenroad_rng7 var matches 7 run function sevenroad:actionbonus/bonusg
execute as @a[tag=last] at @s if score sevenroad_rng7 var matches 8 run function sevenroad:actionbonus/bonush
execute as @a[tag=last] at @s if score sevenroad_rng7 var matches 9 run function sevenroad:actionbonus/bonusi


execute as @a[tag=first] at @s if score sevenroad_rng7 var matches 1 run function sevenroad:actionmalus/malusa
execute as @a[tag=first] at @s if score sevenroad_rng7 var matches 2 run function sevenroad:actionmalus/malusb
execute as @a[tag=first] at @s if score sevenroad_rng7 var matches 3 run function sevenroad:actionmalus/malusc
execute as @a[tag=first] at @s if score sevenroad_rng7 var matches 4 run function sevenroad:actionmalus/malusd
execute as @a[tag=first] at @s if score sevenroad_rng7 var matches 5 run function sevenroad:actionmalus/maluse
execute as @a[tag=first] at @s if score sevenroad_rng7 var matches 6 run function sevenroad:actionmalus/malusf
execute as @a[tag=first] at @s if score sevenroad_rng7 var matches 7 run function sevenroad:actionmalus/malusg
execute as @a[tag=first] at @s if score sevenroad_rng7 var matches 7 run function sevenroad:actionmalus/malush
execute as @a[tag=first] at @s if score sevenroad_rng7 var matches 7 run function sevenroad:actionmalus/malusi