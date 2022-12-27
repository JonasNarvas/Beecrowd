using System;
using System.Threading.Channels;
using System.Threading.Tasks.Sources;

namespace beecrowd;

public class Projeto
{
    public static void Main(string[] args)
    {
        //1000
        /*Console.WriteLine("Hello World!");
         */

        //1001
        /*int A = Int32.Parse(System.Console.ReadLine().Trim());
        int B = Int32.Parse(System.Console.ReadLine().Trim());
        int X = A + B;
        Console.WriteLine("X = {0}", X, "\n");*/

        //1002
        /* double raio;
        double PI = 3.14159;
        double area;

        raio = double.Parse(Console.ReadLine());
        area = PI * raio * raio;
        Console.WriteLine($"A={area:F4}");*/

        //1003
        /*int num1, num2;
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        int soma = num1 + num2;
        Console.WriteLine($"SOMA = {soma}");*/

        //1004
        /*int num1, num2;
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        int produto = num1 * num2;
        Console.WriteLine($"PROD = {produto}");*/

        //1005
        /*double num1, num2;
        num1 = double.Parse(Console.ReadLine());
        num2 = double.Parse(Console.ReadLine());
        double media = (num1 * 3.5 + num2 * 7.5) / (3.5 + 7.5);
        Console.WriteLine($"MEDIA = {media:F5}");*/

        //1006
        /*double num1, num2, num3;
        num1 = double.Parse(Console.ReadLine());
        num2 = double.Parse(Console.ReadLine());
        num3 = double.Parse(Console.ReadLine());
        double media = (num1 * 2 + num2 * 3 + num3 * 5) / (2 + 3 + 5);
        Console.WriteLine($"MEDIA = {media:F1}");*/

        //1007
        /*int num1, num2, num3, num4;
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());
        num4 = int.Parse(Console.ReadLine());
        int diferenca = (num1 * num2) - (num3 * num4);
        Console.WriteLine($"DIFERENCA = {diferenca}");*/

        //1008
        /*int numEmpregado, horasTrab;
        double pagamentoHora, sal;
        numEmpregado = int.Parse(Console.ReadLine());
        horasTrab = int.Parse(Console.ReadLine());
        pagamentoHora = double.Parse(Console.ReadLine());
        sal = horasTrab * pagamentoHora;
        Console.WriteLine($"NUMBER = {numEmpregado}");
        Console.WriteLine($"SALARY = U$ {sal:F2}");*/

        //1009
        /*string nomeVendedor;
        double valorVendas, salFixo;
        nomeVendedor = Console.ReadLine();
        salFixo = double.Parse(Console.ReadLine());
        valorVendas = double.Parse(Console.ReadLine());
        double salTotal = salFixo + (valorVendas * 0.15);
        Console.WriteLine($"TOTAL = R$ {salTotal:F2}");*/

        //1010
        /*int codProd1, numUni1, codProd2, numUni2;
         double valorProd2, valorProd1;
         string[] teste = Console.ReadLine().Split(' ');
         codProd1 = int.Parse(teste[0]);
         numUni1 = int.Parse(teste[1]);
         valorProd1 = double.Parse(teste[2]);
         teste = Console.ReadLine().Split(' ');
         codProd2 = int.Parse(teste[0]);
         numUni2 = int.Parse(teste[1]);
         valorProd2 = double.Parse(teste[2]);
         double vlrTotal = numUni1 * valorProd1;
         double vlrTotal2 = numUni2 * valorProd2;
         double somaTotal = vlrTotal + vlrTotal2;
         Console.WriteLine($"VALOR A PAGAR: R$ {somaTotal:F2}");*/

        //1011
        /*double raio;
        double PI = 3.14159;
        double volume;

        raio = double.Parse(Console.ReadLine());
        volume = (4.0/3.0) * PI * raio * raio * raio;
        Console.WriteLine($"VOLUME = {volume:F3}");*/

        //1012
        /*float lado1, lado2, lado3;
        double PI = 3.14159;
        string[] array = Console.ReadLine().Split(' ');
        lado1 = float.Parse(array[0]);
        lado2 = float.Parse(array[1]);
        lado3 = float.Parse(array[2]);
        double areaTriangulo = (lado1 * lado3)/2;
        double raioCirculo = PI * lado3 * lado3;
        double areaTrapezio = ((lado1 + lado2) * lado3) / 2;
        double areaQuadrado = lado2 * lado2;
        double areaRetangulo = lado1 * lado2;
        Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
        Console.WriteLine($"CIRCULO: {raioCirculo:F3}");
        Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
        Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
        Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");*/

        //1013
        /*int valor1, valor2, valor3;
        string[] array = Console.ReadLine().Split(' ');
        valor1= int.Parse(array[0]);
        valor2= int.Parse(array[1]);
        valor3= int.Parse(array[2]);
        int maiorAB= (valor1+valor2 +Math.Abs(valor1 - valor2))/2;
        int maiorAC= (maiorAB+valor3+Math.Abs(maiorAB- valor3))/2;
        Console.WriteLine($"{maiorAC} eh o maior");*/

        //1014
        /*int distancia = int.Parse(Console.ReadLine()); 
        float litros = float.Parse(Console.ReadLine());   
        double kmPorL = distancia / litros;
        Console.WriteLine($"{kmPorL:F3} km/l");*/

        //1015
        /*double x1, y1, x2, y2, distancia;
        string[] array = Console.ReadLine().Split(' ');
        string[] array2 = Console.ReadLine().Split(' ');
        x1 = double.Parse(array[0]);
        y1= double.Parse(array[1]);
        x2= double.Parse(array2[0]);
        y2= double.Parse(array2[1]);
        distancia = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
        Console.WriteLine($"{distancia:F4}");*/

        //1016
        /*int tempo, distancia;
        distancia = int.Parse(Console.ReadLine());
        tempo = (60 * distancia) / 30;
        Console.WriteLine($"{tempo} minutos");*/

        //1017
        /*int tempoGasto, velMedia;
        double litros;
        tempoGasto = int.Parse(Console.ReadLine());
        velMedia = int.Parse(Console.ReadLine());
        litros =   (tempoGasto*velMedia)/12.0;
        Console.WriteLine($"{litros:F3}");*/

        //1018
        /*int[] notas = {100,50,20,10,5,2,1 };
        int valor = int.Parse(Console.ReadLine());
        int quantidadeNotas;

        Console.WriteLine(valor);
        for (int i=0; i < notas.Length; i++)
        {
            quantidadeNotas = (valor / notas[i]);
            Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {notas[i]},00");
            valor -= quantidadeNotas * notas[i];

        }*/

        //1019
        /*int duraSegundos,horas,minutos,segundos;
        duraSegundos= int.Parse(Console.ReadLine());
        horas = duraSegundos / 3600;
        minutos = duraSegundos % 3600 / 60;
        segundos = duraSegundos % 3600 % 60;
        Console.WriteLine($"{horas}:{minutos}:{segundos}");*/

        //1020
        /*int idade, anos, meses, dias;
        idade = int.Parse(Console.ReadLine());
        anos = idade / 365;
        meses = idade % 365 / 30;
        dias = idade % 365 % 30;
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");*/

        //1021
        /* double valor;
         int nota100, nota50, nota20, nota10, nota5, nota2 ;

         valor = double.Parse(Console.ReadLine());

         nota100 = (int)(valor / 100);
         valor -= 100 * nota100;

         nota50 = (int)(valor / 50);
         valor -= 50 * nota50;

         nota20 = (int)(valor / 20);
         valor -= 20 * nota20;

         nota10 = (int)(valor / 10);
         valor -= 10 * nota10;

         nota5 = (int)(valor / 5);
         valor -= 5 * nota5;

         nota2 = (int)(valor / 2);
         valor -= 2 * nota2;

         int moeda100, moeda50, moeda25, moeda10, moeda5;
         valor *= 100;

         moeda100 = (int)(valor / 100);
         valor -= 100 * moeda100;

         moeda50 = (int)(valor / 50);
         valor -= 50 * moeda50;

         moeda25 = (int)(valor / 25);
         valor -= 25 * moeda25;

         moeda10 = (int)(valor / 10);
         valor -= 10 * moeda10;

         moeda5 = (int)(valor / 5);
         valor -= 5 * moeda5;

         Console.WriteLine("NOTAS:");
         Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
         Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
         Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
         Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
         Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
         Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
         Console.WriteLine("MOEDAS:");
         Console.WriteLine($"{moeda100} moeda(s) de R$ 1.00");
         Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
         Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
         Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
         Console.WriteLine($"{moeda5} moeda(s) de R$ 0.05");
         Console.WriteLine($"{valor:F0} moeda(s) de R$ 0.01");*/

        //1035
        /*int vlr1, vlr2, vlr3, vlr4;
        string[] array = Console.ReadLine().Split(' ');
        vlr1 = int.Parse(array[0]);
        vlr2= int.Parse(array[1]);
        vlr3 = int.Parse(array[2]);
        vlr4= int.Parse(array[3]);    

        if(( vlr2 > vlr3) && (vlr4 > vlr1) && (vlr3 + vlr4) > (vlr1 + vlr2) && (vlr3 > 0) && (vlr4 > 0) && (vlr1 % 2 == 0) )
        {
            Console.WriteLine("Valores aceitos");
        }
        else 
        {
            Console.WriteLine("Valores nao aceitos");
        }*/

        //1036
        /*double a, b, c, bhaskara1, bhaskara2, divisao, delta, raiz;
        string[] array = Console.ReadLine().Split(' ');
        a = double.Parse(array[0]);
        b = double.Parse(array[1]);
        c= double.Parse(array[2]);
        divisao = 2 * a;
        delta = (b * b) - (4 * a * c);
        raiz = Math.Sqrt(delta);
        bhaskara1 = ((-(b) + raiz) / (divisao));
        bhaskara2 = ((-(b) - raiz) / (divisao));
        if (divisao == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
           
            
            Console.WriteLine($"R1 = {bhaskara1:F5}");
            Console.WriteLine($"R2 = {bhaskara2:F5}");
        }*/

        //1037
        /*double valor;
        valor = double.Parse(Console.ReadLine());
        if (valor >= 0 && valor <= 25.00000) Console.WriteLine("Intervalo [0,25]");
        else if (valor > 25.00001 && valor <= 50.00000) Console.WriteLine("Intervalo (25,50]");
        else if (valor > 50.00001 && valor <= 75.00000) Console.WriteLine("Intervalo (50,75]");
        else if (valor > 75.00001 && valor <= 100) Console.WriteLine("Intervalo (75,100]");
        else if(valor < 0 || valor > 100) Console.WriteLine("Fora de intervalo");*/

        //1038
        /*int code, qtd;
        double preco;
        string[] array = Console.ReadLine().Split(' ');
        code = int.Parse(array[0]);
        qtd = int.Parse(array[1]);
        if (code == 1)
        {
            preco = 4.00 * qtd;
            Console.WriteLine($"Total: R$ {preco:F2}");
        }
        else if (code == 2)
        {
            preco = 4.50 * qtd;
            Console.WriteLine($"Total: R$ {preco:F2}");
        }
        else if (code == 3)
        {
            preco = 5.00 * qtd;
            Console.WriteLine($"Total: R$ {preco:F2}");
        }
        else if (code == 4)
        {
            preco = 2.00 * qtd;
            Console.WriteLine($"Total: R$ {preco:F2}");
        }
        else if (code == 5) {
            preco = 1.50 * qtd;
            Console.WriteLine($"Total: R$ {preco:F2}");
        }*/

        //1040
        /*double n1, n2, n3, n4, media, exame, media2;
        string[] array = Console.ReadLine().Split(' ');
        n1 = double.Parse(array[0]);
        n2= double.Parse(array[1]);
        n3= double.Parse(array[2]);
        n4= double.Parse(array[3]);
        media = Math.Truncate((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4*1)) / 10;
        if (media >= 7)
        {
            Console.WriteLine($"Media: {media:F1}");
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5)
        {
            Console.WriteLine($"Media: {media:F1}");
            Console.WriteLine("Aluno reprovado.");
        }
        else if (media >= 5 && media <= 6.9)
        {
            Console.WriteLine($"Media: {media:F1}");
            Console.WriteLine("Aluno em exame.");
            exame = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {exame:F1}");
            media = (media + exame) / 2;
            media = Math.Round(media, 1);
            if (media >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine($"Media final: {media:F1}");
            }
            else 
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Media final: {media:F1}");
            }
            
        }*/

        //1041
        /*double abscissa, ordenada;
        string[] array = Console.ReadLine().Split(' ');
        abscissa = double.Parse(array[0]);
        ordenada = double.Parse(array[1]);
        if (abscissa == 0.0 && ordenada == 0.0)
        {
            Console.WriteLine("Origem");
        }
        else if (abscissa == 0.0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (ordenada == 0.0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (abscissa > 0.0 && ordenada > 0.0)
        {
            Console.WriteLine("Q1");
        }
        else if (abscissa < 0.0 && ordenada > 0.0)
        {
            Console.WriteLine("Q2");
        }
        else if (abscissa < 0.0 && ordenada < 0.0)
        {
            Console.WriteLine("Q3");
        }
        else if (abscissa > 0.0 && ordenada < 0.0) Console.WriteLine("Q4");*/

        //1042
        /*string[] array = Console.ReadLine().Split(' ');
        int a = int.Parse(array[0]);
        int b = int.Parse(array[1]);
        int c = int.Parse(array[2]);
        int d = a;
        int e = b;
        int f = c;
        if (d > e && d > f)
        {
            int aux = d;
            d = f;
            f = aux;
        }
        else if (e > d && e > f)
        {
            int aux = e;
            e = f;
            f = aux;
        }

        if (d > e)
        {
            int aux = d;
            d = e;
            e = aux;
        }

        Console.WriteLine($"{d}\n{e}\n{f}\n\n{a}\n{b}\n{c}");*/

        //1043
        /*double lado1, lado2, lado3,perimetro, area;
        string[] array = Console.ReadLine().Split(' ');
        lado1= double.Parse(array[0]);
        lado2= double.Parse(array[1]);
        lado3= double.Parse(array[2]);
        if((lado1 + lado2) > lado3 && (lado1 + lado3) > lado2 && (lado2 + lado3) > lado1)
        {
            perimetro = lado1 + lado2 + lado3;
            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }
        else
        {
            area = ((lado1 + lado2) * lado3) / 2;
            Console.WriteLine($"Area = {area:F1}");
        }*/

        //1044
        /*int vlr1, vlr2;
        string[] array = Console.ReadLine().Split(' ');
        vlr1= int.Parse(array[0]);
        vlr2= int.Parse(array[1]);
        if ((vlr2 % vlr1) == 0 ||(vlr1 % vlr2) == 0) Console.WriteLine("Sao Multiplos");
        else Console.WriteLine("Nao sao Multiplos");*/

        //1045
        /*string[] linha = Console.ReadLine().Split();
        double vlr1 = double.Parse(linha[0]),
        vlr2 = double.Parse(linha[1]),
        vlr3 = double.Parse(linha[2]);

        if (vlr3 > vlr2 && vlr3 > vlr1)
        {
            double aux = vlr3;
            vlr3 = vlr1;
            vlr1 = aux;
        }
        else if (vlr2 > vlr1 && vlr2 > vlr3)
        {
            double aux = vlr2;
            vlr2 = vlr1;
            vlr1 = aux;
        }

        if (vlr3 > vlr2)
        {
            double aux = vlr3;
            vlr3 = vlr2;
            vlr2 = aux;
        }

        if (vlr1 >= vlr2 + vlr3)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
            return;
        }

        if ((vlr1 * vlr1) == (vlr2 * vlr2) + (vlr3 * vlr3))
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if ((vlr1 * vlr1) > (vlr2 * vlr2) + (vlr3 * vlr3))
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }

        if (vlr1 == vlr2 && vlr2 == vlr3)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (vlr1 == vlr2 || vlr2 == vlr3 || vlr1 == vlr3)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }*/

        //1046
        /*int comeco, fim, horas;
        horas = 24;
        string[] array = Console.ReadLine().Split(' ');
        comeco = int.Parse(array[0]);
        fim = int.Parse(array[1]);  
        if( comeco > fim)
        {
            horas = horas - comeco + fim;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S)");
        }else if (fim > comeco)
        {
            horas = fim - horas + horas - comeco;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S)");
        }else
        {
            Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
        }*/

        //1047
        /*int horaComeco, minComeco, horaFim, minFim, horas, minutos;
        string[] array = Console.ReadLine().Split(' ');
        horaComeco = int.Parse(array[0]);
        minComeco = int.Parse(array[1]);
        horaFim = int.Parse(array[2]);
        minFim = int.Parse(array[3]);
        if ((horaComeco == horaFim) && (minComeco == minFim))
        {
            horas = 24; minutos = 0;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
        else if ((horaComeco == horaFim) && (minComeco > minFim))
        {
            horas = 23; minutos = 60 - minComeco + minFim;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
        else if (horaComeco == horaFim)
        {
            horas = 0; minutos = minFim - minComeco;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
        else if ((horaComeco <= horaFim) && (minComeco <= minFim))
        {
            horas = horaFim - horaComeco; minutos = minFim - minComeco;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
        else if (horaFim > horaComeco && minFim < minComeco)
        {
            horas = horaFim - horaComeco - 1; minutos = 60 - minComeco + minFim;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
        else if (horaComeco > horaFim && minComeco > minFim)
        {
            horas = 23 - horaComeco + horaFim; minutos = 60 - minComeco + minFim;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
        else if (horaComeco > horaFim && minComeco <= minFim)
        {
            horas = 24 - horaComeco + horaFim; minutos = minFim - minComeco;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }*/

        //1048
        /*double sal = double.Parse(Console.ReadLine());
        if (sal >= 0 && sal <= 400.00)
        {
            double prcnt = 15.00;
            double aumento = (sal * prcnt) / 100.00;
            double salAumento = sal + aumento;
            Console.WriteLine($"Novo salario: {salAumento:F2}");
            Console.WriteLine($"Reajuste ganho: {aumento:F2}");
            Console.WriteLine("Em percentual: 15 %");
        }
        else if (sal > 400.00 && sal <= 800.00)
        {
            double prcnt = 12.0;
            double aumento = (sal * prcnt) / 100.00;
            double salAumento = sal + aumento;
            Console.WriteLine($"Novo salario: {salAumento:F2}");
            Console.WriteLine($"Reajuste ganho: {aumento:F2}");
            Console.WriteLine("Em percentual: 12 %");
        }
        else if (sal > 800.00 && sal <= 1200.00)
        {
            double prcnt = 10.00;
            double aumento = (sal * prcnt) / 100;
            double salAumento = sal + aumento;
            Console.WriteLine($"Novo salario: {salAumento:F2}");
            Console.WriteLine($"Reajuste ganho: {aumento:F2}");
            Console.WriteLine("Em percentual: 10 %");
        }
        else if (sal > 1200.00 && sal <= 2000.00)
        {
            double prcnt = 7.00;
            double aumento = (sal * prcnt) / 100;
            double salAumento = sal + aumento;
            Console.WriteLine($"Novo salario: {salAumento:F2}");
            Console.WriteLine($"Reajuste ganho: {aumento:F2}");
            Console.WriteLine("Em percentual: 7 %");
        }
        else if (sal > 2000.00)
        {
            double prcnt = 4.00;
            double aumento = (sal * prcnt) / 100;
            double salAumento = sal + aumento;
            Console.WriteLine($"Novo salario: {salAumento:F2}");
            Console.WriteLine($"Reajuste ganho: {aumento:F2}");
            Console.WriteLine("Em percentual: 4 %");
        }*/

        //1049
        /*string vertebrado, invertebrado, ave, mamifero, inseto, anelideo, carnivoro, onivoro, herbivoro, hematofago;
        string input = Console.ReadLine();
        string input2 = Console.ReadLine();
        string input3 = Console.ReadLine();
        if (input.Contains("vertebrado"))
        {
            if (input2.Contains("ave"))
            {
                if (input3.Contains("carnivoro"))
                {
                    Console.WriteLine("aguia");
                }
                else if (input3.Contains("onivoro")) Console.WriteLine("pomba");
            }
            else if (input2.Contains("mamifero"))
            {
                if (input3.Contains("onivoro"))
                {
                    Console.WriteLine("homem");
                }
                else if (input3.Contains("herbivoro")) Console.WriteLine("vaca");
            }
        }
        if (input.Contains("invertebrado"))
        {
            if (input2.Contains("inseto"))
            {
                if (input3.Contains("hematofago"))
                {
                    Console.WriteLine("pulga");
                }
                else if (input3.Contains("herbivoro")) Console.WriteLine("lagarta");
            }
            else if (input2.Contains("anelideo"))
            {
                if (input3.Contains("hematofago"))
                {
                    Console.WriteLine("sanguessuga");
                }
                else if (input3.Contains("onivoro")) Console.WriteLine("minhoca");
            }
        }*/

        //1050
        /*int ddd = int.Parse(Console.ReadLine());
        if (ddd == 11) Console.WriteLine("Sao Paulo");
        else if (ddd == 19) Console.WriteLine("Campinas");
        else if (ddd == 21) Console.WriteLine("Rio de Janeiro");
        else if (ddd == 27) Console.WriteLine("Vitoria");
        else if (ddd == 31) Console.WriteLine("Belo Horizonte");
        else if (ddd == 32) Console.WriteLine("Juiz de Fora");
        else if (ddd == 61) Console.WriteLine("Brasilia");
        else if (ddd == 71) Console.WriteLine("Salvador");
        else Console.WriteLine("DDD nao cadastrado")*/

        //1051
        /*double sal = double.Parse(Console.ReadLine());
        if (sal > 2000.00 && sal <= 3000.00)
        {
            double imposto = ((sal - 2000.00) * 0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else if (sal > 3000.00 && sal <= 4500.00)
        {
            double imposto = ((sal - 3000.00) * 0.18 + 1000.00 * 0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else if (sal > 4500.00)
        {
            double imposto = ((sal - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else Console.WriteLine("Isento");*/

        //1052
        /*int mes = int.Parse(Console.ReadLine());
        if (mes == 1) Console.WriteLine("January");
        else if (mes == 2) Console.WriteLine("February");
        else if (mes == 3) Console.WriteLine("March");
        else if (mes == 4) Console.WriteLine("April");
        else if (mes == 5) Console.WriteLine("May");
        else if (mes == 6) Console.WriteLine("June");
        else if (mes == 7) Console.WriteLine("July");
        else if (mes == 8) Console.WriteLine("August");
        else if (mes == 9) Console.WriteLine("September");
        else if (mes == 10) Console.WriteLine("October");
        else if (mes == 11) Console.WriteLine("November");
        else if (mes == 12) Console.WriteLine("December");*/

        //1059
        /*int num = 1;
        for(int i = 0; i <= 100; i++)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
            num++;
        }*/

        //1060
        /*int count = 0;
        double a;
        for(int i = 0; i<6; i++) {
            a = double.Parse(Console.ReadLine());
            if(a > 0)
            {
                count++;
            }
        }
        Console.WriteLine($"{count} valores positivos");
        */

        //1064
        /*int count = 0;
        double input;
        double media = 0;
        
        for (int i = 0; i < 6; i++)
        {
            input = double.Parse(Console.ReadLine());
            if (input > 0)
            {
                media = media + input;
                count++;
            }
            
        }
        media = media / count;
        Console.WriteLine($"{count} valores positivos");
        Console.WriteLine($"{media:F1}");*/

        //1065
        /*int input;
        int pares = 0;

        for (int i = 0; i < 5; i++)
        {
            input = int.Parse(Console.ReadLine());
            if (input %2 == 0)
            {
                pares++;
            }

        }
        Console.WriteLine($"{pares} valores pares");*/

        //1066
        /*int input;
        int pares = 0, positivos = 0, negativos = 0, impares = 0 ;

        for (int i = 0; i < 5; i++)
        {
            input = int.Parse(Console.ReadLine());
            if(input == 0)
            {
                pares++;
            }
            else if (input > 0)
            {
                positivos++;
                if(input%2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                
            }else if( input < 0)
            {
                negativos++;
                if(input%2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

        }
        Console.WriteLine($"{pares} valor(es) par(es)");
        Console.WriteLine($"{impares} valor(es) impar(es)");
        Console.WriteLine($"{positivos} valor(es) positivo(s)");
        Console.WriteLine($"{negativos} valor(es) negativo(s)");*/

        //1067
        /*int num = 1;
        for (int i = 0; i <= 100; i++)
        {
            if (num % 2 == 1)
            {
                Console.WriteLine(num);
            }
            num++;
        }*/

        //1070
        /*int num = int.Parse(Console.ReadLine());
        int impar = 6;
        for( int i = num; i< (num+(impar*2)); i = i + 2)
        {
            int aux;
            if(i%2 ==0)
            {
                aux = i + 1;
                Console.WriteLine($"{aux}");
            }
            else
            {
                aux = i;
                Console.WriteLine($"{aux}");
            }
        }*/

        //1071
        /*int vlr1 = int.Parse(Console.ReadLine());
          int vlr2 = int.Parse(Console.ReadLine());
          int soma = 0;

          if(vlr1 > vlr2)
          {
              for(int i =vlr1 -1; i > vlr2; i--)
              {
                  if(i %2 !=0)
                  {
                      soma += i;
                  }
              }
          }
          else
          {
              for (int i = vlr2 - 1; i > vlr1; i--)
              {
                  if (i % 2 != 0)
                  {
                      soma += i;
                  }
              }
          }

          Console.WriteLine(soma) ;*/

        //1072
        /*int vlr1 = int.Parse(Console.ReadLine());
        int count = 0;
        int count2 = 0;
        for(int i = 0; i < vlr1; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if(a >= 10 && a <= 20)
            {
                 count++;
            }
            else
            {
                count2++;
            }
        }
        Console.WriteLine($"{count} in");
        Console.WriteLine($"{count2} out");*/

        //1073
        /*int vlr= int.Parse(Console.ReadLine());
        for(int i =1; i<= vlr; i++)
        {
            if(Math.Pow(i,2) %2 == 0)
            {
                int teste = (int)Math.Pow(i,2);
                Console.WriteLine($"{i}^2 = {teste}");
            }
        }*/

        //1074
        /*int vlr = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < vlr; i++)
        {
            int aux = int.Parse(Console.ReadLine());
            if(aux > 0)
            {
                if(aux %2 != 0) {
                    
                    Console.WriteLine("ODD POSITIVE");
                }
                else
                {
                    Console.WriteLine("EVEN POSITIVE");
                }

            }
            else if(aux < 0)
            {
                if(aux %2 ==0)
                {

                    Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
            else
            {
                Console.WriteLine("NULL");
            }
        }*/

        //1075
        /*int vlr = int.Parse(Console.ReadLine());
        for(int i =0; i < 10000; i++)
        {
            if(i%vlr ==2)
            {
                Console.WriteLine(i);
            }
        }*/

        //1078
        /*int vlr = int.Parse(Console.ReadLine());
        for(int i=1; i<=10;i++) {
            int aux = i * vlr;
            Console.WriteLine($"{i} x {vlr} = {aux}");
        }*/

        //1079
        /*int vlr = int.Parse(Console.ReadLine());
        for(int i=0; i<vlr; i++)
        {
            
                string[] array = Console.ReadLine().Split(' ');
                double nota1 = double.Parse(array[0]),
                    nota2 = double.Parse(array[1]),
                    nota3 = double.Parse(array[2]);
                double media = ((nota1 * 2.0) + (nota2 * 3.0) + (nota3 * 5.0)) / 10;
                Console.WriteLine($"{media:F1}");
           
            
        }*/

        //1080
        /*int aux = 0;
        int maior=0;
        int index=0;
        for(int i=1; i<=100; i++)
        {
            
             aux = int.Parse(Console.ReadLine());
            
            if(aux > maior )
            {
                maior = aux;
                index = i;
            }

            
        }
        Console.WriteLine(maior);
        Console.WriteLine(index);*/

        //1094
        /*int input = int.Parse(Console.ReadLine());
        double coelho= 0, rato= 0, sapo= 0;
        int tot = 0, i =0;
        for(i =0; i < input; i++)
        {
            string[] array = Console.ReadLine().Split(' ');
            int qtd = int.Parse(array[0]);
            string animal = array[1];
            
            if (animal == "C")
            {
                coelho += qtd;
            }
            else if (animal == "R")
            {
                rato += qtd;
            }
            else if (animal == "S")
            {
                sapo += qtd;
            }
            tot += qtd;
        }
        Console.WriteLine($"Total: {tot} cobaias");
        Console.WriteLine($"Total de coelhos: {coelho}");
        Console.WriteLine($"Total de ratos: {rato}");
        Console.WriteLine($"Total de sapos: {sapo}");
        Console.WriteLine($"Percentual de coelhos: {(coelho*100) / tot:F2} %");
        Console.WriteLine($"Percentual de ratos: {(rato*100) / tot:F2} %");
        Console.WriteLine($"Percentual de sapos: {(sapo * 100) / tot :F2} %");*/

        //1095
        /*int I = 1;
        int J = 60;
        for (int i = 0; i <= 12; i++)
        {
            int[] array = { I, J };
            Console.WriteLine($"I={array[0]} J={array[1]}");
            I += 3;
            J -= 5;
        }*/

        //1096
        /*int I = 1;
        int J = 7;
        int[] array = { I, J };
        Console.WriteLine($"I={array[0]} J={array[1]}");
        for (int i = 0; i < 2; i++)
        {
            J -= 1;
            array[1] =J;
            Console.WriteLine($"I={array[0]} J={array[1]}");
        }
        I += 2;
        J = 7;
        array[0] = I;
        array[1] = J;
        Console.WriteLine($"I={array[0]} J={array[1]}");
        for (int i = 0; i< 2; i++)
        {
            J -= 1;
            array[1] =J;
            Console.WriteLine($"I={array[0]} J={array[1]}");
        }
        I += 2;
        J = 7;
        array[0] = I;
        array[1] = J;
        Console.WriteLine($"I={array[0]} J={array[1]}");
        for (int i = 0; i < 2; i++)
        {
            J -= 1;
            array[1] = J;
            Console.WriteLine($"I={array[0]} J={array[1]}");
        }
        I += 2;
        J = 7;
        array[0] = I;
        array[1] = J;
        Console.WriteLine($"I={array[0]} J={array[1]}");
        for (int i = 0; i < 2; i++)
        {
            J -= 1;
            array[1] = J;
            Console.WriteLine($"I={array[0]} J={array[1]}");
        }
        I += 2;
        J = 7;
        array[0] = I;
        array[1] = J;
        Console.WriteLine($"I={array[0]} J={array[1]}");
        for (int i = 0; i < 2; i++)
        {
            J -= 1;
            array[1] = J;
            Console.WriteLine($"I={array[0]} J={array[1]}");
        }*/

        //1097
        /*int I = 1;
        int J = 7;
        int[] array = { I, J };
        Console.WriteLine($"I={array[0]} J={array[1]}");
        for (int i = 0; i < 2; i++)
        {
            J -= 1;
            array[1] = J;
            Console.WriteLine($"I={array[0]} J={array[1]}");
        }
        I += 2;
        J = 9;
        array[0] = I;
        array[1] = J;
        Console.WriteLine($"I={array[0]} J={array[1]}");
        for (int i = 0; i < 2; i++)
        {
            J -= 1;
            array[1] = J;
            Console.WriteLine($"I={array[0]} J={array[1]}");
        }
        I += 2;
        J = 11;
        array[0] = I;
        array[1] = J;
        Console.WriteLine($"I={array[0]} J={array[1]}");
        for (int i = 0; i < 2; i++)
        {
            J -= 1;
            array[1] = J;
            Console.WriteLine($"I={array[0]} J={array[1]}");
        }
        I += 2;
        J = 13;
        array[0] = I;
        array[1] = J;
        Console.WriteLine($"I={array[0]} J={array[1]}");
        for (int i = 0; i < 2; i++)
        {
            J -= 1;
            array[1] = J;
            Console.WriteLine($"I={array[0]} J={array[1]}");
        }
        I += 2;
        J = 15;
        array[0] = I;
        array[1] = J;
        Console.WriteLine($"I={array[0]} J={array[1]}");
        for (int i = 0; i < 2; i++)
        {
            J -= 1;
            array[1] = J;
            Console.WriteLine($"I={array[0]} J={array[1]}");
        }*/

        //1098
        /*double I = 0;
        double J = 1;
        for (int i = 0; i <= 9; i++)
        {
            Console.WriteLine($"I={Math.Round(I, 1)} J={Math.Round(J, 1)}");
            Console.WriteLine($"I={Math.Round(I, 1)} J={Math.Round(J, 1) + 1}");
            Console.WriteLine($"I={Math.Round(I, 1)} J={Math.Round(J, 1) + 2}");
            I += 0.2;
            J += 0.2;
        }
        Console.WriteLine($"I={2} J={3}");
        Console.WriteLine($"I={2} J={4}");
        Console.WriteLine($"I={2} J={5}");*/

        //1099
        /*int nmbr= int.Parse(Console.ReadLine());
        for (int i =0; i< nmbr; i++)
        {
            string[] array = Console.ReadLine().Split(' ');
            int n1 = int.Parse(array[0]);
            int n2 = int.Parse(array[1]);
            int somaImpar = 0;
            if (n1 < n2)
            {
                for(int j = n1+1; j < n2; j++)
                {
                    if (j % 2 != 0) somaImpar += j;
                    
                }
            }
            else
            {
                for(int j = n2+1;j < n1; j++)
                {
                    if (j % 2 != 0) somaImpar += j;
                }
            }
            Console.WriteLine(somaImpar);
        }*/

        //1101
        /*int vlr1 = 0; int vlr2 = 0;
        do
        {
            
            string[] array = Console.ReadLine().Split(' ');
            vlr1 = int.Parse(array[0]);
            vlr2 = int.Parse(array[1]);
            int teste = 0;
            int soma = 0;
            if (vlr1 <= 0 || vlr2 <= 0) break;
            if (vlr1 > vlr2)
            {
                teste = vlr2;
                vlr2 = vlr1;
                vlr1 = teste;
            }
            for(int i = vlr1; i<=vlr2; i++)
            {
                
                soma += i;
                Console.Write($"{i} ");
            }
            Console.WriteLine($"Sum={soma}");

            
        }while(true);*/

        //1113
        /*int vlr1 = 0; int vlr2 = 0;
        do
        {
            string[] array = Console.ReadLine().Split(' ');
            vlr1 = int.Parse(array[0]);
            vlr2 = int.Parse(array[1]);
            if(vlr1 > vlr2)
            {
                Console.WriteLine("Decrescente");
            }else if(vlr2 > vlr1)
            {
                Console.WriteLine("Crescente");
            }
        } while (vlr1 != vlr2);*/

        //1114
        /*int senha = 0;
        bool correto = true;
        do
        {
           senha = int.Parse(Console.ReadLine());
            if(senha == 2002)
            {
                Console.WriteLine("Acesso Permitido");
                correto = true;
            }
            else
            {
                Console.WriteLine("Senha Invalida");
                correto = false;
            }

        } while (correto == false);*/

        //1115
        /*int x = 0;
        int y = 0;
        do
        {
            string[] array = Console.ReadLine().Split(' ');
            x = int.Parse(array[0]);
            y = int.Parse(array[1]);
            if (x > 0 && y > 0) Console.WriteLine("primeiro");
            else if (x > 0 && y < 0) Console.WriteLine("quarto");
            else if (x < 0 && y > 0) Console.WriteLine("segundo");
            else if (x < 0 && y < 0) Console.WriteLine("terceiro");

        }while(x != 0 && y != 0);*/

        //1116
        /*double divisao;
        int qtd = int.Parse(Console.ReadLine());
        for(int i = 0; i < qtd; i++)
        {
            string[] array = Console.ReadLine().Split(' ');
            double vlr1 = double.Parse(array[0]);
            double vlr2 = double.Parse(array[1]);   
            divisao = vlr1 / vlr2;
            if(vlr2 == 0) Console.WriteLine("divisao impossivel");
            else Console.WriteLine($"{divisao:F1}");
        }*/

        //1117
        /*bool aux = true ; double media = 0;
       do
       {
           double nota1 = double.Parse(Console.ReadLine());
           if(nota1 >= 0&& nota1 <=10)
           {
               do
               {
                   double nota2 = double.Parse(Console.ReadLine());
                   if (nota2 >= 0 && nota2 <= 10) {
                       media = (nota1 + nota2) / 2;
                       Console.WriteLine($"media = {media:F2}");
                       aux = false;
                       }
                   else
                   {
                       Console.WriteLine("nota invalida");

                   }
               } while (aux == true);
           }
           else
           {
               Console.WriteLine("nota invalida");
               aux = true;
           }

       } while (aux == true);*/

        //1118
        /*bool aux = true;bool aux2 = true; double media = 0;
        do
        {
            double nota1 = double.Parse(Console.ReadLine());
            if (nota1 >= 0 && nota1 <= 10)
            {
                do
                {
                    double nota2 = double.Parse(Console.ReadLine());
                    if (nota2 >= 0 && nota2 <= 10)
                    {
                        media = (nota1 + nota2) / 2;
                        Console.WriteLine($"media = {media:F2}");
                        //Console.WriteLine("novo calculo (1-sim 2-nao)");
                        //int teste = int.Parse(Console.ReadLine());
                        int teste = 0;
                        do
                        {
                            Console.WriteLine("novo calculo (1-sim 2-nao)");
                            teste = int.Parse(Console.ReadLine());
                            if (teste == 1)
                            {
                                aux = false; aux2 = true;
                            }
                            else if (teste == 2)
                            {
                                aux = false;
                                aux2 = false;
                            }
                        } while (teste != 1 && teste != 2);
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");

                    }
                } while (aux == true);
            }
            else
            {
                Console.WriteLine("nota invalida");
                aux = true;
            }

        } while (aux2 == true);*/

        //1131
        /*int golGremio = 0; int golInter = 0;int input = 2; int grenal = 0; int gremioWin = 0; int interWin = 0; int empate = 0;
        do
        {
            string[] array = Console.ReadLine().Split(' ');
            golInter = int.Parse(array[0]);
            golGremio = int.Parse(array[1]);
            grenal++;
            if(golGremio > golInter)
            {
                gremioWin++;
            }else if(golInter > golGremio)
            {
                interWin++;
            }
            else
            {
                empate++;
            }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            input = int.Parse(Console.ReadLine());
        } while (input == 1);
        Console.WriteLine($"{grenal} grenais");
        Console.WriteLine($"Inter:{interWin}");
        Console.WriteLine($"Gremio:{gremioWin}");
        Console.WriteLine($"Empates:{empate}");
        if (interWin > gremioWin)
        {
            Console.WriteLine("Inter venceu mais");
        } else if (gremioWin > interWin)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }*/

        //1132
        /*int vlr1 = int.Parse(Console.ReadLine());
        int vlr2 = int.Parse(Console.ReadLine());

        if (vlr1 > vlr2)
        {
            int aux = vlr1;
            vlr1 = vlr2;
            vlr2 = aux;
        }
        int soma = 0;
        for (int i = vlr1; i <= vlr2; i++)
        {
            if (i % 13 != 0) soma += i;
        }
        Console.WriteLine(soma);*/



    }


}
