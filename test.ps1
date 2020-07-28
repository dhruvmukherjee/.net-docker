$env:Path += ";C:\Users\ContainerAdministrator\AppData\Local\Microsoft\dotnet\"  
$i=0
do{
dotnet app/myapp.dll
Start-Sleep -s 60
$i
$i++
}while($true)
