# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build the runtime image.
# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 as runtime
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "WebXR.dll" ]
