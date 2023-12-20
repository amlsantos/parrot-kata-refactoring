using Domain;

const int numberOfCoconuts = 10;
const double voltage = 34.0;
const bool isNailed = true;

var africanParrot = Parrot.Create(ParrotTypes.African, numberOfCoconuts, voltage, isNailed);
var africanSpeed = africanParrot.GetSpeed();
Console.WriteLine($"African speed: {africanSpeed}");

var norwegianBlue = Parrot.Create(ParrotTypes.NorwegianBlue, numberOfCoconuts, voltage, isNailed);
var norwegianBlueSpeed = norwegianBlue.GetSpeed();
Console.WriteLine($"NorwegianBlue speed: {norwegianBlueSpeed}");

var europeanParrot = Parrot.Create(ParrotTypes.European, numberOfCoconuts, voltage, isNailed);
var europeanSpeed = europeanParrot.GetSpeed();
Console.WriteLine($"European speed: {europeanSpeed}");