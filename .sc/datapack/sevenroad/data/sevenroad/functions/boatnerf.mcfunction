execute at @e[type=minecraft:parrot] run execute as @e[type=minecraft:boat,distance=0..5,tag=25] at @s if score sevenroad_rng7 var matches 0..4 run function sevenroad:parrotsaveboat 
tag @e[type=boat,tag=29] add 30
tag @e[type=boat,tag=28] add 29
tag @e[type=boat,tag=27] add 28
tag @e[type=boat,tag=26] add 27
tag @e[type=boat,tag=25] add 26
tag @e[type=boat,tag=24] add 25
tag @e[type=boat,tag=23] add 24
tag @e[type=boat,tag=22] add 23
tag @e[type=boat,tag=21] add 22
tag @e[type=boat,tag=21] remove 20
tag @e[type=boat,tag=20] add 21
tag @e[type=boat,tag=19] add 20
tag @e[type=boat,tag=18] add 19
tag @e[type=boat,tag=17] add 18
tag @e[type=boat,tag=16] add 17
tag @e[type=boat,tag=15] add 16
tag @e[type=boat,tag=14] add 15
tag @e[type=boat,tag=13] add 14
tag @e[type=boat,tag=12] add 13
tag @e[type=boat,tag=11] add 12
tag @e[type=boat,tag=10] add 11
tag @e[type=boat,tag=9] add 10
tag @e[type=boat,tag=8] add 9
tag @e[type=boat,tag=7] add 8
tag @e[type=boat,tag=6] add 7
tag @e[type=boat,tag=5] add 6
tag @e[type=boat,tag=4] add 5
tag @e[type=boat,tag=3] add 4
tag @e[type=boat,tag=2] add 3
tag @e[type=boat,tag=1] add 2
tag @e[type=boat] add 1

execute at @e[type=minecraft:parrot] run execute as @e[type=minecraft:boat,distance=0..5,tag=25] at @s if score sevenroad_rng7 var matches 0..4 run function sevenroad:parrotsaveboat 

execute at @e[type=boat,tag=20,tag=!21] run tellraw @a[distance=0..2] {"text":"-Le bateau prend l'eau-","color":"gray"}
kill @e[type=boat,tag=30]