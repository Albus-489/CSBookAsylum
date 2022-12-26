#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WEBAPI3/WEBAPI3.csproj", "WEBAPI3/"]
COPY ["App/App.csproj", "App/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Project2/DAL/DAL.csproj", "Project2/DAL/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
RUN dotnet restore "WEBAPI3/WEBAPI3.csproj"
COPY . .
WORKDIR "/src/WEBAPI3"
RUN dotnet build "WEBAPI3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WEBAPI3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WEBAPI3.dll"]