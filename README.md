# Overview

This Repository can be used a template repository. 


## What is included

The Repository contains standard folders where the productive code is in a src folder, the test project is in the tests' folder. 

It also has a Directory.Build.props file which is being read from dotnet when interacting with source code. It contains properties that is "added" to all csproj files.


```XML
<Project>
    <PropertyGroup>
        <Nullable>enable</Nullable>
        <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    </PropertyGroup>
</Project>
```

These are settings that I highly recommend you using in all c# projects, because they help you to spot potential bugs very early.

It also has a .gitignore directory that excludes build artifacts as well as intermediate files. 


There is also a devops-build folder - which in the future can contain files that tell buildservers how to build this projects. 


## Project overview

This repository contains projects, targeting dotnet 10.0 framework. There is a small application with a main method that demonstrate some method usage. 

Additionally, there is a test project that demonstrates how to test instance and class methods.