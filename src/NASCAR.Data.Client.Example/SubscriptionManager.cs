using Microsoft.AspNetCore.SignalR.Client;
using NASCAR.Data.Client.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASCAR.Data.Client.Example
{
    public static class SubscriptionManager
    {
        private static List<string> subscriptions = new List<string>();
        private static HubConnection connection = null;
        public static void Initialize(Configuration config) 
        {
            connection = new HubConnectionBuilder()
                .WithUrl($"{config.BasePath}notifications", options =>
                {
                    options.AccessTokenProvider = () =>
                        Task.FromResult(config.AccessToken);
                })
                .WithAutomaticReconnect()
                .Build();

            // Hook up handlers
            connection.On<object>("EntityUpdated", payload =>
            {
                Console.WriteLine($"[Event] Entity Updated: {payload}");
            });

            connection.On<object>("EntityAdded", payload =>
            {
                Console.WriteLine($"[Event] Entity Added: {payload}");
            });

            connection.On<object>("EntityDeleted", payload =>
            {
                Console.WriteLine($"[Event] Entity Added: {payload}");
            });

            //Configure connection behaviors
            connection.Reconnecting += error =>
            {
                Console.WriteLine($"[SignalR] Reconnecting: {error?.Message}");
                return Task.CompletedTask;
            };
            connection.Reconnected += connectionId =>
            {
                Console.WriteLine($"[SignalR] Reconnected. ConnectionId={connectionId}");
                return Task.CompletedTask;
            };
            connection.Closed += error =>
            {
                Console.WriteLine($"[SignalR] Closed: {error?.Message}");
                return Task.CompletedTask;
            };
        }

        public static void Add(string subscription) 
            => subscriptions.Add(subscription);

        public static async Task Start()
        {
            if( connection == null )
                Console.WriteLine("Must initialize SubscriptionManager first.");

            if (subscriptions.Count <= 0)
                Console.WriteLine("No subscriptions to add.");

            try
            {
                Console.WriteLine("[SignalR] Starting connection...");
                await connection.StartAsync();
                Console.WriteLine("[SignalR] Connected.");

                foreach(var sub in subscriptions)
                {
                    Console.WriteLine($"Subscribing to {sub}...");
                    await connection.InvokeAsync("Subscribe", sub);
                }

                Console.WriteLine("Press ENTER to exit.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex.Message}");
            }
            finally
            {
                await connection.DisposeAsync();
            }
        }
    }
}
