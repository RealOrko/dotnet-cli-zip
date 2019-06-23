# dotnet-cli-zip

A zipping and unzipping tool for the dotnet cli that works on osx-x64/linux-x64/win-x64 runtimes.

## Why do I need this?

You find yourself flick flacking when it comes to zipping and unzipping in build scripts on multiple runtimes. 
On Windows you use powershell(Compress-Archive/Expand-Archive) but on Unix you use bash(zip/unzip) with nuances. 

## Install

```
dotnet tool install --global dotnet-cli-zip
```

## Example

```
z -e MyZip.zip ./MyZipFolder
z -c ./MyZipFolder MyZip.zip
```

## Uninstall

```
dotnet tool uninstall -g dotnet-cli-zip
```
