run:
	dotnet watch --project=jobsearch/jobsearch.csproj

clean:
	dotnet clean

restore:
	dotnet restore

publish:
	dotnet publish -c release -f net6.0 -o ./release
