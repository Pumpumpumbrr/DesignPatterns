using DesignPatterns.Adapter;
using DesignPatterns.Builder;
using DesignPatterns.Observer;


#region Builder
Console.WriteLine("Builder pattern:");

var premiumCarBuilder = new PremiumCarBuilder();
var comfortPlusCarBuilder = new ComfortPlusCarBuilder();
var carDiller = new CarDiller();

var firstCar = carDiller.BuyCar(premiumCarBuilder, CarModels.A2);
Console.WriteLine(firstCar);

var secondCar = carDiller.BuyCar(comfortPlusCarBuilder, CarModels.A1);
Console.WriteLine(secondCar);
#endregion

#region Adapter
Console.WriteLine("\nAdapter pattern:");

var messageService = new MessageService();

var email = new Email("hello, i am the email");
messageService.SendMessage(email);

var dove = new Dove("hello, i am the dove");
var adaptedDove = new Adapter(dove);
messageService.SendMessage(adaptedDove);
#endregion

#region Observer
Console.WriteLine("\nObserver pattern:");

var user = new User();
var entepreneur = new Entrepreneur();
var communalService = new CommunalService();

var wodocanal = new Wodocanal();
wodocanal.AttachObserver(user);
wodocanal.AttachObserver(entepreneur);
wodocanal.AttachObserver(communalService);

wodocanal.Notify();

wodocanal.DetachObserver(entepreneur);
wodocanal.Notify();
#endregion