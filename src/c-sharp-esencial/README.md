[<- Inicio](../../README.md)

# C# esencial

## Nuevo proyecto de consola

1. Crear nuevo archivo de solucion:
	```bash
	mkdir ./src/c-sharp-esencial/
	dotnet new sln -o ./src/c-sharp-esencial/
	```
1. Crear nuevo proyecto
	```bash
	mkdir ./src/c-sharp-esencial/MiPrimerProyecto
	dotnet new console -o ./src/c-sharp-esencial/MiPrimerProyecto/ --use-program-main
	```
1. Agregar el proyecto a la solucion:
	```bash
	dotnet sln ./src/c-sharp-esencial/c-sharp-esencial.sln add ./src/c-sharp-esencial/MiPrimerProyecto/MiPrimerProyecto.csproj
	```
1. Restaurar, compilar y probar el proyecto:
	```bash
	dotnet restore ./src/c-sharp-esencial/c-sharp-esencial.sln
	dotnet build ./src/c-sharp-esencial/c-sharp-esencial.sln --no-restore
	dotnet run --project ./src/c-sharp-esencial/MiPrimerProyecto/ 
	```