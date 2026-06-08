FROM mcr.microsoft.com/mssql/server:2022-latest


COPY ./API/nome.csproj .
RUN dotnet restore

COPY ./API .



EXPOSE 1433