using System;

class MainClass {
  public static void Main (string[] args) {
    /*
    7- A  lanchonete  Gostosura  vende  apenas  um  tipo  de  sanduíche,  cujo  recheio
    inclui  duas  fatias  de  queijo, uma fatia de presunto e uma rodela de hambúrguer.
    Sabendo que cada fatia de queijo ou presunto pesa 50 gramas,  e  que  a  rodela  
    de  hambúrguer  pesa  100  gramas,  faça  um  algoritmo  em  que  o  dono  forneça
    a quantidade  de  sanduíches  a  fazer,  e  a  máquina  informe  as  quantidades
    (em  quilos)  de  queijo,  presunto  e carne necessários para a compra.
    */

    Console.WriteLine ("Digite quantos sanduíches serão preparados");
    float qtdSanduiches = float.Parse(Console.ReadLine());

    float queijo = 0.1f * qtdSanduiches;
    float presunto = 0.05f * qtdSanduiches;
    float hamburguer = 0.1f * qtdSanduiches;

    Console.WriteLine ($"\nSerá necessário:\n\n {queijo}kg de queijo\n {presunto}kg de presunto\n {hamburguer}kg de hambúrguer\n ");
  }
}