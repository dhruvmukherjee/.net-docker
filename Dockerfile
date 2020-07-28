FROM mcr.microsoft.com/dotnet/framework/sdk:3.5-20200318-windowsservercore-ltsc2016

COPY app/bin/Release/netcoreapp3.1/publish/ app/

COPY .\\dotnet-install.ps1 .

RUN "powershell C:\dotnet-install.ps1 -Channel LTS"

COPY .\\test.ps1 .

ENTRYPOINT powershell -file .\\test.ps1
