# gRPC
**NOTE**: This sample is tested only on **Windows** platform

# To run locally (Windows)
- Open gRPC.sln in visual studio
- gRPC Solution Properties - Startup project - Select Multiple Startup Projects - Ensure that both gRPCServer and gRPCApiClient projects are selected
- Press F5 on Visual Studio
- gRPCServer opens up in console window
- gRPCApiClient opens up in browser

# To test gRPCApiClient locally (Windows)

## Testcase-1
- open the URL in browser http://localhost:52280/greet
- gRPCServer console to display below message

`---->Received request from gRPCClient: world`

`<----Sending response from gRPCServer: Hello world`

- gRPCApiClient running on browser display `Hello World`

## Testcase-2
- open the URL in browser http://localhost:52280/greet/VMWare
- gRPCServer console to display below message

`---->Received request from gRPCClient: VMWare`

`<----Sending response from gRPCServer: Hello VMWare`

- gRPCApiClient running on browser display `Hello VMWare`