# Relatório: Desenvolvimento do Math Game

## Introdução
O objetivo desta apresentação é compartilhar a experiência do grupo no desenvolvimento de um aplicativo mobile utilizando o framework MAUI. O Math Game é um jogo de perguntas e respostas que desafia o jogador a resolver adições matemáticas. A cada resposta correta, o jogador ganha pontos e avança no jogo.

## Versões Utilizadas
[Versões](Versões.md)


## Principais Conceitos
- O .NET MAUI (“Multi-platform App UI”) é um framework para a criação de aplicativos multiplataforma.
- Ele permite o desenvolvimento de aplicativos para Android, iOS, Windows e macOS a partir de um único código-fonte.
- Utiliza C# e XAML para definir a interface e a lógica da aplicação.

## Instalação
- Para iniciar o desenvolvimento com MAUI, é necessário instalar o .NET SDK, o Visual Studio com o suporte a MAUI e configurar um emulador ou dispositivo físico.

## Criação de Projetos e Componentes
- Criamos o projeto utilizando o comando:
  ```sh
  dotnet new maui -n MathGame
  ```
- Implementamos a interface principal do jogo em XAML e a lógica em C#.

## Principais Comandos
- Criar um novo projeto MAUI:
  ```sh
  dotnet new maui -n NomeDoProjeto
  ```
- Executar a aplicação em um emulador ou dispositivo:
  ```sh
  dotnet build
  dotnet run
  ```
- Gerar o APK para instalação:
  ```sh
  dotnet publish -c Release -f net7.0-android /p:AndroidPackageFormat=apk
  ```



## Principais Dificuldades
- Configuração do ambiente de desenvolvimento.
- Compatibilidade do MAUI com diferentes dispositivos.
- Processo de geração do APK para distribuição.

## Principais Soluções
- Definir a variavel de ambiente adb.
- Configurar o MAUI para VS code (extensões).
- Instalar o OpenJDK.
- Baixar um emulador com o android studio.
- Alterar o csproj para compilar no Android e no Windows.

## Instalação no Celular
- O APK gerado foi instalado diretamente no aparelho sem a necessidade de publicação na Play Store.

[Passo a passo](APK.md)

## Tela Principal
*Abaixo está a imagem da tela principal do jogo:*

![Imagem da tela principal do Math Game](./Images/Captura%20de%20tela%202025-02-19%20163035.png)

## Conclusão
O desenvolvimento do Math Game foi uma experiência enriquecedora para o grupo. Apesar dos desafios enfrentados na configuração do ambiente e na geração do APK, conseguimos construir um jogo funcional e aprimorar nosso conhecimento sobre desenvolvimento mobile com MAUI.

