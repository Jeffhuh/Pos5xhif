REM @echo off
REM L�scht alle tempor�ren Visual Studio Dateien
taskkill /IM dotnet.exe /F
rd /S /Q ".vs"
rd /S /Q ".vscode"
rd /S /Q ".packages"
FOR /D /R %%d IN (*) DO (
  rd /S /Q "%%d\bin"
  rd /S /Q "%%d\obj"
  rd /S /Q "TestResults"
)


