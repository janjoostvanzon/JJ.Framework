@echo off
prompt $G
@echo on
rmdir /S /Q Assets\DotNetAssemblies 
mkdir Assets\DotNetAssemblies
xcopy ..\JJ.Presentation.SetText.Unity.DotNet.OfflineWithSync\bin\Release\*.* Assets\DotNetAssemblies /E /Q

REM  TODO FOR WINDOWS PHONE: CLEAR THE ASSETS\MONO FOLDER!!!
REM  TODO FOR WINDOWS PHONE: COPY SATELLITE ASSEMBLIES TO WINDOWS PHONE DEPLOYMENT FOLDER!!!

pause
