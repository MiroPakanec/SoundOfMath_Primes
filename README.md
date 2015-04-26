## Welcome to the SoundOfMath_Primes!
A small c# music project made in Visual Basic.

## Purpose
The purpose of this project is to create a song out of prime numbers.

## Code description
1. The code reads the resource files which contains 1000 prime numbers taken from [this website](https://primes.utm.edu/lists/small/1000.txt), converts them into a list of prime numbers and digital roots for prime numbers above 9.
2. It assigns a note(piano chord) to each of the values from 1 to 9 and then plays the song
3. It automatically changes the delay between each note based on the difference between the last two notes played. If  n > n-1 the delay increases else the delay decreases(where n is the int value last note played).
_More info in the code's comments._

## Contributions needed

In the initial stage the code is long, non-optimized and some things are probably redundant.

 Here is a list of improvements that would be great if you guys can help me implement:
* A log for the song duration and note count
* Better sound player
* Overall code optimization 
* Maybe even a GUI
* Improvements to this wiki

## Credits
Piano chords from [DadeMo](http://audio.ibeat.org/?ccm=/media/files/DaDeMo/475).
# License
This project is under [MIT license](http://choosealicense.com/licenses/mit/) so any modification or distribution must credit the ones who deserve it.

## Disclaimer
I'm a basic n00b to Git so don't judge me if I make basic n00b mistakes.
