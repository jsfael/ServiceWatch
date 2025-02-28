# ServiceWatch


## Descrição
O **ServiceWatch** é uma aplicação .NET que monitora a disponibilidade de serviços online. Ele solicita ao usuário uma lista de URLs a serem monitoradas e verifica periodicamente se os serviços estão online ou offline.

## Funcionalidades
- Solicita ao usuário as URLs dos serviços a serem monitorados.
- Verifica periodicamente se os serviços estão online.
- Exibe status colorido no console para indicar se um serviço está **online** ou **offline**.

## Tecnologias Utilizadas
- **.NET 9**
- **C#**
- **Microsoft.Extensions.Hosting** para execução de serviços em segundo plano.

## Como Executar o Projeto
### 1. Clonar o Repositório
```bash
 git clone <URL_DO_REPOSITORIO>
 cd ServiceWatch
```

### 2. Restaurar Dependências
```bash
dotnet restore
```

### 3. Compilar o Projeto
```bash
dotnet build
```

### 4. Executar o Projeto
```bash
dotnet run
```

Durante a execução, o programa solicitará ao usuário as URLs dos serviços a serem monitorados. Digite as URLs separadas por vírgulas e pressione **Enter**.

## Estrutura do Projeto
```
ServiceWatch/
│── Program.cs               # Ponto de entrada do programa
│── MonitorService.cs        # Classe que verifica o status das URLs
│── ServicosMonitorados.cs   # Armazena a lista de URLs a serem monitoradas
│── MonitorWorker.cs         # Serviço em segundo plano que monitora os serviços periodicamente
│── ServiceWatch.csproj      # Arquivo de configuração do projeto
```

## Melhorias Futuras
- Adicionar suporte a logs.
- Criar uma interface web para gerenciamento das URLs monitoradas.
- Configurar intervalos de monitoramento personalizados.

## Contribuição
Sinta-se à vontade para contribuir com melhorias. Para isso:
1. Faça um fork do repositório.
2. Crie uma branch para a sua feature (`git checkout -b minha-feature`).
3. Commit suas alterações (`git commit -m 'Adiciona nova funcionalidade'`).
4. Envie para o repositório remoto (`git push origin minha-feature`).
5. Abra um Pull Request.


# ServiceWatch


## Description
**ServiceWatch** is a .NET application that monitors the availability of online services. It prompts the user for a list of URLs to be monitored and periodically checks whether the services are online or offline.

## Features
- Requests the user to input the URLs of the services to be monitored.
- Periodically checks if the services are online.
- Displays colored status in the console to indicate whether a service is **online** or **offline**.

## Technologies Used
- **.NET 9**
- **C#**
- **Microsoft.Extensions.Hosting** for background service execution.

## How to Run the Project
### 1. Clone the Repository
```bash
 git clone <REPOSITORY_URL>
 cd ServiceWatch
```

### 2. Restore Dependencies
```bash
dotnet restore
```

### 3. Build the Project
```bash
dotnet build
```

### 4. Run the Project
```bash
dotnet run
```

During execution, the program will prompt the user to input the URLs of the services to be monitored. Enter the URLs separated by commas and press **Enter**.

## Project Structure
```
ServiceWatch/
│── Program.cs               # Entry point of the program
│── MonitorService.cs        # Class that checks the status of URLs
│── ServicosMonitorados.cs   # Stores the list of URLs to be monitored
│── MonitorWorker.cs         # Background service that periodically monitors the services
│── ServiceWatch.csproj      # Project configuration file
```

## Future Improvements
- Add logging support.
- Create a web interface for managing monitored URLs.
- Configure custom monitoring intervals.

## Contribution
Feel free to contribute improvements. To do so:
1. Fork the repository.
2. Create a branch for your feature (`git checkout -b my-feature`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push to the remote repository (`git push origin my-feature`).
5. Open a Pull Request.
