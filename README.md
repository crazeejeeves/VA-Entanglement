# Entanglement for VoiceAttack
Voice Attack plugin to support extensible key-binding inspection for applications.

## What's with the name?
Heard of _quantum entanglement_? This here is about key binding entanglement :)

## What does it do?
Most freely available Voice Attack Profiles (.vap) are customized according to the bindings on the author's machine. This leads to broken profiles if the author and/or the user are using customized bindings. The ideal solution is to have profiles binded to actions, with actions deriving the keys from the user's environment.

The approach taken by **Entanglement** is inspired by the [bindEd](http://voiceattack.com/smf/index.php?topic=564.0) plugin. **bindEd** reads the game binding files and exposes the keys as command variables that can be used by Voice Attack to trigger a key press based on a voice command.

## What are the plugin's goals?
Key functionality that _Entanglement_ development is focused on:
1. Extensible to support more applications over time
   * Support applications with custom binding files
   * Support applications with no external binding files
2. Improve the user-experience
   * Command names in application binding files may not match the in-game command name. Allow virtual remapping in the plugin.
   * Not all commands should be exposed. Allow easy filtering of commands to reduce number of variables exposed
   * Handle (hopefully) different keyboard layouts for internationalization

## What are the currently targeted/supported applications?
At present, this is a proof-of-concept plugin and very much in early development. As I am an active Elite:Dangerous player, I am most keen to get support for it ready before extending to other applications.
1. Elite:Dangerous _(work-in-progress)_
2. <to be decided>

## How to use?
_Coming soon_
