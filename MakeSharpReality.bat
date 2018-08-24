﻿@echo off
:: usage: "MakeSharpReality.bat x64|x86 Release|Debug 2015|2017"

:: x64 or x86
set "PLATFORM=%~1"
:: Release or Debug
set "CONFIG=%~2"
:: 2015 or 2017
set "VSVER=%~3%"

if "%PLATFORM%" == "" echo ERROR: PLATFORM is not set, example of usage: "MakeSharpReality.bat x86 Release 2017" && pause && exit /b
if "%CONFIG%" == "" echo ERROR: CONFIG is not set, example of usage: "MakeSharpReality.bat x86 Release 2017" && pause && exit /b
if "%VSVER%" == "" echo ERROR: VS_VER is not set, example of usage: "MakeSharpReality.bat x86 Release 2017" && pause && exit /b

if "%VSVER%" == "2015" set "VS_VER=14"
if "%VSVER%" == "2017" set "VS_VER=15"
if "%PLATFORM%" == "x64" (set "TARGET=Visual Studio %VS_VER% Win64") else (set "TARGET=Visual Studio %VS_VER%")
if "%PLATFORM%" == "x64" (set "MONOURHO_PLATFORM=x64") else (set "MONOURHO_PLATFORM=Win32")
if "%CONFIG%" == "Release" (set "CONFIG_SUFFIX=") else (set "CONFIG_SUFFIX=_d")


set "URHO3D_SRC_DIR=Urho3D/Source"

del Urho3D\Urho3D_SharpReality\CMakeCache.txt 2>NUL
del /S /Q Urho3D\Urho3D_SharpReality\CMakeFiles
cd %URHO3D_SRC_DIR% 

cmake -E make_directory ../Urho3D_SharpReality
cmake -E chdir ../Urho3D_SharpReality cmake -G "%TARGET%" ../Urho3D_SharpReality -DURHO3D_D3D11=1 -DUWP=1 -DUWP_HOLO=1 -DSTEREO_INSTANCING=0 -DURHO3D_NEON=0 -DURHO3D_WIN32_CONSOLE=0 -DURHO3D_NETWORK=1 -DURHO3D_FILEWATCHER=0 -DURHO3D_PROFILING=0 -DURHO3D_THREADING=0 -DURHO3D_PCH=0 -DURHO3D_WEBP=0 -DURHO3D_LUA=0 -DURHO3D_ANGELSCRIPT=0 -VS=%VS_VER% ../../%URHO3D_SRC_DIR%/

cd ..
xcopy Urho3D_UWP\MonoUrho.UWP\SdlStub\SDL Urho3D_SharpReality\include\Urho3D\ThirdParty\SDL\* /Y

cd Urho3D_SharpReality
cmake --build . --target Urho3D --config %CONFIG%

copy lib\Urho3D%CONFIG_SUFFIX%.lib lib\Urho3D%CONFIG_SUFFIX%_%PLATFORM%.lib /Y
cd ../..

msbuild Urho3D\Urho3D_SharpReality\UrhoSharp.SharpReality\UrhoSharp.SharpReality.vcxproj /p:Configuration=%CONFIG% /p:Platform=%MONOURHO_PLATFORM%