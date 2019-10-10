# Custom Activity : 

##Requirement:
Microsoft visual studio
Nuget Package explorer


## Create Library : 
- Open Visual Studio
- File -> New -> Visual C# -> class library
- Dependencies / Reference -> Add References (this for adding your dependencies)
- Select solution configuration as Release & Build.
- After Build .dll will be created in the bin folder.

## Creating Package :

- Go to Nuget package explorer
- Create new package
- Add lib
- Add existing file
- Add .dll which we created
- Save.


## How to use this package :

- Either copy that created package in UiPath Package folder or any-other folder.
- If it is other than UiPath default package folder then add path through the manage->package->setting
- Install your package and start using in Automation

