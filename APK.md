# Gerar e Atualizar um APK do .NET MAUI no Android

## 📌 1️⃣ Gerar o APK
Abra o terminal e vá até a pasta do projeto.
Execute o comando para gerar o APK:

```sh
  dotnet publish -f net8.0-android -c Release -p:AndroidPackageFormat=apk
  ```


## 📌 2️⃣ Transferir o APK para o Celular
- Manualmente via USB

Conecte o celular ao PC via USB.
Copie o APK gerado para uma pasta no celular (exemplo: Download).

- Usando ADB

Se o ADB estiver instalado, use:
Verifique se o dispositivo está conectado:
Envie o APK para o celular:

```sh
  adb install caminho/do/apk.apk
  ```



## 📌 3️⃣ Atualizar o APK no Celular
Caso já tenha o app instalado e queira atualizá-lo sem desinstalar:

```sh
  adb install -r caminho/do/novo_apk.apk
  ```


## 📌 4️⃣ Instalar o APK no Celular (Manual)
No celular, vá até Arquivos → Download.
Toque no APK e selecione "Instalar".
Se necessário, permita a instalação de fontes desconhecidas.

