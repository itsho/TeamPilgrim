## Team Pilgrim for VS2013

* [Screenshot][scrnshot]

### Downloads:

* [Microsoft Visual Studio 2013 SDK][vs2013sdk]
* [AlternateStreamView][asvdownload]

### Launching & Debugging:

* make sure to remove all alternate streams from all files in solution. 
otherwise, you'll get exceptions like 'IniParser.ParsingException' or 'File not found' or Xaml Parse issues

* Set TeamPilgrim.VisualStudio as the startup Project
* Set to start external program with Visual Studio 2013 as the target - ex. 
C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe

* Add the following to Command line arguments: `/rootsuffix Exp`

* If you have ReSharper installed and want to disable it open the **Command Window** and type: `ReSharper_Suspend`

[vs2013sdk]:     http://www.microsoft.com/en-us/download/details.aspx?id=40758
[asvdownload]:	http://www.nirsoft.net/utils/alternate_data_streams.html
[scrnshot]:	http://i.imgur.com/4nEhDti.png