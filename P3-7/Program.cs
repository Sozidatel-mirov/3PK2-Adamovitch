using P3_7;

Client client1 = new Client();
client1.name = "Igor";

Client client2 = new Client();
client2.name = "Ivan";

Milk milk = new Milk();
milk.Name = "Cheese";
milk.Price = 400;
milk.freshness = "Yesterday";

Meat meat = new Meat();
meat.Name = "File";
meat.Price = 700;
meat.Animal = "Pig";

vegetable vegetable = new vegetable();
vegetable.Name = "Tomate";
vegetable.Price = 200;
vegetable.sort = "Bull Heart";

Store store = new Store();
store.SaveOrder(client1, meat);
store.SaveOrder(client1, meat);
store.SaveOrder(client1, milk);
store.SaveOrder(client1, meat);
Console.WriteLine(client1.AllPurshares);
//У меня определение скидки в классе product - абстрактный метод, поэтому он сразу переопределялся
//В классе Meat предоставлена дополнительная скидка ввиду его высокой цены