execute at @e[type=item,nbt={Item:{id:"minecraft:shroomlight",Count:1b}}] run execute as @e[type=minecraft:armor_stand,distance=0..1] at @s run function antibattotem:transform
execute as @e[type=minecraft:armor_stand,tag=preventbat] at @s run tp @e[type=minecraft:bat,distance=0..128] ~ -512 ~