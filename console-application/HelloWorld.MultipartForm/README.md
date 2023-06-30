# Sending Multipart Form Request with WebClient

## Objective
This is to show how to send Multipart Form request with WebClient in .NET Framework 3.5

## Technical Specification
Language: C# 7.3 ([Reference](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version))\
Framework: .NET 3.5

## How to Run?
1. Prepare the following five arguments in Command line arguments in Visual Studio.
   - Service Endpoint: Your web API URL which will accept the multipart form request;
   - System ID: Can be anything;
   - Token: Can be anything;
   - Message: Your message to be sent, can be anything;
   - Attachments: A list of absolute paths to the files on the local machine, separated by comma (,). Can be empty.
  ![image](https://github.com/goh-chunlin/gcl-boilerplate.csharp/assets/8535306/d8ab58c3-6d9f-4f76-b852-688d31c3833b)

2. Run the project in Visual Studio.
