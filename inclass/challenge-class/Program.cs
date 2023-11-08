SmartDevice d1 = new SmartDevice("SmartTV");

d1.IsOn();
d1.TurnOn();
d1.IsOn();
Thread.Sleep(5000);
d1.TurnOff();
d1.IsOn();
d1.CheckTime();


