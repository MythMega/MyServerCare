summon cow ~ ~ ~ {Glowing:1b,CustomNameVisible:1b,AbsorptionAmount:8f,CustomName:'{"text":"PINATA","color":"gold","bold":true}',ArmorItems:[{},{},{id:"minecraft:beef",Count:32b},{}],ArmorDropChances:[0.085F,0.085F,1.000F,0.085F]}
tellraw @a ["",{"selector":"@s"},{"text":" à eu le bonus "},{"text":"Pinata","color":"dark_green"},{"text":" !"}]
execute at @a as @a run playsound minecraft:block.bell.use master @a