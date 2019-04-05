# New Storage Requirement
Yes, that's right! Unlike the previous 11 versions of 9OS, this version has a configuration system that stays after system reboot!
## U:\ Drive
The U:\ drive is where configuratoin files are going to be stored. Right now, it's only being used for login tables, so it is not *needed*, but **highly** reccomended. I would suggest 128 MB, but 64 MB is the minimum from now until 12.0 releases into production. 
## Why
This is where data and other configuration files that you don't want removed will be stored. These, as of now, only include the login tables.
## I don't want to!
You don't have to! If you don't want to upgrade, you really don't have to. Mostly everything will function, besides anything to do with user things. In the next version, the system default shell will be the standard Debug Controller, but an option to set it to the new shell will be there. You selecting this shell will likely break your install.
## I have my drive, now what?
Simply type in console, 'reset table'. This will not erase any data on the drive, but will create the 9OS directories and will create a new login table. This is to be used for first-setup, but if you actually forget your password, use the "Reset Tables" button in the Login UI. 
