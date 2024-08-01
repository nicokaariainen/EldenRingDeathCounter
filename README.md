# EldenRingDeathCounter
 
Death counter for Elden Ring that reads the middle of the screen and tries to find the text "YOU DIED" and increments a counter if found.

The screenshots are pre-processed using Emgu.CV (OpenCV .NET wrapper) and the text is read using Tesseract (tesseract-ocr .NET wrapper).

## NOTE! This currently only works on 16:9 screens with the game on full screen (the capture location is based on percentages of screen height and width).
