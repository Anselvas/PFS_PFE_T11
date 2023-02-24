
// SEGUNDA FORMA DE RESOLVER O EXERCICIO

/*let numeroDeAlunos = 10;
let contador = 0;
while (contador<= numeroDeAlunos)
{


    if(contador == 0){
        console.log(`${contador} - ZERO `) // INTERPOLAÇÃO  
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - PAR`)
    
    }
    else{
        console.log(`${contador} - IMPAR`)
    }
    contador++
}
*/
// TERCEIRA FORMA DE RESOLVER O EXERCICIO (não gostei desta resolução)

let numeroDeAlunos = 10;
let contador = 0;
do
{


    if(contador == 0){
        console.log(`${contador} - ZERO `) // INTERPOLAÇÃO  
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - PAR`)
    
    }
    else{
        console.log(`${contador} - IMPAR`)
    }
    contador++
}while (contador<= numeroDeAlunos);