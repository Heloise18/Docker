FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /limpoo

ENV HTTP_PROXY="host.docker.internal:3128"
ENV HTTPS_PROXY="host.docker.internal:3128"

COPY ./API/*.csproj ./
RUN dotnet restore

COPY ./API ./

ENTRYPOINT ["dotnet", "run"]
EXPOSE 5223
