# cfl-api.net
.Net Implementation of the Canadian Football League (CFL) public API.

For information on the underlying API, see http://api.cfl.ca/docs

# NuGet

https://www.nuget.org/packages/mdryden.cflapi.v1/

Install-Package mdryden.cflapi.v1

# Requirements

- A CFL API key is required for all requests.  See CFL documentation for details on obtaining a key.
- To run the tests, make a local copy of "appSettings.template.config", rename it "appSettings.config" and add your API key.

# Incomplete items

- Leaders method and models have not been implemented
- Team Leaders method and models have not been implemented

# Known issues

- Filtering games by start date does not work (underlying API is not working and/or not clearly documented)
- Filtering players by "offence_defence_or_special" property does not work (underlying API is not working)

