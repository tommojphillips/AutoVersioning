# Automate versioning of a .net library

Automate versioning using the T4 Text template.

## Version Definition

v[Major].[Minor].[Revision].[Build] => v1.0.100.16

[Major] => Major number.

[Minor] => Minor number.

[Revision] => Days since the date: 01.01.2022.

[Build] => How many times built since [Revision] has changed.

> Version definition logic can be changed in "AssemblyInfo.tt"

> [Major] and [Minor] version numbers can be still be modified. 

>Only [Revision] and [Build] numbers are modified by the .tt logic if [autoRevisionUpdateDaily] is set to true.

## If [autoRevisionUpdateDaily] is set to true,

>Revision is updated based on how many days since [projectStartDate].

>The Build number is reset when Revision changes

>Otherwise if [autoRevisionUpdateDaily] is set to false, you can modify revision. but the build number will still update every build nut won't reset when revision changes.

## How to use this

1. Locate "AssemblyInfo.cs" and Delete it. (Properties/AssemblyInfo.cs)
2. Copy "AssemblyInfo.tt" to the orginal location of "AssemblyInfo.cs". (Properties/AssemblyInfo.cs)
<img width="255" alt="Screenshot 2023-04-10 175943" src="https://user-images.githubusercontent.com/39871058/230855994-409558a9-80d9-4a25-a995-96ea10100fd1.png">

> The ".tt" file will auto-generate an "Assembly.Info.cs" file.

3. In your projects Pre-build event command-line, copy and paste this code:

```
"$(DevEnvDir)TextTransform.exe" -a !!BuildConfiguration!$(Configuration) "$(ProjectDir)Properties\AssemblyInfo.tt"
```

Pre-build event command line should look like this:
<img width="832" alt="auto versioning prebuild event command linr" src="https://user-images.githubusercontent.com/39871058/230855733-62870e78-648b-48d1-9bdc-439cc52694fb.png">

4. Now every time you build your project the version will increment.
