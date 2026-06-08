$p = "C:/ProgramData/DockerDesktop/config"

New-Item -ItemType Directory -Path $p -Force
New-Item -ItemType File -Path ($p + "\daemon.json") -Force

$json = @"
{
  `"builder`": {
    `"gc`": {
      `"defaultKeepStorage`": `"20GB`",
      `"enabled`": true
    }
  },
  `"dns`": [
    `"1.1.1.1`",
    `"8.8.8.8`"
  ],
  `"experimental`": false
}
"@

Set-Content -Path ($p + "/daemon.json") -Value $json -Encoding UTF8