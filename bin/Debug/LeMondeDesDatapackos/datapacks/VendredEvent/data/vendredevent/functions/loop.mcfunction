execute as @e run data modify entity @s NoAI set value 1
time set 6000
weather clear

fill 16 64 -2 16 62 -2 minecraft:birch_wall_sign[facing=west]

data merge block 16 64 -2 {Text1:'{"text":"VendredEvent","clickEvent":{"action":"run_command","value":"function vendredevent:team_2"},"obfuscated":true,"color":"yellow"}',Text2:'{"text":"Team de 2","bold":true,"color":"black"}',Text3:'{"text":"VendredEvent","obfuscated":true,"color":"yellow"}'}

data merge block 16 63 -2 {Text1:'{"text":"VendredEvent","clickEvent":{"action":"run_command","value":"function vendredevent:team_leave_all"},"obfuscated":true,"color":"dark_red"}',Text2:'{"text":"Aucune Team","bold":true,"color":"black"}',Text3:'{"text":"VendredEvent","obfuscated":true,"color":"dark_red"}'}

data merge block 16 62 -2 {Text1:'{"text":"VendredEvent","clickEvent":{"action":"run_command","value":"function vendredevent:team_3"},"obfuscated":true,"color":"yellow"}',Text2:'{"text":"Team de 3","bold":true,"color":"black"}',Text3:'{"text":"VendredEvent","obfuscated":true,"color":"yellow"}'}


item replace entity @a hotbar.0 with written_book{pages:['["",{"text":"Cliquez sur les élements suivant pour vous les gives. Vous pouvez vous give :\\n\\n- "},{"text":"un lot de bannière","underlined":true,"clickEvent":{"action":"run_command","value":"/function a:banners"}},{"text":"\\n\\n- ","color":"reset"},{"text":"un lot d\'items utile","underlined":true,"clickEvent":{"action":"run_command","value":"/function a:blocks"}},{"text":"\\n\\n- ","color":"reset"},{"text":"Livre de vote","underlined":true,"clickEvent":{"action":"run_command","value":"/function vendredevent:books"}}]','["",{"text":"- "},{"text":"Armor Stand (avant)","underlined":true,"clickEvent":{"action":"run_command","value":"/function a:stand_devant"}},{"text":"\\n\\n- ","color":"reset"},{"text":"Armor Stand (arrière)","underlined":true,"clickEvent":{"action":"run_command","value":"/function a:stand_derriere"}},{"text":"\\n\\n- ","color":"reset"},{"text":"Armor Stand (droite)","underlined":true,"clickEvent":{"action":"run_command","value":"/function a:stand_droite"}},{"text":"\\n\\n- ","color":"reset"},{"text":"Armor Stand (gauche)","underlined":true,"clickEvent":{"action":"run_command","value":"/function a:stand_gauche"}},{"text":"\\n\\n- ","color":"reset"},{"text":"Kill entité autour","underlined":true,"clickEvent":{"action":"run_command","value":"/kill @e[type=!minecraft:player,distance=0..16]"}}]'],title:VendredEvent,author:MythMega,display:{Lore:["Vous permet de faire certaines actions."]}}


item replace entity MythMega hotbar.8 with written_book{pages:['["",{"text":"Utilities Book\\n\\n"},{"text":"- start timer to zero","clickEvent":{"action":"run_command","value":"/function chronos:start"}},{"text":"\\n\\n"},{"text":"- pause timer","clickEvent":{"action":"run_command","value":"/function chronos:pause"}},{"text":"\\n\\n"},{"text":"- Stop timer","clickEvent":{"action":"run_command","value":"/function chronos:stop"}},{"text":"\\n\\n"},{"text":"- Clear All and say stop","clickEvent":{"action":"run_command","value":"/function vendredevent:force_end"}},{"text":"\\n\\n"},{"text":"- tp back to spawn","clickEvent":{"action":"run_command","value":"/tp @a 0 56 0 90 0"}},{"text":"\\n "}]','["",{"text":"- Il reste 5 minutes","clickEvent":{"action":"run_command","value":"/title @a title \\"Il reste 5 minutes\\""}},{"text":"\\n\\n"},{"text":"- Il reste 10 minutes","clickEvent":{"action":"run_command","value":"/title @a title \\"Il reste 10 minutes\\""}},{"text":"\\n\\n "}]'],title:"Admin Books",author:MythMega,display:{Lore:["Livre ne servant qu'aux admins"]}}

fill 16 63 0 16 63 0 minecraft:birch_wall_sign[facing=west]

data merge block 16 63 0 {Text1:'{"text":"--------------------","clickEvent":{"action":"run_command","value":"function vendredevent:team_2"},"bold":true,"color":"dark_blue"}',Text2:'{"text":"VENDRED\'EVENT","bold":true,"color":"dark_aqua"}',Text3:'{"text":"PAR MYTHMEGA","bold":true,"color":"dark_aqua"}',Text4:'{"text":"--------------------","bold":true,"color":"dark_blue"}'}




fill 16 64 2 16 62 2 minecraft:birch_wall_sign[facing=west]
