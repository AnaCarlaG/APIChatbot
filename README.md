# 						API para o Chatbot da Blip
### Sobre

Uma API integrada com a API pública do Github para o retorno de 5 repósitorios mais antigos do user takenet nesse endereço:

* https://github.com/takenet 

>  Ordenados pela data de criação e filtrados por: Linguagem C# e por um termo de busca passado na URL.

E no Bot depois que o usuário digita o termo de busca é exibido a imagem de cada card do carrossel o avatar da Take no GitHub. O título de cada card é o nome completo do repositório, e o subtítulo é a descrição do repositório.

### Tecnologias

* .NET Core

* Bot da Blip criado no portal https://bit.ly/3lYcJTf

  > Para conexão com a API pública do Github foi usada a documentação no site https://docs.github.com/en/rest

### Para executar o Projeto

* É preciso executar o Ngrok e alterar a URL que está em negrito abaixo no passo 2- repository do bot pois o Ngrok funciona com URL dinâmica.

1.  GET DESCRIPTION REPOSITORY GITHUB

**http://93952dc9956a.ngrok.io** /api/Github/description/{{termoBusca}}

2. GET FULLNAME REPOSITORY GITHUB

 **http://93952dc9956a.ngrok.io** /api/Github/fullName/{{termoBusca}}

###	Instalação do Ngrok

#### Ngrok

* Para instalar o Ngrok basta ir no site https://ngrok.com/ e segui o passo a passo da documentação e depois excuta-ló.

#### Ngrok pelo VisualStudio

* No Visual Studio basta depois do comando de adicionar o authtoken da instalação do Ngrok seguindo a documentação, instalar a extension do Ngrok em Extensions > Manage Extensions > Online > Ngrok Extensions.
  * Após a instalação da extensions basta executar a API e clicar em Tools > Start ngrok Tunnel para o Ngrok subir sua aplicação



