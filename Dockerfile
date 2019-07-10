FROM microsoft/dotnet:2.2-sdk-alpine AS build-env
WORKDIR /app

COPY . ./

RUN dotnet restore src/1.Presentation/ExampleCQRS.Web/ExampleCQRS.Web.csproj

RUN dotnet publish src/1.Presentation/ExampleCQRS.Web/ExampleCQRS.Web.csproj -c Release -o out


FROM microsoft/dotnet:2.2-aspnetcore-runtime-alpine

WORKDIR /app

COPY --from=build-env /app/src/1.Presentation/ExampleCQRS.Web/out .

ENTRYPOINT ["dotnet", "ExampleCQRS.Web.dll"]