using Struct01;

Compromisso compromisso = new Compromisso();
compromisso.Texto = "Meu comromisso e com vocês";
compromisso.Data = new Data();
compromisso.Data.Dia = 5;
compromisso.Data.Mes = 5;
compromisso.Data.Ano = 1987;
compromisso.Horario = new Horario();
compromisso.Horario.Segundo = 1;
compromisso.Horario.Minuto = 26;
compromisso.Horario.Hora = 16;

Console.WriteLine(Funcoes.ImprimirData(compromisso.Data));
