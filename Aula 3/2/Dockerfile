FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /que

ENV HTTP_PROXY="host.docker.internal:3128"
ENV HTTPS_PROXY="host.docker.internal:3128"

ENV NO_PROXY="maestro,localhost,127.0.0.1"

COPY ./Client/*.csproj ./

RUN dotnet restore

COPY ./Client ./

ENTRYPOINT [ "dotnet", "run" ]