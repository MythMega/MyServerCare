execute as @a[nbt={SelectedItem:{tag:{Enchantments:[{id:"minecraft:power"}]}}}] at @s run tag @e[type=minecraft:arrow,distance=0..2] add powerarrow
execute as @a[nbt={SelectedItem:{tag:{Enchantments:[{id:"minecraft:punch"}]}}}] at @s run tag @e[type=minecraft:arrow,distance=0..2] add puncharrow
execute as @a[nbt={SelectedItem:{tag:{Enchantments:[{id:"minecraft:flame"}]}}}] at @s run tag @e[type=minecraft:arrow,distance=0..2] add flamearrow

execute as @e[tag=powerarrow] at @s if block ~ ~-0.1 ~ air run particle minecraft:enchanted_hit ~ ~ ~ 0.1 0.1 0.1 0 3 force
execute as @e[tag=puncharrow] at @s if block ~ ~-0.1 ~ air run particle minecraft:smoke ~ ~ ~ 0.1 0.1 0.1 0 2 force
execute as @e[tag=flamearrow] at @s if block ~ ~-0.1 ~ air run particle minecraft:flame ~ ~ ~ 0.1 0.1 0.1 0 2 force
