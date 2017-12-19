##### Design Patterns (Padrões de Projeto)     
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 


# Padrão Interpreter 

> Interpreter é um dos padrões de projeto de software, famosos como "Design Patterns", muito utilizado para a resolução de problemas quando a modelagem de sistemas ou softwares. Esse padrão esta incluso na categoria de Padrão Comportamental, ou seja, ele busca solucionar problemas de modelagem que tratam o comportamento de classes.

### Intenção

> Dada uma determinada linguagem, o padrão Interpreter define uma representação para sua gramática juntamente com um interpretador que usa a representação para interpretar sentenças na língua. Ou mapear um domínio para uma língua, a língua para uma gramática e a gramática para um projeto de design hierárquico orientado a objetos.

> Utilizamos o padrão Interpreter quando queremos avaliar uma árvore de expressões. Ex.: expressões matemáticas, DSLs, etc...

### Problema
> O padrão Interpreter busca em geral resolver o seguinte problema: que uma classe de problemas ocorre repetidamente em um domínio bem definido e bem compreendido. Se o domínio for caracterizado como uma linguagem, então os problemas poderiam ser facilmente resolvidos com uma interpretação da engine.

### Estrutura
> O padrão Interpreter sugere modelar o domínio com uma gramática recursiva. Cada regra na gramática é tanto um 'composite' (uma regra que referencia outras regras) ou um 'terminal' (uma folha/nó numa estrutura de árvore). O Interpreter baseia-se na travessia recursiva do padrão Composite para interpretar as 'sentenças' que ele deve processar.
![N|MFYIT](https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Interpreter_design_pattern.png/220px-Interpreter_design_pattern.png)

---

## Installation

- Download the latest .NET Core SDK

* [.NET Core 2.0 SDK](release-notes/download-archives/2.0.3.md)

### Clone

- Clone this repo to your local machine using `https://github.com/BrunoLopes/Xperiments.DesignPatterns.Interpreter`

### Setup



> Restore all the packages first

```shell
$ dotnet restore
```

> now build the project

```shell
$ dotnet build
```
---

## Support

Reach out to me at one of the following places!

- Website:  [![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](http://mfyit.azurewebsites.net)
- Email: emfyit@gmail.com

---

## Donations (Optional)

[![Support via Gratipay](https://cdn.rawgit.com/gratipay/gratipay-badge/2.3.0/dist/gratipay.png)](https://liberapay.com/brunolopes/donate)


---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright MFY IT © 2017  