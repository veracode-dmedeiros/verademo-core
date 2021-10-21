#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["verademo-core/verademo-core.csproj", "verademo-core/"]
RUN dotnet restore "verademo-core/verademo-core.csproj"
COPY . .
WORKDIR "/src/verademo-core"
RUN dotnet build "verademo-core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "verademo-core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "verademo-core.dll"]