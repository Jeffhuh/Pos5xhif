@echo off
echo . > dirs.txt
dir /a:d /s /b >> dirs.txt
REM L�scht alle tempor�ren Visual Studio Dateien
FOR /F %%d IN (dirs.txt) DO (
  rd /S /Q %%d\bin
  rd /S /Q %%d\obj
  rd /S /Q %%d\.vs
  rd /S /Q %%d\.vscode
  rd /S /Q %%d\Release
  rd /S /Q %%d\Debug
  rd /S /Q %%d\TestResults
)
del dirs.txt
