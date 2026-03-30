FROM mcr.microsoft.com/dotnet/sdk:10.0-preview AS build
WORKDIR /src

COPY . .

RUN dotnet restore Project.Api/Project.Api.csproj
RUN dotnet publish Project.Api/Project.Api.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0-preview AS final
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 10000

ENTRYPOINT ["dotnet", "Project.Api.dll"]