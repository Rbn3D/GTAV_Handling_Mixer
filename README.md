# Handling Mixer (for GTA V)
Handling Mixer is a tool that allows to generate handling.meta files from 2 different handling.meta files, performing a interpolation between values of both. Allows per-property fine tuning.

#### With this tool you can quickly tune any handling.meta file, without having to manually set values for every vehicle. Happy modding!

### Features
* Select two different handling.meta files (vanilla and modded for example) and get a mixed handling.meta with full per property user control:
* Mix value Factor => Interpotate property
* Use A => Take value from A handling
* Use B => Take value from B handling
* Fixed Value.
* Value Offset
* Value Multiplier
* Value custom formula (supporting math expressions) (Doc link TODO)
* Value minimum
* Value Maximum

#### Other features
* Contextual help: As you edit value modifiers, a tooltip helps you to know what the modifier does etc. This can be configured.
* Load/save Mix setup: As well as generate a handling.meta file, Handling Mixer can also save the mix setup you did for later usage.

### Download 

[Handling Mixer releases](https://github.com/Rbn3D/GTAV_Handling_Mixer/releases)

### How to compile from source

* Requirements
	Windows
	Visual Studio 2015

* Dependencies (DLL References)

https://github.com/Rbn3D/Math-Expression-Evaluator

After fix references, just build solution and you're done

## Contributions are welcome!

### F.A.Q.
* **Q**: I just have one handling file, don't want to mix between two, but quickly tune some properties, can this be done?
* **A**: Yes, just set A and B handling to the same file, and then play with offset, multiplier, custom formula, min, max
