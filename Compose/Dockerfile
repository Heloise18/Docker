FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /sujao

ENV HTTP_PROXY="host.docker.internal:3128"
ENV HTTPS_PROXY="host.docker.internal:3128"

COPY ./Panetone/*.csproj ./

RUN dotnet restore 

COPY ./Panetone/ ./


ENTRYPOINT ["dotnet", "run","--urls=http://0.0.0.0:5264"]

EXPOSE 5264
