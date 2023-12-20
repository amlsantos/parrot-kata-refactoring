using Domain;

const int numberOfCoconuts = 10;
const double voltage = 34.0;
const bool isNailed = true;

var africanParrot = new Parrot(ParrotTypes.African, voltage, isNailed);
var africanSpeed = africanParrot.GetSpeed();
Console.WriteLine($"African speed: {africanSpeed}");

var norwegianBlue = new Parrot(ParrotTypes.NorwegianBlue, voltage, isNailed);
var norwegianBlueSpeed = norwegianBlue.GetSpeed();
Console.WriteLine($"NorwegianBlue speed: {norwegianBlueSpeed}");

var europeanParrot = new Parrot(ParrotTypes.European, voltage, isNailed);
var europeanSpeed = europeanParrot.GetSpeed();
Console.WriteLine($"European speed: {europeanSpeed}");