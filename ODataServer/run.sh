#!/bin/bash
# Script to run the ODataServer

cd "$(dirname "$0")"
echo "Starting ODataServer on ports 5005 (HTTP) and 5006 (HTTPS)..."
dotnet run
