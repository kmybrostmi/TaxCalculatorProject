// See https://aka.ms/new-console-template for more information


using CompositeDesignPattern.Infra;
using CompositeDesignPattern.Interface;

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
