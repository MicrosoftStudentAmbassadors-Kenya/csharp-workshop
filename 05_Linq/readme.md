# We are going to use 
     Newtonsoft.Json
# add the package using 
```bash
  dotnet add package Newtonsoft.Json --version 12.0.3
```
If you run the above code it will add some reference in you .csproj

```CSharp
<PackageReference Include="Newtonsoft.Json" Version="12.0.3" />
```

## you machine stores remote packages in a local cache. 
For windows all packages are stored in the either of the following locations

```CSharp
 %LocalAppData%\NuGet\Cache
 %UserProfile%\.nuget\packages
```
## CsProj file

```xml
 <ItemGroup>
    <PackageReference Include="Newtonsoft.Json" Version="12.0.2"/>
  </ItemGroup>
```