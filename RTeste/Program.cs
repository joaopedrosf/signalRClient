using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace Realtime {
    internal class Program {
        static void Main(string[] args) {
            string hubUrl = "";
            string invokeMethodName = "";
            string onMethodName = "";

            var connection = new HubConnectionBuilder()
                .WithUrl(hubUrl)
                .WithAutomaticReconnect()
                .Build();

            connection.StartAsync().Wait();
            connection.InvokeAsync(invokeMethodName, 244);
            connection.On<object>(onMethodName, param => {
                Console.WriteLine(param);
            });

            Console.ReadKey();
        }
    }
}
