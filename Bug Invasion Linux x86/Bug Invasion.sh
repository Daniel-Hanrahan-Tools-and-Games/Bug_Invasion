#!/bin/sh
echo -ne '\033c\033]0;Bug Invasion\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/Bug Invasion.x86_64" "$@"
