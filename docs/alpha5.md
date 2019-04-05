# Alpha 5 is in development!
With an ETA around tomorrow, Alpha 5 will be the biggest update the system will see.
## PUMA Execution Mode
PUMA is the new application format that doesn't allow applications to call kernel functions without permissions, and doesn't allow most unsecure data reads. The new SecureIO 'driver' will be handling all of this, and specific apps will recieve authorization. Your PUA apps will still run, just you will have to press F2 while starting, and start in userless mode, and there you can run your programs. This is a significant security risk, and **wont** be available in Beta 2 and higher.
## PUA vs. PUMA
PUA apps have free range over the system, while PUMA have to talk with a framework for outside calls. This is a very big security improvment, with minimal speed decreases.
## Opt-out
There's no real opt-out from the default shell being a PUMA-based one after Alpha 7, and starting with Beta 2, PUMA apps won't be supported. The userless shell will exist until around Beta 5, before being removed. A special edition of 9OS with PUA support '9OS Legacy Edition' will be avaiable, but completely seperate from a stock 9OS 12 machine.
## Migrate your apps
To migrate your apps to PUMA, you simply have to remove some restrictively calls. The transition will be seamless, and legacy PUA calls will be evaluateed by the Security framework, and then executed if allowed. If not, the machine won't crash, but a success code will be reported, and you can continue your application. 
## Why are PUAs insecure?
PUA isn't going to be *gone* from the system, as various applications such as LoginServer and CoreOSKernel obviously have to run in PUA mode, but they are regulated PUMA.
## Why should I upgrade?
You should upgrade to Alpha 5 when its released because of the increased security. Without it, you are at significant risk of password table leaking, install corruption and various other bad things. PUMA removes all of these!
## Speed
You may ask, "Since PUMA is running through an external framework, won't that cause speed issues?". No, it won't. Your apps will run slightly slower, unless they are using pumaio_ calls. Older apps that are translated will obviously suffer speed problems, but if they updated, the should be fixed.
