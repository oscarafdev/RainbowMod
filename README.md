# Proyecto RainbowMod - Rust Legacy

## Sobre el proyecto
RainbowMod es un mod de Rust Legacy basado en Fougerite Mod, este proyecto fue creado para darle un mejor soporte al desarrollador hispanohablante que esta interesado en iniciar un proyecto en Rust.

RainbowMod es compatible con plugins desarrollados Python, C# y JavaScript

## Compilación
1. Si vas a modificar solo el proyecto de RainbowMod saltea todos los pasos y solo compila, en cambio si lo que deseas es modificar el Patcher de RainbowMod deberás seguir todos los pasos
2. Ejecuta la solución (SLN), y compila RainbowModPatcher
3. Por favor vaya a Raimbow\References\CleanPatchTargetDlls\ y lea el archivo Leeme.txt.
4. Selecciona los archivos a parchar (Assembly-CSharp.dll, uLink.dll, Facepunch.MeshBatch.dll)
Copia y pega los archivos en la carpeta de salida del proyecto. Necesitará algunos plugins de referencia como UnityEngine.dll
5. Ejecuta el Patcher e ingresa el numero 0. Si todo salió bien los archivos serán parcheados
Si algo salio mal intenta ver los logs de Patcher
6. Copia los 3 dll y pegalos en la carpeta \RaimbowMod\References\PatchedRustDlls\ sobreescribiendo los existentes.
7. Puedes compilar todos los proyectos utilizando JetBrains Rider, o Visual Studio segun lo prefieras.


***
###### Basado en Fougerite by EquiFox & xEnt
###### RainbowMod con ♥ by FR0Z3NH34R7

