﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dev5
{
    public class Menu
    {               
        Command command;
        WorkWithCatalog commandForCatalog = new WorkWithCatalog();
        GetInfoAboutCarFlomConsole infoAboutCar = new GetInfoAboutCarFlomConsole();
        
        public void Show()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nEnter command:\n" +
                             "1.add auto to catalog\n" +
                             "2.count all\n" +
                             "3.count types\n" +
                             "4.average price\n" +
                             "5.average price type\n" +
                             "6.exit\n");

                var inputString = Console.ReadLine();
               
                switch (inputString)
                {                                      
                    case AvailableCommands.AddToCatalogCommand:
                        Car car = infoAboutCar.GetCarFromConsole();
                        command = new AddCarToCatalogCommand(commandForCatalog, car);
                        command.Execute();
                        break;
                    case AvailableCommands.CountAllCommand:
                        command = new CountAllCommand(commandForCatalog);
                        command.Execute();
                        break;
                    case AvailableCommands.CountTypesCommand:
                        command = new CountTypesCommand(commandForCatalog);
                        command.Execute();
                        break;
                    case AvailableCommands.AveragePriceCommand:
                        command = new AveragePriceCommand(commandForCatalog);
                        command.Execute();
                        break;
                    case AvailableCommands.AveragePriceTypeCommand:
                        string brand = infoAboutCar.GetBrand();
                        command = new AveragePriceTypeCommand(commandForCatalog, brand);
                        command.Execute();
                        break;                 
                    case AvailableCommands.ExitCommand:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }
    }
}