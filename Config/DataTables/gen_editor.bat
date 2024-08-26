@echo off
set PROJECT_ROOT=..\..
set GAME_CLIENT_ROOT=%PROJECT_ROOT%\Unity
set CONFIG_ROOT=%PROJECT_ROOT%\Config\DataTables
set LUBAN_DLL=%CONFIG_ROOT%\..\Luban\Luban.dll
set CONF_ROOT=.

@echo =================== gen client ===================
dotnet %LUBAN_DLL% ^
    --conf %CONF_ROOT%\luban.conf ^
    -t editor ^
    -c cs-unity-gui-json ^
    -d json3 ^
    -x jsonStrict=false ^
    -x outputCodeDir=%GAME_CLIENT_ROOT%\Assets\GameScript\Editor\ConfigEditor\Models ^
    -x outputDataDir=%CONF_ROOT%\EditorDatas

pause