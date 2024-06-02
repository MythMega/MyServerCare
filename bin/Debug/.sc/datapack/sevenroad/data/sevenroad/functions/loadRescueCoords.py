from asyncore import write
import numbers
from random import *
import math

class joueur:
    def __init__(self) -> None:
        self.name = ""
        self.coordX = 0
        self.coordY = 0

    def setName(self, unNom):
        self.name = unNom

    def writeCoords(self):
        print(f"Coordonnées du joueur {self.name} : {self.coordX} / {self.coordY}")




def calcul(x,y):
    distance = math.sqrt(x*x + y*y)
    if distance > 7700 and distance < 8000:
        return True
    else:
        return False

def randomizeCoords(player):
    while not calcul(player.coordX, player.coordY):
        player.coordX = randint(500,7777)
        player.coordY = randint(500,7777)

def randomizePole(player):
    multiplicator = [-1,1]
    player.coordX *= choice(multiplicator)
    player.coordY *= choice(multiplicator)

def writeOnMcfunction(lineA, filename):
    sourceFile = open(filename, 'a')
    print(lineA, file=sourceFile)
    sourceFile.close()


#####partie prog
NUMBER_OF_PLAYERS = 1200 
FILENAME = "newspawn.mcfunction"
liste_de_joueur = []
for i in range(NUMBER_OF_PLAYERS):
    liste_de_joueur.append(joueur())
count = 0
for player in liste_de_joueur:
    randomizeCoords(player)
    randomizePole(player)
    ligne = f"execute if score sevenroad_cycle1200 var matches {count} run tp @s {player.coordX} 500 {player.coordY}"
    writeOnMcfunction(ligne, FILENAME)
    count += 1


