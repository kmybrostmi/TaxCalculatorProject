// See https://aka.ms/new-console-template for more information


using CommandDesignPattern.Data;
using CommandDesignPattern.Infra.Commands;
using CommandDesignPattern.Infra.Invokers;
using CompositeDesignPattern.Infra;
using CompositeDesignPattern.Interface;
using EShop_DataAccess.Infra;
using EShop_DataAccess.Infra.Commands;
using EShop_DataAccess.Infra.Enums;
using EShop_DataAccess.Repository;
using MediatorDesignPattern.Infra.Concrete;
using MediatorDesignPattern.Infra.Concrete.Mediator;

#region Commandregion
//var dataRecevier = new DataReciever();
//var invoker = new DataCommandInvoker();

//invoker.SetCommand(new UpsertCommand("item1", "value1", dataRecevier));
//invoker.ExecuteCommand();

//invoker.SetCommand(new DeleteCommand("item1", dataRecevier));
//invoker.ExecuteCommand();

//Console.ReadKey();
#endregion


#region CompositeRegion

////Creating Leaf Objects
//ICustomComponent cpu = new Leaf("cpu", 100);
//ICustomComponent ram = new Leaf("ram", 150);
//ICustomComponent hardDisk = new Leaf("hardDisk", 700);
//ICustomComponent mouse = new Leaf("mouse", 70);
//ICustomComponent keyBoard = new Leaf("keyBoard", 85);


////Creating Composite Objects
//ICustomComponent motherBoard = new Composite("motherBoard");
//ICustomComponent cabinet = new Composite("cabinet");
//ICustomComponent peripherals = new Composite("peripherals");


////Whole Device
//ICustomComponent computer = new Composite("computer");


////Creatin tree Structure

////Adding CPU And RAM in MotherBoard
//motherBoard.AddComponent(cpu);
//motherBoard.AddComponent(ram);


////Adding MotherBoard And HardDisk in Case
//cabinet.AddComponent(motherBoard);
//cabinet.AddComponent(hardDisk);

////Adding Mouse And KeyBoard in Peripherals
//peripherals.AddComponent(mouse);
//peripherals.AddComponent(keyBoard);

////To Dispaly The Price Of Computer
//var price = computer.CalculatePrice();
//Console.WriteLine(price.ToString());
//Console.ReadKey();

#endregion

#region wrapper

//static void PrintCard(ShoppingCartRepository shoppingCartRepository)
//{
//    var totalPrice = 0m;
//    foreach (var item in shoppingCartRepository.ListItems)
//    {
//        var price = item.Value.Product.Price * item.Value.Quantity;

//        Console.WriteLine($"{item.Key}) " +
//            $"{item.Value.Product.Price} * {item.Value.Quantity} = {price}");

//        totalPrice += price;
//    }
//    Console.WriteLine($"TotalPrice is :{totalPrice}");
//}

#endregion


#region EShop_DataAccess_Executer

//var shoppingCartRepository = new ShoppingCartRepository();
//var productReposiroty = new ProductReposiroty();

//var product = productReposiroty.FindById("1");

//var addToCartCommand = new AddToCartCommand(shoppingCartRepository,productReposiroty,product);

//var increaseQuantityCommand = new ChangeQuantityCommand(shoppingCartRepository,
//    productReposiroty, product, Operations.Increase);

//var manager = new CommandManager();
//manager.Invoke(addToCartCommand);
//manager.Invoke(increaseQuantityCommand);
//manager.Invoke(increaseQuantityCommand);
//manager.Invoke(increaseQuantityCommand);

//PrintCard(shoppingCartRepository);

//manager.Undo();

//PrintCard(shoppingCartRepository);




#endregion


#region MediatorDesignPattern

var networkMediator = new NetworkMediator();

var desktopComputer = new DesktopComputer("computer-1", networkMediator);
var server = new Server("server-1",networkMediator);

networkMediator.Register("computer-1", desktopComputer);
networkMediator.Register("server-1", server);

desktopComputer.SendCommand("server-1", "reboot");
server.SendCommand("computer-1", "trigger-updates");

Console.ReadKey();
#endregion