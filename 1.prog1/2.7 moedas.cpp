#include <iostream.h>
int main()
{
    double real1, ce50, ce25, ce10, ce5, ce1;
    
    cout<<"Numero de moedas de 1 real: ";
    cin>>real1;
    cout<<"Numero de moedas de 50 centavos: ";
    cin>>ce50;
    cout<<"Numero de moedas de 25 centavos: ";
    cin>>ce25;
    cout<<"Numero de moedas de 10 centavos: ";
    cin>>ce10;
    cout<<"Numero de moedas de 5 centavos: ";
    cin>>ce5;
    cout<<"Numero de moedas de 1 centavo: ";
    cin>>ce1;
    
    ce50=ce50*0.5;
    ce25=ce25*0.25;
    ce10=ce10*0.1;
    ce5=ce5*0.05;
    ce1=ce1*0.01;
    
    cout<<"\nQuantia total calculada: R$"<<real1+ce50+ce25+ce10+ce5+ce1<<"\n\n";
    
    system("pause");
    return 0;
}
