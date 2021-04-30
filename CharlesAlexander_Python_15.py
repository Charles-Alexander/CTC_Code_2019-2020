# Charles_Alexander_Python Project  
import random

#these are the variables for the players and the pot
player1 = 0
player2 = 0
pot = 0
player1_turn = True
player2_turn = True
game = True

print ("this is player ones score rn: " + str(player1))
print ("this is player twos score rn: " + str(player2))

print ("Hello, welcome to Pig Dice.\nPlayer 1 goes first.")

# The nested while loop has two parts, the first main on allows the game to run 
# till someone breaks 50, the second allows for the program to know when which player is playing. 
while (game == True):
	print ("========== PLAYER 1 ==========")
	while (player1_turn == True):
		die = random.randint(1,6)
		print  ("the dice roll was: " + str(die))
		pot = pot + die

		if (die == 1):
			pot = 0
			print ("You got a 1, that means it's Player's 2's turn now. ")
			player1_turn = False
			player2_turn = True
		else: 
			reroll = input("Do you want to [r]oll again or [h]old?").upper()
			if reroll == "R":
					continue
			elif reroll == "H":
				print ("this is the current pot: " + str(pot))
				player1 = player1 + pot
				print (" player one score is: " + str(player1))
				pot = 0
				player1_turn = False
				player2_turn = True
			break

	while (player2_turn == True):
		print ("********** PLAYER 2 **********")
		die = random.randint(1,6)
		print  ("the dice roll was: " + str(die))
		pot = pot + die

		if (die == 1):
			pot = 0
			player1_turn = True
			player2_turn = False
			print ("this is the current pot: " + str(pot))
			player2 = player2 + pot
			print (" player two score is: " + str(player2))
			pot = 0
			break

		else:
			continue
		if pot >= 20:
			print ("this is the current pot: " + str(pot))
			player2 = player2 + pot
			print (" player two score is: " + str(player2))
			pot = 0
	if player1 > 49:
		print ("Player 1 wins")
		player1_turn = False
		player2_turn = False
		game = False
	elif player2 > 49: 
		print ("Player 2 Wins")
		player1_turn = False
		player2_turn = False
		game = False

while (game == False):
	print ("The game is finished.")
	print (player1)
	print (player2)
	pot = 0
	if player1 < player2:
		print ("Player 2 Wins")
	else:
		print ("Player 1 Wins")
	play_again = input("Do you want to play again?").upper()
	if play_again == "Y":
		game = True
	elif play_again == "N":
		print ("Play again soon.")
	break