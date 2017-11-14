@ECHO OFF

set /p version=Enter version #:
set /p notes=Enter release notes:

nuget pack .\mdryden.cflapi.v1.nuspec -Properties version="%version%";releaseNotes="%notes%"

nuget push mdryden.cflapi.v1.%version%.nupkg -Source https://www.nuget.org/api/v2/package

PAUSE