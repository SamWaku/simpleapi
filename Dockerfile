FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env

WORKDIR /app

COPY SimpleApi.csproj ./
RUN dotnet restore "SimpleApi.csproj"

COPY . ./
RUN dotnet publish "SimpleApi.csproj" -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

EXPOSE 8080
ENTRYPOINT ["dotnet", "SimpleApi.dll"]
#1 Prepare to build image
#2 set the image working directory to /app
#3 copies the project file the runs a dotnet restore 
#4 copies the rest of the project
#5 builds a run time image