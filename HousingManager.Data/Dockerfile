FROM microsoft/dotnet:latest

WORKDIR /app
COPY ./HousingManager.Data.Library /app/HousingManager.Data.Library
COPY ./HousingManager.Data.Service /app/HousingManager.Data.Service

WORKDIR /app/HousingManager.Data.Library
RUN dotnet restore
RUN dotnet build

WORKDIR /app/HousingManager.Data.Service
RUN dotnet restore
RUN dotnet build

ENV ASPNETCORE_URLS="http://+:80"

CMD ["dotnet", "run"]
