@ECHO OFF

rem set /p version=Enter version #:
rem set /p notes=Enter release notes:

rem nuget pack .\mdryden.cflapi.v1.nuspec -Properties version="%version%";releaseNotes="%notes%"

nuget push src\v1\Core\bin\Release\mdryden.cflapi.v1.*.nupkg -Source https://www.nuget.org/api/v2/package

PAUSE