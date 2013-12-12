REM  Clean Staging Directory

@echo off
call :cleanDIR
goto :eof

:cleanDIR
for /d /r "C:\Builds\TestRunWorkspace\UnitTestResults" %%x in (*) do rd /s /q "%%x"
attrib -R "C:\Builds\TestRunWorkspace\UnitTestResults\*.*"
del /Q "C:\Builds\TestRunWorkspace\UnitTestResults\*.*"
exit /b