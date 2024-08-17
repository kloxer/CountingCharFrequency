Created a program to count character frequency in a screen.

![countCharFrequencyScreen](https://github.com/user-attachments/assets/fa3fd02d-2559-403b-b513-15ebdb9179dc)

Here is an example of an input: 
![OutputResult](https://github.com/user-attachments/assets/3b6625e1-9230-43ed-99d3-ef8cfdb32578)


Fixes and Implementations

- Added proper multiline textbox following Microsoft documentation, it allows for additional lines when the return key is entered as well as a scroll bar to go back and forth through the text, for both input and result boxes.

- Properly implement vertically the answer instead of horizontally using a new line appended to the string result.

- Added White Space as a proper entry instead of it being an empty string appended to a number

- The output would not be sorted when entering, so I used SortedDictionary instead of Dictionary so that the values would automatically be sorted by key(the char).

- An issue where the output wouldn't be cleared and had to reopen each time, the problem was the text box wouldn't be cleared so the new output would append to the bottom. I fixed it so that the text box clears on each button press, then the new answer can be shown.

- Added a message alert box that will pop up if a user hasn't entered any text, prompting the user that no text was entered and redirects the users cursor to the message box.

- Added a repository to GitHub to enable version control. 

The resulting file should meet all software requirements. 
