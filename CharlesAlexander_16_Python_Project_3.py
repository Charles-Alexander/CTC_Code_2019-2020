#Charles Alexander Project #3

letters = ["A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"]
usedletters =[]
tries = 7
blank = []
game = True

while game == (True):
	import random
	Words = open('Collins Scrabble Words (2019).txt').readlines()
	word = random.choice(Words).strip()
	print ("Hello. \nWelcome to Hangman.\nYou have 7 tries to guess the word, have fun. \nRemember to use uppercase letters.")
	#print (word)# debugging. remove this later
	while (tries > 0):
		game = True
		printedword = ("") # making a new variable thats just our resultant word that's shown to the user ex)  --A---B--E
		for i in range(len(word)):
			currentletter = word[i] # current letter of our word.
			if currentletter in usedletters: # has the letter we're currently on in the word been guessed by the user?
				printedword += currentletter # if so, put said letter there.
			elif currentletter not in usedletters: # if not,
				printedword += "-" # put a dash.

		print ("You got " + str(tries) + " left.")
		print ("The word length is " + str(len(word)))
		print ("Word = ", ''.join(printedword))
		print ("You can use these letters:", ', '.join(letters))
		print ("You've used these letters:", ", ".join(usedletters))
		guess = input("Guess a letter. ")
		print ("                                                  ")

		if guess in word:
			print ("{} is in the word.".format(guess))
			if guess in letters:
				letters.remove(guess)
				usedletters.append(guess)
		elif guess not in word:
			print ("{} is not in the word.".format(guess))
			tries -= 1
			if guess in letters:
				letters.remove(guess)
				usedletters.append(guess)
		else:
			print ("You can't do that!")

		if '-' in printedword:
			continue
		elif '-' not in printedword:	
			print (word)
			print ("You win!! Congrats!!")
			break
		elif tries == 0:
			print ("You lose. To bad")
			game == False
			break
	playagain = input("Do you want to play again? [y/n]").upper()
	if playagain == "Y":
		tries = 7
		game = True
		del letters
		del usedletters
		letters = ["A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"]
		usedletters = []
		#Words = open('Collins Scrabble Words (2019).txt').readlines()
		#word = random.choice(Words).strip()
	elif playagain == "N":
		game = False
		print ("Ok. Good bye for now. Play again soon.")
# check if printedword variable has any dashes, if not, end the loop or whatever and say you win.