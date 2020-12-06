I originally built this Managment system to keep track of .gpX and .tg files (which are Guitar Tab file formats)

# To get it to work you need:

* Download the package ADODB.7.10.3077 via NuGet
* You have to move the python file `offset.py` in the folder `_output_python_file` to where you have your exported executable
* Python 3.6.4 and the module guitarpro (You can get it via cmd: pip install PyGuitarPro)


# How to use it

Once downloaded and started you can see 3 submenus/filters - Home, Favorites and files marked as toLearn.
With the search icon you can specify your own Filter to search by.
Finally with the Plus-Icon you can add new Files to the System with the respected Attributes

Once you have added a few files, you can either Edit the entry or press Play to start the File.
Before starting it asks you for an offset-input
This is useful if your Guitar's Tuning doesn't match the Song's Tuning. The Number of Semitones offset you input only changes the Playback-Pitch of the song not the TAB.
