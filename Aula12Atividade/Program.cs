using Aula12Atividade;

Console.WriteLine("Hello, World!");

Produto caixa = new Produto();

caixa.nome = "Caixa";
caixa.preço = 10.00;
caixa.quantidade = 10;
caixa.descricao = "É uma caixa.";
caixa.status = true;

caixa.mostrar();
caixa.desativar();


Produto celular = new Produto();
celular.nome = "Iphone 666";
celular.preço = 6.666;
celular.quantidade = 666;
celular.descricao = "Vindo diretamente das profundezas do inferno, o Iphone 666 promete entregar o pior desempenho possível";
celular.status = true;

celular.mostrar();
celular.desativar();

Produto carro = new Produto();
carro.nome = "Fiat Dos";
carro.preço = 50.000;
carro.quantidade = 1;
carro.descricao = "É tipo o Fiat uno só que pior";
carro.status= true;

carro.mostrar();
carro.desativar();

caixa.mostrar();
celular.mostrar();
carro.mostrar();
