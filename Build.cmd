dotnet restore
dotnet build -c=Release
dotnet pack .\TopOA.Core\TopOA.Core.csproj -c=Release --no-build --include-symbols -o .\..\artifacts