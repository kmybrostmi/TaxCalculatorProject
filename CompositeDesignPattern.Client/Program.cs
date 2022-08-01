// See https://aka.ms/new-console-template for more information


using CommandDesignPattern.Data;
using CommandDesignPattern.Infra.Commands;
using CommandDesignPattern.Infra.Invokers;
using CompositeDesignPattern.Infra;
using CompositeDesignPattern.Interface;

#region Commandregion
var dataRecevier = new DataReciever();
var invoker = new DataCommandInvoker();

invoker.SetCommand(new UpsertCommand("item1", "value1", dataRecevier));
invoker.ExecuteCommand();

invoker.SetCommand(new DeleteCommand("item1", dataRecevier));
invoker.ExecuteCommand();

Console.ReadKey();
#endregion


#region CompositeRegion

//Creating Leaf Objects
ICustomComponent cpu = new Leaf("cpu", 100);
ICustomComponent ram = new Leaf("ram", 150);
ICustomComponent hardDisk = new Leaf("hardDisk", 700);
ICustomComponent mouse = new Leaf("mouse", 70);
ICustomComponent keyBoard = new Leaf("keyBoard", 85);


//Creating Composite Objects
ICustomComponent motherBoard = new Composite("motherBoard");
ICustomComponent cabinet = new Composite("cabinet");
ICustomComponent peripherals = new Composite("peripherals");


//Whole Device
ICustomComponent computer = new Composite("computer");


//Creatin tree Structure

//Adding CPU And RAM in MotherBoard
motherBoard.AddComponent(cpu);
motherBoard.AddComponent(ram);


//Adding MotherBoard And HardDisk in Case
cabinet.AddComponent(motherBoard);
cabinet.AddComponent(hardDisk);

//Adding Mouse And KeyBoard in Peripherals
peripherals.AddComponent(mouse);
peripherals.AddComponent(keyBoard);

//To Dispaly The Price Of Computer
var price = computer.CalculatePrice();
Console.WriteLine(price.ToString());
Console.ReadKey();

#endregion