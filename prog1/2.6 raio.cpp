#include <iostream.h>
int main()
{
    float raio, resultado;
    
    cout<<"Digite o valor do raio: ";
    cin>>raio;
    resultado=(raio*raio)*3.14159;
    cout<<"Resultado aproximado: "<<resultado<<" (pi"<<raio*raio<<"cm^2)\n";
        
    system("pause");
    return 0;
}
