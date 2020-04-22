#!/bin/sh

set -x
set -e


cd src
dotnet restore
dotnet tool install --global Amazon.Lambda.Tools || true
export PATH="$PATH:${HOME}/.dotnet/tools"
dotnet-lambda package --configuration release --framework netcoreapp2.1 --output-package deploy-package.zip




