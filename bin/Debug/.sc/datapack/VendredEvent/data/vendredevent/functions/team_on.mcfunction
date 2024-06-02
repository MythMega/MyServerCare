team remove Bleu
team remove Rouge
team remove Vert
team remove Jaune

############

team add Bleu
team modify Bleu color aqua
team join Bleu @r[limit=2,team=!]
#tellraw @a ["",{"text":"@a[team=Bleu] ont rejoint la team "},{"text":"Bleue","color":"dark_aqua"}]

team add Rouge
team modify Rouge color red
team join Rouge @r[limit=2,team=!]
#tellraw @a ["",{"text":"@a[team=Rouge] ont rejoint la team "},{"text":"Rouge","color":"red"}]

team add Vert
team modify Vert color green
team join Vert @r[limit=2,team=!]
#tellraw @a ["",{"text":"@a[team=Vert] ont rejoint la team "},{"text":"Verte","color":"green"}]

team add Jaune
team modify Jaune color gold
team join Jaune @r[limit=2,team=!]
#tellraw @a ["",{"text":"@a[team=Jaune] ont rejoint la team "},{"text":"Jaune","color":"gold"}]

#say Toutes les équipes ont été randomisées ! Voici la liste des joueurs : @a