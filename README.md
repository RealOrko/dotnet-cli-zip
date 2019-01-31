# dotnet-cli-zip

A zipping and unzipping tool for the dotnet cli that works on osx-x64/linux-x64/win-x64 runtimes.

## Why do I need this?

You find yourself flick flacking when it comes to zipping and unzipping in build scripts on multiple runtimes. 
On Windows you use powershell(Compress-Archive/Expand-Archive) but on Unix you use bash(zip/unzip) with nuances. 

Please follow this <a target="dotnet_cli_zip_jump_target" href="https://github.com/dotnet/cli/issues/10675">issue</a>.

## Install using the dotnet cli

```
dotnet tool install --global dotnet-cli-zip
```

## Using it

```
z -e MyZip.zip ./MyZipFolder
z -c ./MyZipFolder MyZip.zip
```

## Uninstalling

```
dotnet tool uninstall -g dotnet-cli-zip
```
