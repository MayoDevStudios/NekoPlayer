#!/bin/bash

dotnet tool restore
dotnet CodeFileSanity
dotnet jb inspectcode "NekoPlayer.Desktop.slnf" --no-build --output="inspectcodereport.xml" --caches-home="inspectcode" --verbosity=WARN
dotnet nvika parsereport "inspectcodereport.xml" --treatwarningsaserrors