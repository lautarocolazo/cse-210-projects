Fraction fraction_no_parameters =  new Fraction();
Fraction fraction_one_parameter =  new Fraction(5);
Fraction fraction_two_parameter =  new Fraction(3, 4);


Console.WriteLine(fraction_no_parameters.GetTop());
Console.WriteLine(fraction_no_parameters.GetBottom() + Environment.NewLine);

Console.WriteLine(fraction_one_parameter.GetTop());
Console.WriteLine(fraction_one_parameter.GetBottom() + Environment.NewLine);

Console.WriteLine(fraction_two_parameter.GetTop());
Console.WriteLine(fraction_two_parameter.GetBottom() + Environment.NewLine);

Console.WriteLine(fraction_two_parameter.GetFractionString());
Console.WriteLine(fraction_two_parameter.GetDecimalValue());
