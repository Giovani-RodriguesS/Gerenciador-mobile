# Dependencias

## Imagens mostrando as versões de intalação e extensões necessarias

# 1. Pré-requisitos
Windows 10/11 (versão 21H2 ou superior)

VS Code instalado

Conexão com internet

# 2. Instalação do .NET SDK e MAUI
```
# Instale o .NET SDK 8.x
winget install Microsoft.DotNet.SDK.8

# Instale os workloads do MAUI
dotnet workload install maui
```

# 3. Configurar Ambiente Android
## 1. Instale o Android Studio (developer.android.com/studio)

## 2. No Android Studio:

- Abra SDK Manager (Configure > SDK Manager)

- Instale:

  - Android SDK 34 (API 34)

  - Android SDK Build-Tools 34.0.0

  - Android Emulator

  - Android SDK Platform-Tools
## 3. Configure variáveis de ambiente (Windows):
- ANDROID_HOME = C:\Users\[SEU_USUÁRIO]\AppData\Local\Android\Sdk
- ADB = C:\Users\[SEU_USUÁRIO]\AppData\Local\Android\Sdk\adb.exe

# 4. Extensões do VS Code
- C# Dev Kit

- .NET MAUI

-  Pack for Java (Microsoft)
  
# 5. Configurar Emulador Android
## 1. No Android Studio:
- Abra AVD Manager (Configure > AVD Manager)
- Crie um novo dispositivo virtual (ex: Pixel 7, API 34)

# 6. Instalar o Java
- Baixar e instalar o jdk-17

# 7. Configurar o launch.json
- Para executar o .NET MAUI pelo VS Code é necessário configurar o launch.json
```
{
            "name": ".NET MAUI",
            "type": "maui",
            "request": "launch",
            "preLaunchTask": "maui: Build"
}
```

# 8. Instalar o SDKManager
- Baixar via CLI
```
sdkmanager "build-tools;34.0.0"
```


![Extensions](/Images/WhatsApp%20Image%202025-02-18%20at%2009.53.25.jpeg) 

Extensão do VS Code para Java para Android


![Extensions](/Images/csproj.png) Configuração do csproj para rodar o programa


![Extensions](/Images/WhatsApp%20Image%202025-02-18%20at%2009.50.34.jpeg)
Emuladores Android

![Extensions](/Images/WhatsApp%20Image%202025-02-18%20at%2009.49.53.jpeg)
Pacotes e Android SDK

![Extensions](/Images/WhatsApp%20Image%202025-02-18%20at%2009.50.06.jpeg)
Plataformas para Android

![Extensions](/Images/WhatsApp%20Image%202025-02-18%20at%2009.55.28.jpeg)
Configuração do Launch para Depurar o Maui no VS Code