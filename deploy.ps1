$destinationFolder = ".\AdventureWorks.Web"
$destinationBinFolder = ".\AdventureWorks.Web\bin"

Write-Host "Clean bin folder"

Remove-Item $destinationBinFolder\*.xml
Remove-Item $destinationBinFolder\*.pdb
Remove-Item -force -recurse $destinationFolder\obj

Write-Host "Cleaned"