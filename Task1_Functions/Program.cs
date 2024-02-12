
double result = CalculateFormula(6, 10, 3, 3);
printResult(result);


double CalculateFormula(double a, double b, double c, double d){

    return (a * b) / (c + d);
}

void printResult(double result){

    System.Console.WriteLine(result);

}