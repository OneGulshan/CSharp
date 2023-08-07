﻿usingSystem;
usingstaticCSharp.Program;

namespaceCSharp
{
staticclassMyStaticClass
{
publicstaticvoidFunc2(thisExtensionClassec)//Thisisanextensionmethodnoneedtoprovidevaluetothisparameter//thisextensionmethodparameteriscalledbindingparametersthatsbelongstoExtensionClassspecifiedhere
{
Console.WriteLine("Thisisthirdmethod..");
}

publicstaticvoidFunc3(thisExtensionClassec,inta)//inta<-thisisannormalparameternotignoredoncallingtime
{
Console.WriteLine("Thisisthirdmethod.."+a);
}publicstaticboolIsGreaterThan(thisinti,intvalue)
{
returni>value;
}
}
}
