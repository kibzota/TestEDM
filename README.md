# TestEDM

## Respostas:

### 1: 
```
A resposta para a primeira questão encontra-se na pasta TestEDM
```
 
### 2:
  ```sql
   Select
    ReportsTo as Reportado, count(*) as Reportantes, avg(Age) as Idade
  From
    tblHierarquia 
  Where
    ReportsTo is not null
  Group by
    ReportsTo
  Order by ReportsTo asc
  ```
  
### 3a: 
  ```sql
Select
    Veiculo.placa, Cliente.nome 
From Veiculo
Inner Join Cliente on Veiculo.Cliente_cpf = Cliente.cpf
  ```
  
### 3b: 
  ```sql
Select
    Patio.ender as Endereco,
    Estaciona.dtEntrada as DataEntrada,
    Estaciona.dtSaida as DataSaida
from Estaciona
inner Join Patio on Estaciona.Patio_num = Patio.num
Where Estaciona.Veiculo_placa = 'BTG-2022'
  ```
  
 ### 4:
 ``` 
 B
 ```
  ### 5:
 ``` 
 B
 ```
  ### 6:
 ``` 
 A
 ```
  ### 7:
 ``` 
 D
 ```
