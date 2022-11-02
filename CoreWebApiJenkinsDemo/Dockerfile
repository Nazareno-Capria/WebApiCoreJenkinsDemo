FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /WebApiJenkinsDemo
ENV ASPNETCORE_URLS http://+:44326
EXPOSE 44326

FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /src
COPY ./*.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

FROM base AS final
WORKDIR /WebApiJenkinsDemo
COPY --from=build /src/out .
ENTRYPOINT ["dotnet", "./CoreWebApiJenkinsDemo.dll"]