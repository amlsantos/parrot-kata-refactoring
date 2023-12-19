using Domain;

const int numberOfCoconuts = 10;
const double voltage = 34.0;
const bool isNailed = true;

var africanParrot = new Parrot(ParrotTypes.African, numberOfCoconuts, voltage, isNailed);
var africanSpeed = africanParrot.GetSpeed();
Console.WriteLine(africanSpeed);