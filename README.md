# cfl-api.net v2.1.24 (API v1.24)
.Net Implementation of the Canadian Football League (CFL) public API.

For information on the underlying API, see http://api.cfl.ca/docs

## NuGet

https://www.nuget.org/packages/mdryden.cflapi.v1/

## GitHub

https://github.com/pudds/cfl-api.net

Install-Package mdryden.cflapi.v1

## Requirements

- A CFL API key is required for all requests.  See CFL documentation for details on obtaining a key.
- To run the tests, make a local copy of "appSettings.template.config", rename it "appSettings.config" and add your API key.

## Versioning

- The minor and build digits of the version number for this project will match with the version number of the CFL API it fully supports.  See the release notes at http://api.cfl.ca/release-notes to determine which features are available.
- The first digit of the version number represents the major version within this project.  It will only be incremented when the library API is updated with a breaking change.
- The last digit represents a revision, and will usually be 1 unless a bug fix has been released.

## Reporting issues

Feel free to report any issues you find on the GitHub issue tracker (https://github.com/pudds/cfl-api.net/issues).  Comments are also welcome.

When reporting issues, please ensure you have verified the underlying API call is returning the data you expect.  For all API client classes, the LastRequestUrl will be populated with the actual api url which was created.  You can paste this url into a browser or view the LastResponse property to see what the API returned.

Please include the value of the LastRequestUrl in any bug reports if applicable.