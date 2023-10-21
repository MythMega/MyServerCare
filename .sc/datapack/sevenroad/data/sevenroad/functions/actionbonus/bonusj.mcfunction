summon horse ~ ~ ~ {Tame:1b,Variant:256,Attributes:[{Name:generic.attack_knockback,Base:1.0},{Name:horse.jump_strength,Base:1.0}],SaddleItem:{id:"minecraft:saddle",Count:1b},ArmorItem:{}}
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"LE ZVAL","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a