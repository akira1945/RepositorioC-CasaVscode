//Dispositivos

using ConsoleAppPolimorfismo;
using ConsoleAppPolimorfismo.Exercicio_FormaGeometrica;
using ConsoleAppPolimorfismo.Exercicio_Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
#region Exercicio_Dispositivos



    Smartphone meuSmartphone = new Smartphone( "Xiaomi", "Black Shark 4", 2022 , "UiU12.Android", 100 );
    meuSmartphone.Ligar();
    meuSmartphone.Desligar();

    Tablet meuTablet = new Tablet( "Samsung", "Galaxy s9", 2018, 9.5,100);
    meuTablet.Ligar();
    meuTablet.Desligar();

#endregion Exercicio_Dispositivos

#region Exercicio_Notificacoes


    List<INotificacoes> notificacoes = new();
    notificacoes.Add(new EmailNotificacao());
    notificacoes.Add(new SMSNotificacao  ());
    notificacoes.Add(new PushNotificacao ());

        foreach (var notificacao in notificacoes)
        {
            notificacao.Enviar("Texto recebido com sucesso");
        }

#endregion Exercicio_Notificacoes

#region  Exercicio_FormaGeometrica

List<Forma> formas =new List<Forma>{
    new Circulo  ( 10,20 ),
    new Retangulo( 30,20 )
};

    foreach (Forma forma in formas){

        forma.Desenhar();
    }

#endregion Exercicio_FormaGeometrica