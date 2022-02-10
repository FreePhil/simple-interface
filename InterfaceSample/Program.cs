
using InterfaceSample;

IPerson someone;
    
someone = new Chinese();
Console.WriteLine($"中國人說 '{someone.GetGreeting()}'");

someone = new American();
Console.WriteLine($"American says '{someone.GetGreeting()}'");