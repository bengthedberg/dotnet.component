pushd src\%1%
dotnet run dropdb migratedb seeddb stop
popd
