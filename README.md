# cfl-api.net v1.24 (API v1.24)
.Net Implementation of the Canadian Football League (CFL) public API.

For information on the underlying API, see http://api.cfl.ca/docs

## NuGet

https://www.nuget.org/packages/mdryden.cflapi.v1/

Install-Package mdryden.cflapi.v1

## Requirements

- A CFL API key is required for all requests.  See CFL documentation for details on obtaining a key.
- To run the tests, make a local copy of "appSettings.template.config", rename it "appSettings.config" and add your API key.

## Versioning

- The version number for this project will match with the version number of the CFL API it fully supports.  See the release notes at http://api.cfl.ca/release-notes to determine which features are available.

## Reporting issues

Feel free to report any issues you find on the GitHub issue tracker.  Comments are also welcome.

When reporting issues, please ensure you have verified the underlying API call is returning the data you expect.  For all API client classes, the LastRequestUrl will be populated with the actual api url which was created.  You can paste this url into a browser or view the LastResponse property to see what the API returned.

Please include the value of the LastRequestUrl in any bug reports if applicable.