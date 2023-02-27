#Nome do arquivo deve ser Dockerfile
#Imagem para se basear
FROM mcr.microsoft.com/dotnet/aspnet:7.0

#Versao e descricao definida para a imagem
LABEL version="1.0.1" Description="Aplication ASP.NET CORE 7.0 MVC"

#Copiando os arquivos da pasta dist para uma pasta dentro do container chamada app
COPY dist /app

#Define o diretorio de trabalho para o container, a partir disso nao precisa especificar o caminho completo para o diretorio de trabalho
WORKDIR /app

#Expor porta 80 para trafego tcp
EXPOSE 80/tcp

#Executa o comando dotnet no arquivo mvc.dll
ENTRYPOINT [ "dotnet", "mvc.dll" ]