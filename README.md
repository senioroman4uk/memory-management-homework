# Memory-management homework

This is a sample application with a memory issue. Your goal is to find 
the cause of it and fix it.

## Solution structure

Solution contains two projects  
* First is a web application that uses some client library
* Second the client library for publishing messages  
* Messages are published to rabbit-mq

## How to run it
1. Install .NET Core 2.2 SDK
2. Install [docker](https://docs.docker.com/install/)
3. Go to the root folder of this repo
4. Run docker-compose up 
5. Run the web-application `dotnet run --project  MemoryManagementHomeWork`
