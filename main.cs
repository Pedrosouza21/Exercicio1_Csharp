 Using System;
  Class MainClass 
 {
 Public static void Main (string[] args) 
 {
 Int[] pessoas = new int[7];
 Double[] quilos = new double[7];
 Int idade=0, peso=0;
 Double ma=0, soma=0, med=0;
 Do{
 Do{
 Console.Write(“Digite {0}ª Idade: “, 
  idade+1);
 Pessoas[idade] = 
 int.Parse(Console.ReadLine());
 }
 While(pessoas[idade]<0);
 Idade++;
 Do{
  Console.Write(“Digite {0}º Peso: “, 
  peso+1);
 Quilos[peso] = 
 double.Parse(Console.ReadLine());
 }
 While(quilos[peso]<0);
 Peso++;
 } While(idade<7 && peso<7)
 For(int i=0; i<7; i++){
 Soma += pessoas[i];
 Med = soma / 7;
 }
   Console.WriteLine(“\nA média das 
  Idades é: {0:f2}”, media);
 For(int j=0; j<7; j++){
 If(quilos[j]>90.01){
 Maior++;
 }
 }
 Console.WriteLine(“Existem {0} 
 pessoas com mais de 90 quilos”, mai);
 }
