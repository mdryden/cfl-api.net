# cfl-api.net v1.7 (v1.07)
.Net Implementation of the Canadian Football League (CFL) public API.

For information on the underlying API, see http://api.cfl.ca/docs

## NuGet

https://www.nuget.org/packages/mdryden.cflapi.v1/

Install-Package mdryden.cflapi.v1

## Requirements

- A CFL API key is required for all requests.  See CFL documentation for details on obtaining a key.
- To run the tests, make a local copy of "appSettings.template.config", rename it "appSettings.config" and add your API key.

## Known issues

- Filtering players by "offence_defence_or_special" property does not work (underlying API is not working)

## Versioning

- The version number for this project will match with the version number of the CFL API it fully supports.  See the release notes at http://api.cfl.ca/release-notes to determine which features are available.
