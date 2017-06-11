# Entanglement for VoiceAttack
Voice Attack plugin to support extensible key-binding inspection for applications.

## What does it do?
Most freely available Voice Attack Profiles (.vap) are customized according to the bindings on the author's machine. This leads to broken profiles if the author and/or the user are using customized bindings. The ideal solution is to have profiles binded to actions, with actions deriving the keys from the user's environment.

The approach taken by **Entanglement** is inspired by the [bindEd](http://voiceattack.com/smf/index.php?topic=564.0) plugin. **bindEd** reads the game binding files and exposes the keys as command variables that can be used by Voice Attack to trigger a key press based on a voice command.

## Plugin goals
Key functionality that _Entanglement_ development is focused on:
1. Extensible to support more applications over time
   * Support applications with custom binding files
   * Support applications with no external binding files
2. Improve the user-experience
   * Command names in application binding files may not match the in-game command name. Allow virtual remapping in the plugin.
   * Not all commands should be exposed. Allow easy filtering of commands to reduce number of variables exposed

## How to use?
_Coming soon_
