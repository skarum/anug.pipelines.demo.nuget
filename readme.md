# Azure DevOps Pipelines demo: Nuget package

This repository contains a simple nuget package and build script for creating the nuget package.

Build file is: `azure-pipelines.yml`

In the demo I created a Nuget feed (under artifacts) and pulished using a release difintion.

The only step in the release was Nuget publish

```yml
steps:
- task: NuGetCommand@2
  displayName: 'NuGet push'
  inputs:
    command: push
    packagesToPush: '$(System.DefaultWorkingDirectory)/Anug.Pipeline.NugetPackage/drop/Anug.Pipeline.NugetPackage.*.nupkg'
    publishVstsFeed: '[FeedName]'

```
