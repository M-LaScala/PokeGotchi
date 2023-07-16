# PokéGotchi

Pacote nugt rest charp para consumir api rest

JSON significa JavaScript Object Notation e é um padrão aberto para representar dados como atributos com valores.
Basicamente o JSON se baseia na notação NOME : VALOR, onde NOME pode ser o nome que você deseja usar para identificar um objeto e VALOR o valor deste objeto.

Model representa a estrutura do json
Em resumo, a serialização envolve a conversão de um objeto em uma representação de dados, enquanto a desserialização envolve a reconstrução de um objeto a partir de uma representação serializada. 
Esses processos são úteis para armazenar, transmitir e compartilhar objetos complexos entre diferentes sistemas e tecnologias.

Site usado para gerar a mensagem do menu
http://patorjk.com/software/taag/#p=display&f=Big&t=Tamagotchi%0A

usado para deixar a primeira letra em maiusculo 
CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mascote.Nome)
https://pt.stackoverflow.com/questions/247/como-capitalizar-nomes-em-c


O padrão MVC. 
MVC é o acrônimo de Model (modelo), View (visão), Controller (controlador), e é um padrão de projetos de software.
Model: Modelo e acesso a dados. São essas classes que definirão os padrões dos dados e terão acesso ao banco de dados.
View: A view corresponde ao Front-end e é onde você coloca as suas telas, como, por exemplo, o HTML em casos de aplicações web, 
janelas em casos de aplicações desktop e, no seu caso, a sua classe de comunicação com o usuário.
Controller: Essa é a parte lógica da aplicação. Essa camada é onde se aplicam as regras da aplicação e onde se relacionam os modelos e as views.
