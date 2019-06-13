# Build image
FROM andrewlock/aspnetcore-build:2.0.7-2.1.105 as builder

# Publish
RUN dotnet publish "./src/AspNetCoreInDocker.Web/AspNetCoreInDocker.Web.csproj" -c Release -o "../../dist" --no-restore

#App image
FROM microsoft/aspnetcore:2.0.7  
WORKDIR /app  
ENV ASPNETCORE_ENVIRONMENT Local  
ENTRYPOINT ["dotnet", "AspNetCoreInDocker.Web.dll"]
COPY --from=builder /sln/dist .  