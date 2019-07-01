FROM mcr.microsoft.com/dotnet/core/sdk:2.2
WORKDIR /sln
COPY . .
RUN dotnet restore
RUN dotnet publish ./AspNetCoreAppLogging.csproj -o /app/ 
WORKDIR /app
ENTRYPOINT ["dotnet", "AspNetCoreAppLogging.dll"]