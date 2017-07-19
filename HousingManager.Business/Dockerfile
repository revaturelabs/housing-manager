FROM microsoft/dotnet:latest

WORKDIR /app
COPY ./HousingManager.Business.Library /app/HousingManager.Business.Library
COPY ./HousingManager.Business.Service /app/HousingManager.Business.Service

WORKDIR /app/HousingManager.Business.Library
RUN dotnet restore
RUN dotnet build

WORKDIR /app/HousingManager.Business.Service
RUN dotnet restore
RUN dotnet build

ENV ASPNETCORE_URLS="http://+:80"

CMD ["dotnet", "run"]
