# EldenRingDeathCounter
 
Death counter for Elden Ring that reads the middle of the screen and tries to find the text "YOU DIED" and increments a counter if found.

The screenshots are pre-processed using Emgu.CV (OpenCV .NET wrapper) and the text is read using Tesseract (tesseract-ocr .NET wrapper).

## Installation

Download the .zip file from the releases and extract the contents into a folder. 

You may have to installa a .NET runtime to be able to run the exe.

## Usage

Open up the EldenRingDeathCounter.exe file and press START. You can open up the app / press start after starting the game, or before. Order doesn't matter.

The app will read all screens until a screen with a death is detected, after that it will only read that screen.

Deaths are saved every time the number is updated, so don't worry about closing the app before pressing STOP.

Screenshots of the moments of death are saved inside the folder 'DeathImages' with naming format 'death_<DEATH_NUMBER>_<DEATH_DATE>.jpg'.

## NOTE! This currently only works on 16:9 screens with the game on full screen (the capture location is based on percentages of screen height and width).
